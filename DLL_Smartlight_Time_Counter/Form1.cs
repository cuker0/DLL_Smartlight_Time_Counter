using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOLUDPIF20_DOTNET;



namespace DLL_Smartlight_Time_Counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum Index_Colours
        {
            none = 0x0,
            green = 0x1,
            red = 0x2,
            yellow = 0x3,
            blue = 0x4,
            orange = 0x5,
            white = 0x7,
        }

        public enum Segments
        {
            one = 0x1,
            two = 0x2,
            three = 0x3,
            four = 0x4,
            five = 0x5,

        }

        public enum LevelResolution
        {
            eight = 0x0,
            ten = 0x1,
            twelve = 0x2,
            fourteen = 0x3,
            sixteen = 0x4,

        }
        clsIOLUDPIF20 BNI005H = new clsIOLUDPIF20();
        clsIOLUDPIF20.clsUDPIOLMaster IOLM = null;

        int ActivePort = 0;
        //int ActiveMaster = 0;
        int Port0NR = 0;
        int i = 0;
       

      
        private void WriteInfo(string text)
        {

            tbMessages.AppendText(text + "\r\n");
            tbMessages.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BackgroundColor.SelectedItem = Enum.GetValues(typeof(Index_Colours));
            SegmentsNO.SelectedItem = Enum.GetValues(typeof(Segments));
            RunlightColor.SelectedItem = Enum.GetValues(typeof(Index_Colours));
            LevelLimit1.SelectedItem = Enum.GetValues(typeof(Index_Colours));
            LevelLimit2.SelectedItem = Enum.GetValues(typeof(Index_Colours));
            LevelLimit3.SelectedItem = Enum.GetValues(typeof(Index_Colours));
            LevelLimit4.SelectedItem = Enum.GetValues(typeof(Index_Colours));
            LevelLimit5.SelectedItem = Enum.GetValues(typeof(Index_Colours));
           
            clsIOLUDPIF20.eError result = clsIOLUDPIF20.eError.OK;
            tbMessages.Text = "";

            //Read DLL Info
            clsIOLUDPIF20.clsDllInfo DLLInfo = new clsIOLUDPIF20.clsDllInfo();

            WriteInfo("Info about IOLUDPIF20.DLL:");
            WriteInfo("    Revision of C DLL:       " + DLLInfo.C_DLL_Version);
            WriteInfo("    Revision of .NET DLL:    " + DLLInfo.NET_DLL_Version);
            WriteInfo("");



            //search on UDP Masters
            clsIOLUDPIF20.clsUDPIOLMaster[] IOLMList = BNI005H.GetUDPMaster();
                     
            if (IOLMList.Length == 0) //jezeli nie wyszuka urzadzen
            {
                result = clsIOLUDPIF20.eError.DEVICE_NOT_AVAILABLE;
                goto RError;
            }

           // IOLM = IOLMList[0]; //laczy do pierwszego wyszukanego mastera Profinet/EthernetIP -> mozna by dac Combobox

            for (int i = 0; i < IOLMList.Length; i++)
            {
                avaliablemasters.Items.Add(IOLMList[i].Name);
            }

            
            return;


            // Obsluga  bledow

            RError: //label
            if (result == clsIOLUDPIF20.eError.DEVICE_NOT_AVAILABLE)
            {
                MessageBox.Show("Error Message: " + result.ToString() + "\r\n" +
                   "Maybe the device is not existing, or the firewall blocks the communication" + "\r\n" +
                   "Please ensure either the UDP communication or attach the network device" + "\r\n" +
                   "and start the program again", "Critical Warning");
            }
            else
            {
                MessageBox.Show("Error Message: " + result.ToString(), "Critical Warning");
                Environment.Exit(0);
            }

        }

        private void ActivatePort(int pActivePort)
        {
            //  TPortConfiguration portConfig = new TPortConfiguration();
            //  ConfigurePort(ref portConfig);

            ActivePort = pActivePort;
            IOLM.Port[ActivePort].Configuration.Clear();
            IOLM.Port[ActivePort].Configuration.ConfiguredMode = clsIOLUDPIF20.eConfiguredMode.IOLINK_OPERATE;
            IOLM.Port[ActivePort].Configuration.InputLength = 0x00;
            IOLM.Port[ActivePort].Configuration.OutputLength = 0x04;

            clsIOLUDPIF20.eError result = IOLM.Port[ActivePort].Configuration.IOL_SetPortConfig();


            if (result != clsIOLUDPIF20.eError.OK)
                goto ActivateError;

            //Wait some time for master detecting the device

            System.Threading.Thread.Sleep(5000);

            GetDeviceInfo(ref IOLM, ActivePort);


            timer1.Enabled = true;

            return;

            ActivateError:
            MessageBox.Show("Error Message: " + result, "Critical Warning");
        }


        private void GetDeviceInfo(ref clsIOLUDPIF20.clsUDPIOLMaster Master, int Port)
        {
            //Read Info from Device with Directparameterpage

            IOLM.Port[Port].Mode.IOL_GetMode(false);


            if (IOLM.Port[Port].Mode.DeviceState.DeviceState != clsIOLUDPIF20.eDeviceState.LOST)
            {
                System.Threading.Thread.Sleep(1000);//
                Write("IO-Link Device connected:");
                Write("   VendorId:                  " + IOLM.Port[Port].Mode.DirectParameterPage1.VendorId());
                Write("   DeviceId:                  " + IOLM.Port[Port].Mode.DirectParameterPage1.DeviceId());
                Write("   IO-Link Revision:          " + IOLM.Port[Port].Mode.DirectParameterPage1.RevisionId());
                Write("   ProcessData Input Length:  " + IOLM.Port[Port].Mode.DirectParameterPage1.PDInLength());
                Write("   ProcessData Output Length: " + IOLM.Port[Port].Mode.DirectParameterPage1.PDOutLength());
                Write("   SIO mode supported:        " + IOLM.Port[Port].Mode.DirectParameterPage1.SIOModeSupported());
            }
            else
            {
                Write("No Device Connected");
            }
            // Write();
        }
        private void Form1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            if (IOLM != null)
            {
                IOLM.Port[avaliableportNo.SelectedIndex].Configuration.Deactivate();
                IOLM.IOL_Destroy(); // kill komunikacji UDP                         
            }
        }

        private void Write(string text)
        {
            tbMessages.AppendText(text + "\r\n");
            tbMessages.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e) // cykliczny odczyt informacji z urzadzenia IOLINK
        {
         
            timer1.Enabled = false;
         

            clsIOLUDPIF20.eError result = IOLM.Port[ActivePort].IOL_ReadInputs();
            /*
             if (result == clsIOLUDPIF20.eError.INTERNAL_ERROR)
             {
                 MessageBox.Show("Connection lost to the connected UDP IO-Link Master", "Critical Warning");
                 Environment.Exit(0);
             } 

             textBox2.Text = BNI005H.Utils.GetHexStringFromBytes(ref IOLM.Port[ActivePort].Inputs.Data);

             */

            if (IOLM.Port[ActivePort].DeviceState.EventAvailable)
            {
                // lista eventow wypluwanych przez urzadzenie IOLINK
                IOLM.LastEvent.IOL_ReadEvent(ref IOLM.Port[ActivePort].DeviceState);
                Write("Event: Port=" + IOLM.LastEvent.Port + " Instance=" + IOLM.LastEvent.Instance + " Type=" +
                              IOLM.LastEvent.Type + " Mode=" +
                              IOLM.LastEvent.Mode + " Code=" +
                              IOLM.LastEvent.EventCode);
            }

            result = IOLM.Port[ActivePort].IOL_ReadOutputs();

            //  tHex2Dec.Text = Convert.ToInt32(textBox2.Text).ToString();

         
            timer1.Enabled = true;
        }
     

        private void chkSegmentMode_CheckedChanged(object sender, EventArgs e)
        {

            ISDU_IOLINK_CHANGE(64, 0, 0);
        }

        private void chkLevelMode_CheckedChanged(object sender, EventArgs e)
        {

            ISDU_IOLINK_CHANGE(64, 0, 1);
        }
        public void ISDU_IOLINK_CHANGE(int index, int subindex, int value)
        {
            byte[] data = BNI005H.Utils.GetBytesFromTextHex(value.ToString());
            byte[] dataarray = new byte[ISDU_IOLINK_READ(index, subindex)];

            switch (ISDU_IOLINK_READ(index, subindex))
            {
                case 1:
                    dataarray[0] = data[0];
                    break;
                case 2:
                    dataarray[0] = 0;
                    dataarray[1] = data[0];
                    break;
            }
           

            int ErrorCode = 0;
            clsIOLUDPIF20.eError result = IOLM.Port[ActivePort].IOL_WriteReq(Convert.ToInt32(index.ToString()), Convert.ToInt32(subindex.ToString()), ref dataarray, ref ErrorCode);
        }
        public int ISDU_IOLINK_READ(int index, int subindex)
        {
            byte[] data = null;
            int ErrorCode = 0;

            //  string indexreadvalue;

            IOLM.Port[ActivePort].IOL_ReadReq(Convert.ToInt32(index), Convert.ToInt32(subindex), ref data, ref ErrorCode);

            return data.Length;
            //  if (ErrorCode == 0)
            //  textbox5.Text = BNI005H.Utils.GetHexStringFromBytes(ref data);
            //   return indexreadvalue;

        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright (c) 2018 Balluff Sp. z o.o." + "\r\n" +
        "IOLINK Master + Smartlight -> Time converter" + "\r\n" +
        "www.balluff.pl", "information");
        }

        private void masterConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Segment_Click(object sender, EventArgs e)
        {
            ISDU_IOLINK_CHANGE(64, 0, 0);
        }

        private void Level_Click(object sender, EventArgs e)
        {
            ISDU_IOLINK_CHANGE(64, 0, 1);  // ustawienie na tryb Level Mode
        }

        private void Runlight_Click(object sender, EventArgs e)
        {
            ISDU_IOLINK_CHANGE(64, 0, 2);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            double value = LevelSlider.Value;
            ushort ushvalue = (ushort)value;

            byte[] Outputs = BNI005H.Utils.GetBytesFromTextHex(ushvalue.ToString("X"));
            Outputs.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 0);
            // Outputs.CopyTo(IOLM.Port[ActivePort].Outputs.Data, IOLM.Port[ActivePort].Configuration.OutputLength);

            clsIOLUDPIF20.eError result = IOLM.Port[ActivePort].IOL_WriteOutputs();
            // value.ToString() = BNI005H.Utils.GetHexStringFromBytes(ref Outputs);

            //textbox3.Text = ushvalue.ToString();
            //textbox4.Text = ushvalue.ToString("X");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double value = SliderSeg1.Value;

            ISDU_IOLINK_CHANGE(73, 0, (int)value);
        }

        private void SliderSeg2_Scroll(object sender, EventArgs e)
        {
            double value = SliderSeg2.Value;
            ISDU_IOLINK_CHANGE(74, 0, (int)value);
        }

        private void SliderSeg3_Scroll(object sender, EventArgs e)
        {
            double value = SliderSeg3.Value;
            ISDU_IOLINK_CHANGE(74, 0, (int)value);
        }

        private void SliderSeg4_Scroll(object sender, EventArgs e)
        {
            double value = SliderSeg4.Value;
            ISDU_IOLINK_CHANGE(75, 0, (int)value);
        }

        private void SliderSeg5_Scroll(object sender, EventArgs e)
        {
            double value = SliderSeg5.Value;
            ISDU_IOLINK_CHANGE(76, 0, (int)value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISDU_IOLINK_CHANGE(64, 0, 1);

            timer2.Start();
            TimeValue.ReadOnly = true;
            TimeValue.Visible = false;
            TimeValue_countdown.ReadOnly = true;
            TimeValue_countdown.Visible = true;
            Startbutton.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         //    double value = ((double.Parse(TimeValue.Text)))*60;

            string[] arr = TimeValue.Text.Split(':');
            double hours = double.Parse(arr[0].ToString()) * 3600;
            double mins = double.Parse(arr[1].ToString())*60;
            double seconds = double.Parse(arr[2].ToString());

            double value = hours + mins + seconds;
            ushort ushvalue = (ushort)value;    
            ushort ushOut;
            double OUT;
            double OUTmax = 255.0;         
            double INmax = value;

            TimeValue_countdown.Text = value.ToString() ;
            double value_countdown = ((double.Parse(TimeValue_countdown.Text)));
          
                         
            if (value_countdown > i)
            {
                
                value_countdown = value_countdown - i;
                TimeSpan time = TimeSpan.FromSeconds(value_countdown);
                TimeValue_countdown.Text = time.ToString(@"hh\:mm\:ss");
                i = i + 1;

            }
            else if(value_countdown == i)  /// do sprawdzenia !!!!
            {
                double valuedominantred = 2;
                ISDU_IOLINK_CHANGE(68, 0, (int)valuedominantred);

                byte[] Outputsfinish = BNI005H.Utils.GetBytesFromTextHex("0XFF");
                Outputsfinish.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 0);
                
                clsIOLUDPIF20.eError resultfinish = IOLM.Port[ActivePort].IOL_WriteOutputs();
            }

                else
            {
                
                timer2.Stop();
                TimeValue_countdown.Visible = false;
                TimeValue.Visible = true;
                TimeValue.ReadOnly = false;
                i = 0;
                TimeValue.Text = null;
            }



            if (value_countdown == 120)
            {

                timer3.Start();
                ushort ushBuzzin = 0x80;
                byte[] Outputs120 = BNI005H.Utils.GetBytesFromTextHex(ushBuzzin.ToString("X"));
                Outputs120.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);
                
                clsIOLUDPIF20.eError result120 = IOLM.Port[ActivePort].IOL_WriteOutputs();
                timer3.Stop();

               
            }

            if (value_countdown == 119)
            {

                timer3.Start();
                ushort ushBuzzout = 0x00;
                byte[] Outputs119 = BNI005H.Utils.GetBytesFromTextHex(ushBuzzout.ToString("X"));
                Outputs119.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

                clsIOLUDPIF20.eError result119 = IOLM.Port[ActivePort].IOL_WriteOutputs();
                timer3.Stop();
            }



            if (value_countdown == 6)
            {
               
                ushort ushBuzz = 0x80;
                byte[] Outputs120 = BNI005H.Utils.GetBytesFromTextHex(ushBuzz.ToString("X"));
                Outputs120.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

               clsIOLUDPIF20.eError result120 = IOLM.Port[ActivePort].IOL_WriteOutputs();               
            }

            if (value_countdown == 5)
            {           
                ushort ushBuzzout = 0x00;
                byte[] Outputs121 = BNI005H.Utils.GetBytesFromTextHex(ushBuzzout.ToString("X"));
                Outputs121.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

                clsIOLUDPIF20.eError result121 = IOLM.Port[ActivePort].IOL_WriteOutputs();

            }

            if (value_countdown == 4)
            {

                ushort ushBuzz = 0x80;
                byte[] Outputs120 = BNI005H.Utils.GetBytesFromTextHex(ushBuzz.ToString("X"));
                Outputs120.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

                clsIOLUDPIF20.eError result120 = IOLM.Port[ActivePort].IOL_WriteOutputs();

            }
            if (value_countdown == 3)
            {
                      
                ushort ushBuzzout = 0x00;
                byte[] Outputs121 = BNI005H.Utils.GetBytesFromTextHex(ushBuzzout.ToString("X"));
                Outputs121.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

                clsIOLUDPIF20.eError result121 = IOLM.Port[ActivePort].IOL_WriteOutputs();

            }
            if (value_countdown == 2)
            {

                ushort ushBuzz = 0x80;
                byte[] Outputs120 = BNI005H.Utils.GetBytesFromTextHex(ushBuzz.ToString("X"));
                Outputs120.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

                clsIOLUDPIF20.eError result120 = IOLM.Port[ActivePort].IOL_WriteOutputs();

            }
            if (value_countdown == 1)
            {
                ushort ushBuzzout = 0x00;
                byte[] Outputs121 = BNI005H.Utils.GetBytesFromTextHex(ushBuzzout.ToString("X"));
                Outputs121.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 2);

                clsIOLUDPIF20.eError result121 = IOLM.Port[ActivePort].IOL_WriteOutputs();

            }


            OUT = (OUTmax / (INmax)) * i;
                ushOut = (ushort)OUT;

                byte[] Outputs = BNI005H.Utils.GetBytesFromTextHex(ushOut.ToString("X"));
                Outputs.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 0);


                clsIOLUDPIF20.eError result = IOLM.Port[ActivePort].IOL_WriteOutputs();

          
        }

    
        private void Stopbutton_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            i = 0;
            TimeValue.Text = null;
            TimeValue.ReadOnly = false;
            TimeValue_countdown.Visible = false;
            TimeValue_countdown.Text = null;
            TimeValue.Visible = true;
            TimeValue.ReadOnly = false;
            Startbutton.Enabled = true;


            byte[] Outputs = BNI005H.Utils.GetBytesFromTextHex("0");
            Outputs.CopyTo(IOLM.Port[ActivePort].Outputs.Data, 0);


            clsIOLUDPIF20.eError result = IOLM.Port[ActivePort].IOL_WriteOutputs();
        }

      
        private void avaliablemasters_SelectedIndexChanged(object sender, EventArgs e)
        {

            clsIOLUDPIF20.clsUDPIOLMaster[] IOLMList = BNI005H.GetUDPMaster();
            if (avaliablemasters.SelectedItem != null)
            {
                int ActiveMaster = int.Parse(avaliablemasters.SelectedIndex.ToString());
                IOLM = IOLMList[ActiveMaster];
            }
            

            if (IOLM.IOL_Create() == clsIOLUDPIF20.eError.OK)
            {
                //Read Master Info
                WriteInfo("IO-Link UDP Master");
                WriteInfo("    IP Address:      " + IOLM.Name);
                WriteInfo("    NetworkName:      " + IOLM.NetworkName);
                WriteInfo("    Firmware Revision:      " + IOLM.RevisionFirmware);
                WriteInfo("    IO-Link Stack Revision: " + IOLM.RevisionIOLStack);


              
            }

        }

        private void portNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (avaliablemasters.SelectedItem != null)
            {
                ActivatePort(avaliableportNo.SelectedIndex);
            }
            Port0NR = avaliableportNo.SelectedIndex;

            ActivatePort(Port0NR); //aktywacja portu 0 na masterze IOLINK
          
            
        }
    }
}
