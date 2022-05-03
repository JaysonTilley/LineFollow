// Jayson Tilley

using Emgu.CV;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV.Structure;

namespace HelloEmgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Set Camera and COM Port
        private void Form1_Load(object sender, EventArgs e)
        {
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();

            lineFollow = new Robot("COM10");
        }
        
        Robot lineFollow;

        private VideoCapture _capture;
        private Thread _captureThread;
        private int _threshold = 150;
        private int ySlideHMin = 20, ySlideSMin = 35, ySlideVMin = 130, ySlideHMax = 50, ySlideSMax = 170, ySlideVMax = 255,
            rSlideHMin = 1, rSlideSMin = 60, rSlideVMin = 110, rSlideHMax = 15, rSlideSMax = 170, rSlideVMax = 160;
        private bool motors = false;
        
        // Yellow Scroll Bars + Value Bars
        private void hMinScroll_Scroll(object sender, EventArgs e)
        {
            ySlideHMin = yellowHMin.Value;
            yHMinText.Text = "Value: " + ySlideHMin;
        }
        private void hMaxScroll_Scroll(object sender, EventArgs e)
        {
            ySlideHMax = yellowHMax.Value;
            yHMaxText.Text = "Value: " + ySlideHMax;
        }
        private void sMinScroll_Scroll(object sender, EventArgs e)
        {
            ySlideSMin = yellowSMin.Value;
            ySMinText.Text = "Value: " + ySlideSMin;
        }
        private void sMaxScroll_Scroll(object sender, EventArgs e)
        {
            ySlideSMax = yellowSMax.Value;
            ySMaxText.Text = "Value: " + ySlideSMax;
        }
        private void vMinScroll_Scroll(object sender, EventArgs e)
        {
            ySlideVMin = yellowVMin.Value;
            yVMinText.Text = "Value: " + ySlideVMin;
        }
        private void vMaxScroll_Scroll(object sender, EventArgs e)
        {
            ySlideVMax = yellowVMax.Value;
            yVMaxText.Text = "Value: " + ySlideVMax;
        }
        
        // Red Scroll Bars + Value Bars
        private void redHMin_Scroll(object sender, EventArgs e)
        {
            rSlideHMin = redHMin.Value;
            rHMinText.Text = "Value: " + rSlideHMin;
        }
        private void redHMax_Scroll(object sender, EventArgs e)
        {
            rSlideHMax = redHMax.Value;
            rHMaxText.Text = "Value: " + rSlideHMax;
        }
        private void redSMin_Scroll(object sender, EventArgs e)
        {
            rSlideSMin = redSMin.Value;
            rSMinText.Text = "Value: " + rSlideSMin;
        }
        private void redSMax_Scroll(object sender, EventArgs e)
        {
            rSlideSMax = redSMax.Value;
            rSMaxText.Text = "Value: " + rSlideSMax;
        }
        private void redVMin_Scroll(object sender, EventArgs e)
        {
            rSlideVMin = redVMin.Value;
            rVMinText.Text = "Value: " + rSlideVMin;
        }
        private void redVMax_Scroll(object sender, EventArgs e)
        {
            rSlideVMax = redVMax.Value;
            rVMaxText.Text = "Value: " + rSlideVMax;
        }

        // Check Box
        private void motorBox_CheckedChanged(object sender, EventArgs e)
        {
            if (motorBox.Checked == true)
                motors = true;
            else motors = false;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (motorBox.Checked == true)
                {
                    motorBox.Checked = false;
                    motors = false;
                }
                else
                {
                    motorBox.Checked = true;
                    motors = true;
                }
            }
        }

        // Webcam
        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                // Frame Resizing
                Mat pictureFrame = _capture.QueryFrame();

                int frameNewHeight = (pictureFrame.Size.Height * rawPictureBox.Size.Width) / pictureFrame.Size.Width;
                Size frameNewSize = new Size(rawPictureBox.Size.Width, frameNewHeight);
                CvInvoke.Resize(pictureFrame, pictureFrame, frameNewSize);

                Invoke(new Action(() => { rawPictureBox.Image = pictureFrame.Bitmap; }));
                
                // Yellow Box Meshing
                Mat yellowGrayFrame = new Mat();
                Mat yellowBinaryFrame = new Mat();
                Mat yellowHSVFrame = new Mat();

                CvInvoke.CvtColor(pictureFrame, yellowGrayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(yellowGrayFrame, yellowBinaryFrame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                CvInvoke.CvtColor(pictureFrame, yellowHSVFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                CvInvoke.CvtColor(pictureFrame, yellowHSVFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                Mat[] yellowHSVChannels = yellowHSVFrame.Split();

                Mat yellowHueFilter = new Mat();
                CvInvoke.InRange(yellowHSVChannels[0], new ScalarArray(ySlideHMin), new ScalarArray(ySlideHMax), yellowHueFilter);
                Invoke(new Action(() => { yellowHBox.Image = yellowHueFilter.Bitmap; }));

                Mat yellowSaturationFilter = new Mat();
                CvInvoke.InRange(yellowHSVChannels[1], new ScalarArray(ySlideSMin), new ScalarArray(ySlideSMax), yellowSaturationFilter);
                Invoke(new Action(() => { yellowSBox.Image = yellowSaturationFilter.Bitmap; }));

                Mat yellowValueFilter = new Mat();
                CvInvoke.InRange(yellowHSVChannels[2], new ScalarArray(ySlideVMin), new ScalarArray(ySlideVMax), yellowValueFilter);
                Invoke(new Action(() => { yellowVBox.Image = yellowValueFilter.Bitmap; }));

                Mat yellowMergedImage = new Mat();
                CvInvoke.BitwiseAnd(yellowHueFilter, yellowSaturationFilter, yellowMergedImage);
                CvInvoke.BitwiseAnd(yellowMergedImage, yellowValueFilter, yellowMergedImage);
                Invoke(new Action(() => { yellowMergeBox.Image = yellowMergedImage.Bitmap; }));
                
                // Red Box Meshing
                Mat redGrayFrame = new Mat();
                Mat redBinaryFrame = new Mat();
                Mat redHSVFrame = new Mat();

                CvInvoke.CvtColor(pictureFrame, redGrayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(redGrayFrame, redBinaryFrame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                CvInvoke.CvtColor(pictureFrame, redHSVFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

                CvInvoke.CvtColor(pictureFrame, redHSVFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
                Mat[] redHSVChannels = redHSVFrame.Split();

                Mat redHueFilter = new Mat();
                CvInvoke.InRange(redHSVChannels[0], new ScalarArray(rSlideHMin), new ScalarArray(rSlideHMax), redHueFilter);
                Invoke(new Action(() => { redHBox.Image = redHueFilter.Bitmap; }));

                Mat redSaturationFilter = new Mat();
                CvInvoke.InRange(redHSVChannels[1], new ScalarArray(rSlideSMin), new ScalarArray(rSlideSMax), redSaturationFilter);
                Invoke(new Action(() => { redSBox.Image = redSaturationFilter.Bitmap; }));

                Mat redValueFilter = new Mat();
                CvInvoke.InRange(redHSVChannels[2], new ScalarArray(rSlideVMin), new ScalarArray(rSlideVMax), redValueFilter);
                Invoke(new Action(() => { redVBox.Image = redValueFilter.Bitmap; }));

                Mat redMergedImage = new Mat();
                CvInvoke.BitwiseAnd(redHueFilter, redSaturationFilter, redMergedImage);
                CvInvoke.BitwiseAnd(redMergedImage, redValueFilter, redMergedImage);
                Invoke(new Action(() => { redMergeBox.Image = redMergedImage.Bitmap; }));
                
                // Yellow Pixel Count
                int yellowSlice1 = 0, yellowSlice2 = 0, yellowSlice3 = 0, yellowSlice4 = 0, yellowSlice5 = 0, yellowSlice6 = 0, yellowSlice7 = 0;
                int sliceWidth = pictureFrame.Width / 7;
                Image<Gray, byte> YGray = yellowMergedImage.ToImage<Gray, byte>();
                for (int y = 0; y < pictureFrame.Height; y++)
                {
                    for (int x = 0; x < sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice1++;
                        }
                    }
                    for (int x = sliceWidth; x < 2 * sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice2++;
                        }
                    }
                    for (int x = 2 * sliceWidth; x < 3 * sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice3++;
                        }
                    }
                    for (int x = 3 * sliceWidth; x < 4 * sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice4++;
                        }
                    }
                    for (int x = 4 * sliceWidth; x < 5 * sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice5++;
                        }
                    }
                    for (int x = 5 * sliceWidth; x < 6 * sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice6++;
                        }
                    }
                    for (int x = 6 * sliceWidth; x < 7 * sliceWidth; x++)
                    {
                        if (YGray.Data[y, x, 0] == 255)
                        {
                            yellowSlice7++;
                        }
                    }
                }
                Invoke(new Action(() => { yellowSlice1Text.Text = $"{yellowSlice1}"; yellowSlice2Text.Text = $"{yellowSlice2}"; yellowSlice3Text.Text = $"{yellowSlice3}";
                    yellowSlice4Text.Text = $"{yellowSlice4}"; yellowSlice5Text.Text = $"{yellowSlice5}"; yellowSlice6Text.Text = $"{yellowSlice6}"; yellowSlice7Text.Text = $"{yellowSlice7}"; }));
                
                // Red Pixel Count
                int redSlice1 = 1, redSlice2 = 1, redSlice3 = 1;
                int sliceHeight = pictureFrame.Height / 3;
                Image<Gray, byte> RGray = redMergedImage.ToImage<Gray, byte>();
                for (int y = 0; y < pictureFrame.Height; y++)
                {
                    for (int x = 0; x < sliceHeight; x++)
                    {
                        if (RGray.Data[x, y, 0] == 255)
                        {
                            redSlice1++;
                        }
                    }
                    for (int x = sliceHeight; x < 2 * sliceHeight; x++)
                    {
                        if (RGray.Data[x, y, 0] == 255)
                        {
                            redSlice2++;
                        }
                    }
                    for (int x = 2 * sliceHeight; x < 3 * sliceHeight; x++)
                    {
                        if (RGray.Data[x, y, 0] == 255)
                        {
                            redSlice3++;
                        }
                    }
                }

                Invoke(new Action(() => {
                    yellowSlice1Text.Text = $"{yellowSlice1}"; yellowSlice2Text.Text = $"{yellowSlice2}"; yellowSlice3Text.Text = $"{yellowSlice3}";
                    yellowSlice4Text.Text = $"{yellowSlice4}"; yellowSlice5Text.Text = $"{yellowSlice5}"; yellowSlice6Text.Text = $"{yellowSlice6}"; yellowSlice7Text.Text = $"{yellowSlice7}"; }));

                Invoke(new Action(() => { redSlice1Text.Text = $"{redSlice1}"; redSlice2Text.Text = $"{redSlice2}"; redSlice3Text.Text = $"{redSlice3}"; }));
                
                // Movement
                int bigYellowSlice = 0;
                
                bigYellowSlice = Math.Max(yellowSlice1, Math.Max(yellowSlice2, Math.Max(yellowSlice3, Math.Max(yellowSlice4, Math.Max(yellowSlice5, Math.Max(yellowSlice6, yellowSlice7))))));
                                
                if (motors == true)
                {
                    if (redSlice2 < 250)
                    {
                        if (bigYellowSlice > 0)
                        {
                            if (yellowSlice1 == bigYellowSlice)
                                lineFollow.Move(Robot.FASTRIGHT);
                            else if (yellowSlice2 == bigYellowSlice)
                                lineFollow.Move(Robot.MEDIUMRIGHT);
                            else if (yellowSlice3 == bigYellowSlice)
                                lineFollow.Move(Robot.SLOWRIGHT);
                            else if (yellowSlice4 == bigYellowSlice)
                                lineFollow.Move(Robot.STRAIGHT);
                            else if (yellowSlice5 == bigYellowSlice)
                                lineFollow.Move(Robot.SLOWLEFT);
                            else if (yellowSlice6 == bigYellowSlice)
                                lineFollow.Move(Robot.MEDIUMLEFT);
                            else if (yellowSlice7 == bigYellowSlice)
                                lineFollow.Move(Robot.FASTLEFT);
                        }
                    }
                    else lineFollow.Move(Robot.STOP);
                }
                else lineFollow.Move(Robot.STOP);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
            lineFollow.Move(Robot.STOP);
        }
    }
}
