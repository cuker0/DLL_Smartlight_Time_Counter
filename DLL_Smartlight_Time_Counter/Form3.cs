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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        clsIOLUDPIF20 BNI005H = new clsIOLUDPIF20();
        clsIOLUDPIF20.clsUDPIOLMaster IOLM = null;

        int ActivePort = 0;
        int Port0NR = 0;
        int i = 0;
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
          
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
        private void Form3_Load(object sender, EventArgs e)
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
            //tbMessages.Text = "";
            clsIOLUDPIF20.clsUDPIOLMaster[] IOLMList = BNI005H.GetUDPMaster();




            if (IOLMList.Length == 0) //jezeli nie wyszuka urzadzen
            {
                result = clsIOLUDPIF20.eError.DEVICE_NOT_AVAILABLE;
                goto RError;
            }

            IOLM = IOLMList[0];

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
            // dataarray[1] = (byte)value;

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
    }
}
