namespace HelloEmgu
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
            this.yellowHMax = new System.Windows.Forms.TrackBar();
            this.yellowHMin = new System.Windows.Forms.TrackBar();
            this.yellowSMax = new System.Windows.Forms.TrackBar();
            this.yellowSMin = new System.Windows.Forms.TrackBar();
            this.yellowVMax = new System.Windows.Forms.TrackBar();
            this.yellowVMin = new System.Windows.Forms.TrackBar();
            this.redHMin = new System.Windows.Forms.TrackBar();
            this.redHMax = new System.Windows.Forms.TrackBar();
            this.redSMin = new System.Windows.Forms.TrackBar();
            this.redSMax = new System.Windows.Forms.TrackBar();
            this.redVMin = new System.Windows.Forms.TrackBar();
            this.redVMax = new System.Windows.Forms.TrackBar();
            this.rawPictureBox = new System.Windows.Forms.PictureBox();
            this.yellowVBox = new System.Windows.Forms.PictureBox();
            this.yellowHBox = new System.Windows.Forms.PictureBox();
            this.yellowSBox = new System.Windows.Forms.PictureBox();
            this.redMergeBox = new System.Windows.Forms.PictureBox();
            this.yellowMergeBox = new System.Windows.Forms.PictureBox();
            this.redVBox = new System.Windows.Forms.PictureBox();
            this.redSBox = new System.Windows.Forms.PictureBox();
            this.redHBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yHMinText = new System.Windows.Forms.Label();
            this.yHMaxText = new System.Windows.Forms.Label();
            this.ySMinText = new System.Windows.Forms.Label();
            this.ySMaxText = new System.Windows.Forms.Label();
            this.yVMinText = new System.Windows.Forms.Label();
            this.yVMaxText = new System.Windows.Forms.Label();
            this.rHMinText = new System.Windows.Forms.Label();
            this.rHMaxText = new System.Windows.Forms.Label();
            this.rSMinText = new System.Windows.Forms.Label();
            this.rSMaxText = new System.Windows.Forms.Label();
            this.rVMinText = new System.Windows.Forms.Label();
            this.rVMaxText = new System.Windows.Forms.Label();
            this.yellowSlice1Text = new System.Windows.Forms.Label();
            this.yellowSlice3Text = new System.Windows.Forms.Label();
            this.yellowSlice4Text = new System.Windows.Forms.Label();
            this.yellowSlice2Text = new System.Windows.Forms.Label();
            this.yellowSlice5Text = new System.Windows.Forms.Label();
            this.yellowSlice6Text = new System.Windows.Forms.Label();
            this.yellowSlice7Text = new System.Windows.Forms.Label();
            this.redSlice1Text = new System.Windows.Forms.Label();
            this.redSlice2Text = new System.Windows.Forms.Label();
            this.redSlice3Text = new System.Windows.Forms.Label();
            this.motorBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.yellowHMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowHMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowSMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowSMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redHMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redHMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowHBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowSBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redMergeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowMergeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redHBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yellowHMax
            // 
            this.yellowHMax.Location = new System.Drawing.Point(484, 421);
            this.yellowHMax.Maximum = 255;
            this.yellowHMax.Minimum = 1;
            this.yellowHMax.Name = "yellowHMax";
            this.yellowHMax.Size = new System.Drawing.Size(466, 56);
            this.yellowHMax.TabIndex = 8;
            this.yellowHMax.Value = 50;
            this.yellowHMax.Scroll += new System.EventHandler(this.hMaxScroll_Scroll);
            // 
            // yellowHMin
            // 
            this.yellowHMin.Location = new System.Drawing.Point(484, 359);
            this.yellowHMin.Maximum = 255;
            this.yellowHMin.Minimum = 1;
            this.yellowHMin.Name = "yellowHMin";
            this.yellowHMin.Size = new System.Drawing.Size(466, 56);
            this.yellowHMin.TabIndex = 9;
            this.yellowHMin.Value = 20;
            this.yellowHMin.Scroll += new System.EventHandler(this.hMinScroll_Scroll);
            // 
            // yellowSMax
            // 
            this.yellowSMax.Location = new System.Drawing.Point(956, 421);
            this.yellowSMax.Maximum = 255;
            this.yellowSMax.Minimum = 1;
            this.yellowSMax.Name = "yellowSMax";
            this.yellowSMax.Size = new System.Drawing.Size(466, 56);
            this.yellowSMax.TabIndex = 10;
            this.yellowSMax.Value = 170;
            this.yellowSMax.Scroll += new System.EventHandler(this.sMaxScroll_Scroll);
            // 
            // yellowSMin
            // 
            this.yellowSMin.Location = new System.Drawing.Point(956, 359);
            this.yellowSMin.Maximum = 255;
            this.yellowSMin.Minimum = 1;
            this.yellowSMin.Name = "yellowSMin";
            this.yellowSMin.Size = new System.Drawing.Size(466, 56);
            this.yellowSMin.TabIndex = 11;
            this.yellowSMin.Value = 35;
            this.yellowSMin.Scroll += new System.EventHandler(this.sMinScroll_Scroll);
            // 
            // yellowVMax
            // 
            this.yellowVMax.Location = new System.Drawing.Point(1428, 421);
            this.yellowVMax.Maximum = 255;
            this.yellowVMax.Minimum = 1;
            this.yellowVMax.Name = "yellowVMax";
            this.yellowVMax.Size = new System.Drawing.Size(466, 56);
            this.yellowVMax.TabIndex = 12;
            this.yellowVMax.Value = 255;
            this.yellowVMax.Scroll += new System.EventHandler(this.vMaxScroll_Scroll);
            // 
            // yellowVMin
            // 
            this.yellowVMin.Location = new System.Drawing.Point(1428, 359);
            this.yellowVMin.Maximum = 255;
            this.yellowVMin.Minimum = 1;
            this.yellowVMin.Name = "yellowVMin";
            this.yellowVMin.Size = new System.Drawing.Size(466, 56);
            this.yellowVMin.TabIndex = 13;
            this.yellowVMin.Value = 130;
            this.yellowVMin.Scroll += new System.EventHandler(this.vMinScroll_Scroll);
            // 
            // redHMin
            // 
            this.redHMin.Location = new System.Drawing.Point(484, 830);
            this.redHMin.Maximum = 255;
            this.redHMin.Minimum = 1;
            this.redHMin.Name = "redHMin";
            this.redHMin.Size = new System.Drawing.Size(466, 56);
            this.redHMin.TabIndex = 22;
            this.redHMin.Value = 1;
            this.redHMin.Scroll += new System.EventHandler(this.redHMin_Scroll);
            // 
            // redHMax
            // 
            this.redHMax.Location = new System.Drawing.Point(484, 892);
            this.redHMax.Maximum = 255;
            this.redHMax.Minimum = 1;
            this.redHMax.Name = "redHMax";
            this.redHMax.Size = new System.Drawing.Size(466, 56);
            this.redHMax.TabIndex = 21;
            this.redHMax.Value = 15;
            this.redHMax.Scroll += new System.EventHandler(this.redHMax_Scroll);
            // 
            // redSMin
            // 
            this.redSMin.Location = new System.Drawing.Point(956, 830);
            this.redSMin.Maximum = 255;
            this.redSMin.Minimum = 1;
            this.redSMin.Name = "redSMin";
            this.redSMin.Size = new System.Drawing.Size(466, 56);
            this.redSMin.TabIndex = 24;
            this.redSMin.Value = 60;
            this.redSMin.Scroll += new System.EventHandler(this.redSMin_Scroll);
            // 
            // redSMax
            // 
            this.redSMax.Location = new System.Drawing.Point(956, 892);
            this.redSMax.Maximum = 255;
            this.redSMax.Minimum = 1;
            this.redSMax.Name = "redSMax";
            this.redSMax.Size = new System.Drawing.Size(466, 56);
            this.redSMax.TabIndex = 23;
            this.redSMax.Value = 170;
            this.redSMax.Scroll += new System.EventHandler(this.redSMax_Scroll);
            // 
            // redVMin
            // 
            this.redVMin.Location = new System.Drawing.Point(1430, 830);
            this.redVMin.Maximum = 255;
            this.redVMin.Minimum = 1;
            this.redVMin.Name = "redVMin";
            this.redVMin.Size = new System.Drawing.Size(465, 56);
            this.redVMin.TabIndex = 26;
            this.redVMin.Value = 110;
            this.redVMin.Scroll += new System.EventHandler(this.redVMin_Scroll);
            // 
            // redVMax
            // 
            this.redVMax.Location = new System.Drawing.Point(1428, 892);
            this.redVMax.Maximum = 255;
            this.redVMax.Minimum = 1;
            this.redVMax.Name = "redVMax";
            this.redVMax.Size = new System.Drawing.Size(465, 56);
            this.redVMax.TabIndex = 25;
            this.redVMax.Value = 160;
            this.redVMax.Scroll += new System.EventHandler(this.redVMax_Scroll);
            // 
            // rawPictureBox
            // 
            this.rawPictureBox.Location = new System.Drawing.Point(12, 12);
            this.rawPictureBox.Name = "rawPictureBox";
            this.rawPictureBox.Size = new System.Drawing.Size(466, 341);
            this.rawPictureBox.TabIndex = 31;
            this.rawPictureBox.TabStop = false;
            // 
            // yellowVBox
            // 
            this.yellowVBox.Location = new System.Drawing.Point(1428, 12);
            this.yellowVBox.Name = "yellowVBox";
            this.yellowVBox.Size = new System.Drawing.Size(466, 341);
            this.yellowVBox.TabIndex = 32;
            this.yellowVBox.TabStop = false;
            // 
            // yellowHBox
            // 
            this.yellowHBox.Location = new System.Drawing.Point(484, 12);
            this.yellowHBox.Name = "yellowHBox";
            this.yellowHBox.Size = new System.Drawing.Size(466, 341);
            this.yellowHBox.TabIndex = 33;
            this.yellowHBox.TabStop = false;
            // 
            // yellowSBox
            // 
            this.yellowSBox.Location = new System.Drawing.Point(956, 12);
            this.yellowSBox.Name = "yellowSBox";
            this.yellowSBox.Size = new System.Drawing.Size(466, 341);
            this.yellowSBox.TabIndex = 34;
            this.yellowSBox.TabStop = false;
            // 
            // redMergeBox
            // 
            this.redMergeBox.Location = new System.Drawing.Point(12, 688);
            this.redMergeBox.Name = "redMergeBox";
            this.redMergeBox.Size = new System.Drawing.Size(466, 341);
            this.redMergeBox.TabIndex = 35;
            this.redMergeBox.TabStop = false;
            // 
            // yellowMergeBox
            // 
            this.yellowMergeBox.Location = new System.Drawing.Point(12, 350);
            this.yellowMergeBox.Name = "yellowMergeBox";
            this.yellowMergeBox.Size = new System.Drawing.Size(466, 341);
            this.yellowMergeBox.TabIndex = 36;
            this.yellowMergeBox.TabStop = false;
            // 
            // redVBox
            // 
            this.redVBox.Location = new System.Drawing.Point(1428, 483);
            this.redVBox.Name = "redVBox";
            this.redVBox.Size = new System.Drawing.Size(466, 341);
            this.redVBox.TabIndex = 37;
            this.redVBox.TabStop = false;
            // 
            // redSBox
            // 
            this.redSBox.Location = new System.Drawing.Point(956, 483);
            this.redSBox.Name = "redSBox";
            this.redSBox.Size = new System.Drawing.Size(466, 341);
            this.redSBox.TabIndex = 38;
            this.redSBox.TabStop = false;
            // 
            // redHBox
            // 
            this.redHBox.Location = new System.Drawing.Point(484, 483);
            this.redHBox.Name = "redHBox";
            this.redHBox.Size = new System.Drawing.Size(466, 341);
            this.redHBox.TabIndex = 39;
            this.redHBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Raw Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Yellow H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Yellow S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1425, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Yellow V";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Yellow Merge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Red H";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(953, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Red S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1425, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Red V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 688);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Red Merge";
            // 
            // yHMinText
            // 
            this.yHMinText.AutoSize = true;
            this.yHMinText.Location = new System.Drawing.Point(682, 398);
            this.yHMinText.Name = "yHMinText";
            this.yHMinText.Size = new System.Drawing.Size(60, 17);
            this.yHMinText.TabIndex = 49;
            this.yHMinText.Text = "Value: 1";
            // 
            // yHMaxText
            // 
            this.yHMaxText.AutoSize = true;
            this.yHMaxText.Location = new System.Drawing.Point(682, 460);
            this.yHMaxText.Name = "yHMaxText";
            this.yHMaxText.Size = new System.Drawing.Size(60, 17);
            this.yHMaxText.TabIndex = 50;
            this.yHMaxText.Text = "Value: 1";
            // 
            // ySMinText
            // 
            this.ySMinText.AutoSize = true;
            this.ySMinText.Location = new System.Drawing.Point(1163, 398);
            this.ySMinText.Name = "ySMinText";
            this.ySMinText.Size = new System.Drawing.Size(60, 17);
            this.ySMinText.TabIndex = 51;
            this.ySMinText.Text = "Value: 1";
            // 
            // ySMaxText
            // 
            this.ySMaxText.AutoSize = true;
            this.ySMaxText.Location = new System.Drawing.Point(1163, 460);
            this.ySMaxText.Name = "ySMaxText";
            this.ySMaxText.Size = new System.Drawing.Size(60, 17);
            this.ySMaxText.TabIndex = 52;
            this.ySMaxText.Text = "Value: 1";
            // 
            // yVMinText
            // 
            this.yVMinText.AutoSize = true;
            this.yVMinText.Location = new System.Drawing.Point(1646, 398);
            this.yVMinText.Name = "yVMinText";
            this.yVMinText.Size = new System.Drawing.Size(60, 17);
            this.yVMinText.TabIndex = 53;
            this.yVMinText.Text = "Value: 1";
            // 
            // yVMaxText
            // 
            this.yVMaxText.AutoSize = true;
            this.yVMaxText.Location = new System.Drawing.Point(1646, 460);
            this.yVMaxText.Name = "yVMaxText";
            this.yVMaxText.Size = new System.Drawing.Size(60, 17);
            this.yVMaxText.TabIndex = 54;
            this.yVMaxText.Text = "Value: 1";
            // 
            // rHMinText
            // 
            this.rHMinText.AutoSize = true;
            this.rHMinText.Location = new System.Drawing.Point(682, 869);
            this.rHMinText.Name = "rHMinText";
            this.rHMinText.Size = new System.Drawing.Size(60, 17);
            this.rHMinText.TabIndex = 55;
            this.rHMinText.Text = "Value: 1";
            // 
            // rHMaxText
            // 
            this.rHMaxText.AutoSize = true;
            this.rHMaxText.Location = new System.Drawing.Point(682, 931);
            this.rHMaxText.Name = "rHMaxText";
            this.rHMaxText.Size = new System.Drawing.Size(60, 17);
            this.rHMaxText.TabIndex = 56;
            this.rHMaxText.Text = "Value: 1";
            // 
            // rSMinText
            // 
            this.rSMinText.AutoSize = true;
            this.rSMinText.Location = new System.Drawing.Point(1163, 869);
            this.rSMinText.Name = "rSMinText";
            this.rSMinText.Size = new System.Drawing.Size(60, 17);
            this.rSMinText.TabIndex = 57;
            this.rSMinText.Text = "Value: 1";
            // 
            // rSMaxText
            // 
            this.rSMaxText.AutoSize = true;
            this.rSMaxText.Location = new System.Drawing.Point(1163, 931);
            this.rSMaxText.Name = "rSMaxText";
            this.rSMaxText.Size = new System.Drawing.Size(60, 17);
            this.rSMaxText.TabIndex = 58;
            this.rSMaxText.Text = "Value: 1";
            // 
            // rVMinText
            // 
            this.rVMinText.AutoSize = true;
            this.rVMinText.Location = new System.Drawing.Point(1646, 869);
            this.rVMinText.Name = "rVMinText";
            this.rVMinText.Size = new System.Drawing.Size(60, 17);
            this.rVMinText.TabIndex = 59;
            this.rVMinText.Text = "Value: 1";
            // 
            // rVMaxText
            // 
            this.rVMaxText.AutoSize = true;
            this.rVMaxText.Location = new System.Drawing.Point(1646, 931);
            this.rVMaxText.Name = "rVMaxText";
            this.rVMaxText.Size = new System.Drawing.Size(60, 17);
            this.rVMaxText.TabIndex = 60;
            this.rVMaxText.Text = "Value: 1";
            // 
            // yellowSlice1Text
            // 
            this.yellowSlice1Text.AutoSize = true;
            this.yellowSlice1Text.Location = new System.Drawing.Point(9, 668);
            this.yellowSlice1Text.Name = "yellowSlice1Text";
            this.yellowSlice1Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice1Text.TabIndex = 61;
            this.yellowSlice1Text.Text = "0";
            // 
            // yellowSlice3Text
            // 
            this.yellowSlice3Text.AutoSize = true;
            this.yellowSlice3Text.Location = new System.Drawing.Point(141, 668);
            this.yellowSlice3Text.Name = "yellowSlice3Text";
            this.yellowSlice3Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice3Text.TabIndex = 62;
            this.yellowSlice3Text.Text = "0";
            // 
            // yellowSlice4Text
            // 
            this.yellowSlice4Text.AutoSize = true;
            this.yellowSlice4Text.Location = new System.Drawing.Point(220, 668);
            this.yellowSlice4Text.Name = "yellowSlice4Text";
            this.yellowSlice4Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice4Text.TabIndex = 63;
            this.yellowSlice4Text.Text = "0";
            // 
            // yellowSlice2Text
            // 
            this.yellowSlice2Text.AutoSize = true;
            this.yellowSlice2Text.Location = new System.Drawing.Point(75, 668);
            this.yellowSlice2Text.Name = "yellowSlice2Text";
            this.yellowSlice2Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice2Text.TabIndex = 64;
            this.yellowSlice2Text.Text = "0";
            // 
            // yellowSlice5Text
            // 
            this.yellowSlice5Text.AutoSize = true;
            this.yellowSlice5Text.Location = new System.Drawing.Point(286, 668);
            this.yellowSlice5Text.Name = "yellowSlice5Text";
            this.yellowSlice5Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice5Text.TabIndex = 65;
            this.yellowSlice5Text.Text = "0";
            // 
            // yellowSlice6Text
            // 
            this.yellowSlice6Text.AutoSize = true;
            this.yellowSlice6Text.Location = new System.Drawing.Point(352, 668);
            this.yellowSlice6Text.Name = "yellowSlice6Text";
            this.yellowSlice6Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice6Text.TabIndex = 66;
            this.yellowSlice6Text.Text = "0";
            // 
            // yellowSlice7Text
            // 
            this.yellowSlice7Text.AutoSize = true;
            this.yellowSlice7Text.Location = new System.Drawing.Point(418, 668);
            this.yellowSlice7Text.Name = "yellowSlice7Text";
            this.yellowSlice7Text.Size = new System.Drawing.Size(16, 17);
            this.yellowSlice7Text.TabIndex = 67;
            this.yellowSlice7Text.Text = "0";
            // 
            // redSlice1Text
            // 
            this.redSlice1Text.AutoSize = true;
            this.redSlice1Text.Location = new System.Drawing.Point(418, 694);
            this.redSlice1Text.Name = "redSlice1Text";
            this.redSlice1Text.Size = new System.Drawing.Size(16, 17);
            this.redSlice1Text.TabIndex = 68;
            this.redSlice1Text.Text = "0";
            // 
            // redSlice2Text
            // 
            this.redSlice2Text.AutoSize = true;
            this.redSlice2Text.Location = new System.Drawing.Point(418, 830);
            this.redSlice2Text.Name = "redSlice2Text";
            this.redSlice2Text.Size = new System.Drawing.Size(16, 17);
            this.redSlice2Text.TabIndex = 69;
            this.redSlice2Text.Text = "0";
            // 
            // redSlice3Text
            // 
            this.redSlice3Text.AutoSize = true;
            this.redSlice3Text.Location = new System.Drawing.Point(418, 957);
            this.redSlice3Text.Name = "redSlice3Text";
            this.redSlice3Text.Size = new System.Drawing.Size(16, 17);
            this.redSlice3Text.TabIndex = 70;
            this.redSlice3Text.Text = "0";
            // 
            // motorBox
            // 
            this.motorBox.AutoSize = true;
            this.motorBox.Location = new System.Drawing.Point(484, 953);
            this.motorBox.Name = "motorBox";
            this.motorBox.Size = new System.Drawing.Size(73, 21);
            this.motorBox.TabIndex = 71;
            this.motorBox.Text = "Motors";
            this.motorBox.UseVisualStyleBackColor = true;
            this.motorBox.CheckedChanged += new System.EventHandler(this.motorBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 1036);
            this.Controls.Add(this.motorBox);
            this.Controls.Add(this.redSlice3Text);
            this.Controls.Add(this.redSlice2Text);
            this.Controls.Add(this.redSlice1Text);
            this.Controls.Add(this.yellowSlice7Text);
            this.Controls.Add(this.yellowSlice6Text);
            this.Controls.Add(this.yellowSlice5Text);
            this.Controls.Add(this.yellowSlice2Text);
            this.Controls.Add(this.yellowSlice4Text);
            this.Controls.Add(this.yellowSlice3Text);
            this.Controls.Add(this.yellowSlice1Text);
            this.Controls.Add(this.rVMaxText);
            this.Controls.Add(this.rVMinText);
            this.Controls.Add(this.rSMaxText);
            this.Controls.Add(this.rSMinText);
            this.Controls.Add(this.rHMaxText);
            this.Controls.Add(this.rHMinText);
            this.Controls.Add(this.yVMaxText);
            this.Controls.Add(this.yVMinText);
            this.Controls.Add(this.ySMaxText);
            this.Controls.Add(this.ySMinText);
            this.Controls.Add(this.yHMaxText);
            this.Controls.Add(this.yHMinText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redHBox);
            this.Controls.Add(this.redSBox);
            this.Controls.Add(this.redVBox);
            this.Controls.Add(this.yellowMergeBox);
            this.Controls.Add(this.redMergeBox);
            this.Controls.Add(this.yellowSBox);
            this.Controls.Add(this.yellowHBox);
            this.Controls.Add(this.yellowVBox);
            this.Controls.Add(this.rawPictureBox);
            this.Controls.Add(this.redVMin);
            this.Controls.Add(this.redVMax);
            this.Controls.Add(this.redSMin);
            this.Controls.Add(this.redSMax);
            this.Controls.Add(this.redHMin);
            this.Controls.Add(this.redHMax);
            this.Controls.Add(this.yellowVMin);
            this.Controls.Add(this.yellowVMax);
            this.Controls.Add(this.yellowSMin);
            this.Controls.Add(this.yellowSMax);
            this.Controls.Add(this.yellowHMin);
            this.Controls.Add(this.yellowHMax);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.yellowHMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowHMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowSMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowSMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redHMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redHMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowHBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowSBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redMergeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowMergeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redHBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar yellowHMax;
        private System.Windows.Forms.TrackBar yellowHMin;
        private System.Windows.Forms.TrackBar yellowSMax;
        private System.Windows.Forms.TrackBar yellowSMin;
        private System.Windows.Forms.TrackBar yellowVMax;
        private System.Windows.Forms.TrackBar yellowVMin;
        private System.Windows.Forms.TrackBar redHMin;
        private System.Windows.Forms.TrackBar redHMax;
        private System.Windows.Forms.TrackBar redSMin;
        private System.Windows.Forms.TrackBar redSMax;
        private System.Windows.Forms.TrackBar redVMin;
        private System.Windows.Forms.TrackBar redVMax;
        private System.Windows.Forms.PictureBox rawPictureBox;
        private System.Windows.Forms.PictureBox yellowVBox;
        private System.Windows.Forms.PictureBox yellowHBox;
        private System.Windows.Forms.PictureBox yellowSBox;
        private System.Windows.Forms.PictureBox redMergeBox;
        private System.Windows.Forms.PictureBox yellowMergeBox;
        private System.Windows.Forms.PictureBox redVBox;
        private System.Windows.Forms.PictureBox redSBox;
        private System.Windows.Forms.PictureBox redHBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label yHMinText;
        private System.Windows.Forms.Label yHMaxText;
        private System.Windows.Forms.Label ySMinText;
        private System.Windows.Forms.Label ySMaxText;
        private System.Windows.Forms.Label yVMinText;
        private System.Windows.Forms.Label yVMaxText;
        private System.Windows.Forms.Label rHMinText;
        private System.Windows.Forms.Label rHMaxText;
        private System.Windows.Forms.Label rSMinText;
        private System.Windows.Forms.Label rSMaxText;
        private System.Windows.Forms.Label rVMinText;
        private System.Windows.Forms.Label rVMaxText;
        private System.Windows.Forms.Label yellowSlice1Text;
        private System.Windows.Forms.Label yellowSlice3Text;
        private System.Windows.Forms.Label yellowSlice4Text;
        private System.Windows.Forms.Label yellowSlice2Text;
        private System.Windows.Forms.Label yellowSlice5Text;
        private System.Windows.Forms.Label yellowSlice6Text;
        private System.Windows.Forms.Label yellowSlice7Text;
        private System.Windows.Forms.Label redSlice1Text;
        private System.Windows.Forms.Label redSlice2Text;
        private System.Windows.Forms.Label redSlice3Text;
        private System.Windows.Forms.CheckBox motorBox;
    }
}

