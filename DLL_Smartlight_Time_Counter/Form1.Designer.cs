namespace DLL_Smartlight_Time_Counter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Startbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Segment = new System.Windows.Forms.Button();
            this.Level = new System.Windows.Forms.Button();
            this.Runlight = new System.Windows.Forms.Button();
            this.LevelLimit1 = new System.Windows.Forms.ComboBox();
            this.Dominant1 = new System.Windows.Forms.CheckBox();
            this.SliderSeg1 = new System.Windows.Forms.TrackBar();
            this.SliderSeg2 = new System.Windows.Forms.TrackBar();
            this.Dominant2 = new System.Windows.Forms.CheckBox();
            this.LevelLimit2 = new System.Windows.Forms.ComboBox();
            this.SliderSeg3 = new System.Windows.Forms.TrackBar();
            this.Dominant3 = new System.Windows.Forms.CheckBox();
            this.LevelLimit3 = new System.Windows.Forms.ComboBox();
            this.SliderSeg4 = new System.Windows.Forms.TrackBar();
            this.Dominant4 = new System.Windows.Forms.CheckBox();
            this.LevelLimit4 = new System.Windows.Forms.ComboBox();
            this.SliderSeg5 = new System.Windows.Forms.TrackBar();
            this.Dominant5 = new System.Windows.Forms.CheckBox();
            this.LevelLimit5 = new System.Windows.Forms.ComboBox();
            this.BackgroundColor = new System.Windows.Forms.ComboBox();
            this.RunlightColor = new System.Windows.Forms.ComboBox();
            this.SegmentsNO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LevelSlider = new System.Windows.Forms.TrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Stopbutton = new System.Windows.Forms.Button();
            this.TimeValue_countdown = new System.Windows.Forms.TextBox();
            this.TimeValue = new System.Windows.Forms.MaskedTextBox();
            this.avaliablemasters = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.avaliableportNo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelSlider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Startbutton
            // 
            this.Startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Startbutton.Location = new System.Drawing.Point(6, 136);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(218, 68);
            this.Startbutton.TabIndex = 0;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(176, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set time";
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(6, 217);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(271, 141);
            this.tbMessages.TabIndex = 6;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(785, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Segment
            // 
            this.Segment.Location = new System.Drawing.Point(989, 78);
            this.Segment.Name = "Segment";
            this.Segment.Size = new System.Drawing.Size(75, 23);
            this.Segment.TabIndex = 13;
            this.Segment.Text = "Segment";
            this.Segment.UseVisualStyleBackColor = true;
            this.Segment.Click += new System.EventHandler(this.Segment_Click);
            // 
            // Level
            // 
            this.Level.Location = new System.Drawing.Point(1138, 77);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(75, 23);
            this.Level.TabIndex = 14;
            this.Level.Text = "Level";
            this.Level.UseVisualStyleBackColor = true;
            this.Level.Click += new System.EventHandler(this.Level_Click);
            // 
            // Runlight
            // 
            this.Runlight.Location = new System.Drawing.Point(1379, 78);
            this.Runlight.Name = "Runlight";
            this.Runlight.Size = new System.Drawing.Size(75, 23);
            this.Runlight.TabIndex = 15;
            this.Runlight.Text = "Runlight";
            this.Runlight.UseVisualStyleBackColor = true;
            this.Runlight.Click += new System.EventHandler(this.Runlight_Click);
            // 
            // LevelLimit1
            // 
            this.LevelLimit1.FormattingEnabled = true;
            this.LevelLimit1.Location = new System.Drawing.Point(1138, 122);
            this.LevelLimit1.Name = "LevelLimit1";
            this.LevelLimit1.Size = new System.Drawing.Size(138, 21);
            this.LevelLimit1.TabIndex = 17;
            // 
            // Dominant1
            // 
            this.Dominant1.AutoSize = true;
            this.Dominant1.Location = new System.Drawing.Point(1282, 126);
            this.Dominant1.Name = "Dominant1";
            this.Dominant1.Size = new System.Drawing.Size(77, 17);
            this.Dominant1.TabIndex = 18;
            this.Dominant1.Text = "Dominant1";
            this.Dominant1.UseVisualStyleBackColor = true;
            // 
            // SliderSeg1
            // 
            this.SliderSeg1.LargeChange = 20;
            this.SliderSeg1.Location = new System.Drawing.Point(1138, 149);
            this.SliderSeg1.Maximum = 255;
            this.SliderSeg1.Name = "SliderSeg1";
            this.SliderSeg1.Size = new System.Drawing.Size(221, 45);
            this.SliderSeg1.SmallChange = 20;
            this.SliderSeg1.TabIndex = 19;
            this.SliderSeg1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SliderSeg2
            // 
            this.SliderSeg2.LargeChange = 20;
            this.SliderSeg2.Location = new System.Drawing.Point(1138, 214);
            this.SliderSeg2.Maximum = 255;
            this.SliderSeg2.Name = "SliderSeg2";
            this.SliderSeg2.Size = new System.Drawing.Size(221, 45);
            this.SliderSeg2.SmallChange = 20;
            this.SliderSeg2.TabIndex = 22;
            this.SliderSeg2.Scroll += new System.EventHandler(this.SliderSeg2_Scroll);
            // 
            // Dominant2
            // 
            this.Dominant2.AutoSize = true;
            this.Dominant2.Location = new System.Drawing.Point(1282, 191);
            this.Dominant2.Name = "Dominant2";
            this.Dominant2.Size = new System.Drawing.Size(77, 17);
            this.Dominant2.TabIndex = 21;
            this.Dominant2.Text = "Dominant2";
            this.Dominant2.UseVisualStyleBackColor = true;
            // 
            // LevelLimit2
            // 
            this.LevelLimit2.FormattingEnabled = true;
            this.LevelLimit2.Location = new System.Drawing.Point(1138, 187);
            this.LevelLimit2.Name = "LevelLimit2";
            this.LevelLimit2.Size = new System.Drawing.Size(138, 21);
            this.LevelLimit2.TabIndex = 20;
            // 
            // SliderSeg3
            // 
            this.SliderSeg3.LargeChange = 20;
            this.SliderSeg3.Location = new System.Drawing.Point(1138, 292);
            this.SliderSeg3.Maximum = 255;
            this.SliderSeg3.Name = "SliderSeg3";
            this.SliderSeg3.Size = new System.Drawing.Size(221, 45);
            this.SliderSeg3.SmallChange = 20;
            this.SliderSeg3.TabIndex = 25;
            this.SliderSeg3.Scroll += new System.EventHandler(this.SliderSeg3_Scroll);
            // 
            // Dominant3
            // 
            this.Dominant3.AutoSize = true;
            this.Dominant3.Location = new System.Drawing.Point(1282, 269);
            this.Dominant3.Name = "Dominant3";
            this.Dominant3.Size = new System.Drawing.Size(77, 17);
            this.Dominant3.TabIndex = 24;
            this.Dominant3.Text = "Dominant3";
            this.Dominant3.UseVisualStyleBackColor = true;
            // 
            // LevelLimit3
            // 
            this.LevelLimit3.FormattingEnabled = true;
            this.LevelLimit3.Location = new System.Drawing.Point(1138, 265);
            this.LevelLimit3.Name = "LevelLimit3";
            this.LevelLimit3.Size = new System.Drawing.Size(138, 21);
            this.LevelLimit3.TabIndex = 23;
            // 
            // SliderSeg4
            // 
            this.SliderSeg4.LargeChange = 20;
            this.SliderSeg4.Location = new System.Drawing.Point(1138, 370);
            this.SliderSeg4.Maximum = 255;
            this.SliderSeg4.Name = "SliderSeg4";
            this.SliderSeg4.Size = new System.Drawing.Size(221, 45);
            this.SliderSeg4.SmallChange = 20;
            this.SliderSeg4.TabIndex = 28;
            this.SliderSeg4.Scroll += new System.EventHandler(this.SliderSeg4_Scroll);
            // 
            // Dominant4
            // 
            this.Dominant4.AutoSize = true;
            this.Dominant4.Location = new System.Drawing.Point(1282, 347);
            this.Dominant4.Name = "Dominant4";
            this.Dominant4.Size = new System.Drawing.Size(77, 17);
            this.Dominant4.TabIndex = 27;
            this.Dominant4.Text = "Dominant4";
            this.Dominant4.UseVisualStyleBackColor = true;
            // 
            // LevelLimit4
            // 
            this.LevelLimit4.FormattingEnabled = true;
            this.LevelLimit4.Location = new System.Drawing.Point(1138, 343);
            this.LevelLimit4.Name = "LevelLimit4";
            this.LevelLimit4.Size = new System.Drawing.Size(138, 21);
            this.LevelLimit4.TabIndex = 26;
            // 
            // SliderSeg5
            // 
            this.SliderSeg5.LargeChange = 20;
            this.SliderSeg5.Location = new System.Drawing.Point(1138, 448);
            this.SliderSeg5.Maximum = 255;
            this.SliderSeg5.Name = "SliderSeg5";
            this.SliderSeg5.Size = new System.Drawing.Size(221, 45);
            this.SliderSeg5.SmallChange = 20;
            this.SliderSeg5.TabIndex = 31;
            this.SliderSeg5.Scroll += new System.EventHandler(this.SliderSeg5_Scroll);
            // 
            // Dominant5
            // 
            this.Dominant5.AutoSize = true;
            this.Dominant5.Location = new System.Drawing.Point(1282, 425);
            this.Dominant5.Name = "Dominant5";
            this.Dominant5.Size = new System.Drawing.Size(77, 17);
            this.Dominant5.TabIndex = 30;
            this.Dominant5.Text = "Dominant5";
            this.Dominant5.UseVisualStyleBackColor = true;
            // 
            // LevelLimit5
            // 
            this.LevelLimit5.FormattingEnabled = true;
            this.LevelLimit5.Location = new System.Drawing.Point(1138, 421);
            this.LevelLimit5.Name = "LevelLimit5";
            this.LevelLimit5.Size = new System.Drawing.Size(138, 21);
            this.LevelLimit5.TabIndex = 29;
            // 
            // BackgroundColor
            // 
            this.BackgroundColor.FormattingEnabled = true;
            this.BackgroundColor.Location = new System.Drawing.Point(1369, 174);
            this.BackgroundColor.Name = "BackgroundColor";
            this.BackgroundColor.Size = new System.Drawing.Size(138, 21);
            this.BackgroundColor.TabIndex = 32;
            // 
            // RunlightColor
            // 
            this.RunlightColor.FormattingEnabled = true;
            this.RunlightColor.Location = new System.Drawing.Point(1369, 239);
            this.RunlightColor.Name = "RunlightColor";
            this.RunlightColor.Size = new System.Drawing.Size(138, 21);
            this.RunlightColor.TabIndex = 33;
            // 
            // SegmentsNO
            // 
            this.SegmentsNO.FormattingEnabled = true;
            this.SegmentsNO.Location = new System.Drawing.Point(1369, 317);
            this.SegmentsNO.Name = "SegmentsNO";
            this.SegmentsNO.Size = new System.Drawing.Size(138, 21);
            this.SegmentsNO.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1366, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Backlight color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1366, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Runlight color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1366, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Segments number";
            // 
            // LevelSlider
            // 
            this.LevelSlider.LargeChange = 20;
            this.LevelSlider.Location = new System.Drawing.Point(1087, 77);
            this.LevelSlider.Maximum = 255;
            this.LevelSlider.Name = "LevelSlider";
            this.LevelSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LevelSlider.Size = new System.Drawing.Size(45, 409);
            this.LevelSlider.SmallChange = 20;
            this.LevelSlider.TabIndex = 40;
            this.LevelSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LevelSlider.Scroll += new System.EventHandler(this.trackBar6_Scroll);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Stopbutton.Location = new System.Drawing.Point(230, 135);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(218, 68);
            this.Stopbutton.TabIndex = 42;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // TimeValue_countdown
            // 
            this.TimeValue_countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeValue_countdown.Location = new System.Drawing.Point(6, 62);
            this.TimeValue_countdown.Name = "TimeValue_countdown";
            this.TimeValue_countdown.Size = new System.Drawing.Size(442, 68);
            this.TimeValue_countdown.TabIndex = 43;
            this.TimeValue_countdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeValue_countdown.Visible = false;
            // 
            // TimeValue
            // 
            this.TimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeValue.Location = new System.Drawing.Point(6, 63);
            this.TimeValue.Mask = "00:00:00";
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(442, 68);
            this.TimeValue.TabIndex = 44;
            this.TimeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avaliablemasters
            // 
            this.avaliablemasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avaliablemasters.FormattingEnabled = true;
            this.avaliablemasters.Location = new System.Drawing.Point(32, 63);
            this.avaliablemasters.Name = "avaliablemasters";
            this.avaliablemasters.Size = new System.Drawing.Size(232, 39);
            this.avaliablemasters.TabIndex = 46;
            this.avaliablemasters.SelectedIndexChanged += new System.EventHandler(this.avaliablemasters_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.avaliableportNo);
            this.groupBox1.Controls.Add(this.avaliablemasters);
            this.groupBox1.Controls.Add(this.tbMessages);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 374);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master configuration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(26, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "Choose IOLINK Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(26, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 31);
            this.label5.TabIndex = 48;
            this.label5.Text = "Choose BNI master";
            // 
            // avaliableportNo
            // 
            this.avaliableportNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.avaliableportNo.FormattingEnabled = true;
            this.avaliableportNo.Items.AddRange(new object[] {
            "Port 0",
            "Port 1",
            "Port 2",
            "Port 3",
            "Port 4",
            "Port 5",
            "Port 6",
            "Port 7"});
            this.avaliableportNo.Location = new System.Drawing.Point(32, 156);
            this.avaliableportNo.Name = "avaliableportNo";
            this.avaliableportNo.Size = new System.Drawing.Size(232, 39);
            this.avaliableportNo.TabIndex = 47;
            this.avaliableportNo.SelectedIndexChanged += new System.EventHandler(this.portNo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TimeValue);
            this.groupBox2.Controls.Add(this.TimeValue_countdown);
            this.groupBox2.Controls.Add(this.Stopbutton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Startbutton);
            this.groupBox2.Location = new System.Drawing.Point(315, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 372);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Timer";
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LevelSlider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SegmentsNO);
            this.Controls.Add(this.RunlightColor);
            this.Controls.Add(this.BackgroundColor);
            this.Controls.Add(this.SliderSeg5);
            this.Controls.Add(this.Dominant5);
            this.Controls.Add(this.LevelLimit5);
            this.Controls.Add(this.SliderSeg4);
            this.Controls.Add(this.Dominant4);
            this.Controls.Add(this.LevelLimit4);
            this.Controls.Add(this.SliderSeg3);
            this.Controls.Add(this.Dominant3);
            this.Controls.Add(this.LevelLimit3);
            this.Controls.Add(this.SliderSeg2);
            this.Controls.Add(this.Dominant2);
            this.Controls.Add(this.LevelLimit2);
            this.Controls.Add(this.SliderSeg1);
            this.Controls.Add(this.Dominant1);
            this.Controls.Add(this.LevelLimit1);
            this.Controls.Add(this.Runlight);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.Segment);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Time counter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderSeg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelSlider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Segment;
        private System.Windows.Forms.Button Level;
        private System.Windows.Forms.Button Runlight;
        private System.Windows.Forms.ComboBox LevelLimit1;
        private System.Windows.Forms.CheckBox Dominant1;
        private System.Windows.Forms.TrackBar SliderSeg1;
        private System.Windows.Forms.TrackBar SliderSeg2;
        private System.Windows.Forms.CheckBox Dominant2;
        private System.Windows.Forms.ComboBox LevelLimit2;
        private System.Windows.Forms.TrackBar SliderSeg3;
        private System.Windows.Forms.CheckBox Dominant3;
        private System.Windows.Forms.ComboBox LevelLimit3;
        private System.Windows.Forms.TrackBar SliderSeg4;
        private System.Windows.Forms.CheckBox Dominant4;
        private System.Windows.Forms.ComboBox LevelLimit4;
        private System.Windows.Forms.TrackBar SliderSeg5;
        private System.Windows.Forms.CheckBox Dominant5;
        private System.Windows.Forms.ComboBox LevelLimit5;
        private System.Windows.Forms.ComboBox BackgroundColor;
        private System.Windows.Forms.ComboBox RunlightColor;
        private System.Windows.Forms.ComboBox SegmentsNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar LevelSlider;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.TextBox TimeValue_countdown;
        private System.Windows.Forms.MaskedTextBox TimeValue;
        private System.Windows.Forms.ComboBox avaliablemasters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox avaliableportNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer3;
    }
}

