/*=============================================================================
  Copyright (C) 2012 Allied Vision Technologies.  All Rights Reserved.

  Redistribution of this file, in original or modified form, without
  prior written consent of Allied Vision Technologies is prohibited.

-------------------------------------------------------------------------------

  File:        MainForm.cs

  Description: Forms class for the GUI of the AsynchronousGrab example of
               VimbaNET.

-------------------------------------------------------------------------------

  THIS SOFTWARE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR IMPLIED
  WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF TITLE,
  NON-INFRINGEMENT, MERCHANTABILITY AND FITNESS FOR A PARTICULAR  PURPOSE ARE
  DISCLAIMED.  IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT,
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
  LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED
  AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR
  TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
  OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

=============================================================================*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;
using AVT.VmbAPINET;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Mako_Camera;
using System.Threading;
using System.Linq;

namespace AsynchronousGrab
{

    /// <summary>
    /// The MainForm (GUI) Class implementation
    /// </summary>
    public partial class MainForm : Form
    {
        private static int p1;
        private static int p2;
        private static int minR;
        private static int maxR;
        private static string LEN_NAME;

        private static double centerX = -1;
        private static double centerY = -1;

        private static double centerX0 = -1;
        private static double centerY0 = -1;

        private static double centerX1 = -1;
        private static double centerY1 = -1;

        private static int global_shiftX = 0;
        private static int global_shiftY = 0;

        private static int global_crossX = 640;
        private static int global_crossY = 512;

        private static double global_scaleX = 1;
        private static double global_scaleY = 1;

        private static bool isPainting = true;

        /// <summary>
        /// The VimbaHelper (see VimbaHelper Class)
        /// </summary>
        private VimbaHelper m_VimbaHelper = null;

        /// <summary>
        /// Flag to indicate if the camera is acquiring images
        /// </summary>
        private bool m_Acquiring = false;

        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add log message to logging list box
        /// </summary>
        /// <param name="message">The message</param>
        private void LogMessage(string message)
        {
            if (null == message)
            {
                throw new ArgumentNullException("message");

            }

            int index = m_LogList.Items.Add(string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}: {1}", DateTime.Now, message));
            m_LogList.TopIndex = index;

        }


        /// <summary>
        /// Add an error log message and show an error message box
        /// </summary>
        /// <param name="message">The message</param>
        private void LogError(string message)
        {
            LogMessage(message);

            MessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Update the camera List in the UI
        /// </summary>
        /// 

        private void ScaleImage(Bitmap src)
        {
            global_scaleX = Convert.ToDouble(src.Width)/m_PictureBox.Width; //理論上要>1
            global_scaleY = Convert.ToDouble(src.Height) / m_PictureBox.Height;
            //PB上的座標->實際照片(1280X1024)，要乘Scale
            //實際照片(1280X1024)->PB上的座標，要除上Scale
        }

        private static Mat previous_process(Mat src)
        {
            Mat dst = new Mat();
            OpenCvSharp.Size size = new OpenCvSharp.Size(src.Width, src.Height);
            Mat se = Cv2.GetStructuringElement(MorphShapes.Rect, size, new OpenCvSharp.Point(-1, -1));
            //膨胀
            Cv2.Dilate(src, dst, se, new OpenCvSharp.Point(-1, -1), 1);

            //腐蚀
            //  Cv2.Erode(dst, dst, se, new OpenCvSharp.Point(-1, -1), 1);



            return dst;
        }
        private static Mat MoveCircle(Mat src, string dir, int step)
        {
            Mat dst = new Mat();
            src.CopyTo(dst);

            return dst;
        }

        private static Mat DrawCross(Mat src)
        {
            Mat dst = new Mat();
            src.CopyTo(dst);
            //畫橫線global_crossX global_crossY
            Cv2.Line(dst,0, global_crossY, src.Width, global_crossY, new Scalar(255,255,255),1,LineTypes.AntiAlias);
            //畫直線global_crossX global_crossY
            Cv2.Line(dst, global_crossX, 0, global_crossX, src.Height, new Scalar(255, 255, 255), 1, LineTypes.AntiAlias);
            //畫中心
            Cv2.Rectangle(dst, new OpenCvSharp.Point(global_crossX-3, global_crossY-3), new OpenCvSharp.Point(global_crossX+3, global_crossY+3), new Scalar(0, 0, 0), -1, LineTypes.AntiAlias);
            //畫中心外框
            Cv2.Rectangle(dst, new OpenCvSharp.Point(global_crossX - 4, global_crossY - 4), new OpenCvSharp.Point(global_crossX + 4, global_crossY + 4),  new Scalar(255, 255, 255), 2, LineTypes.AntiAlias);
            //  Allied_Vision_Mako_U_130BCamera.ExposureTime
            //  Allied_Vision_Mako_U_130BCamera = new Allied_Vision_Mako_U_130BCamera();

            return dst;
        }


        private static Mat HoughCircles(Mat src, int shiftX, int shiftY) // shiftX為偏移距離
        {
            Mat dst = new Mat();


            //1:因为霍夫圆检测对噪声比较敏感，所以首先对图像做一个中值滤波或高斯滤波(噪声如果没有可以不做)
            Mat m1 = new Mat();
            Cv2.MedianBlur(src, m1, 11); //  ksize必须大于1且是奇数
           // m1 = DrawCross(m1);
            //2：转为灰度图像
            Mat m2 = new Mat(m1.Height, m1.Width, MatType.CV_8UC1);//CV_8UC1//CV_32SC1


            // Cv2.CvtColor(m1, m2, ColorConversionCodes.BGR2GRAY);

            //3：霍夫圆检测：使用霍夫变换查找灰度图像中的圆。
            /*
             * 参数：_
             * 
             *      1：输入参数： 8位、单通道、灰度输入图像
             *      2：实现方法：目前，唯一的实现方法是HoughCirclesMethod.Gradient
             *      3: dp      :累加器分辨率与图像分辨率的反比。默认=1
             *      4：minDist: 检测到的圆的中心之间的最小距离。(最短距离-可以分辨是两个圆的，否则认为是同心圆-                            src_gray.rows/8)
             *      5:param1:   第一个方法特定的参数。[默认值是100] canny边缘检测阈值低
             *      6:param2:   第二个方法特定于参数。[默认值是100] 中心点累加器阈值 – 候选圆心
             *      7:minRadius: 最小半径
             *      8:maxRadius: 最大半径
             * 
             */
            CircleSegment[] cs = Cv2.HoughCircles(m1, HoughMethods.Gradient, 1, 80, p1, p2, minR, maxR);//72
            //100,30,20,150

            src.CopyTo(dst);

            // Vec3d vec = new Vec3d();
            int Rang = 55;

            int i = 0;

            if(isPainting)
            for (i = 0; i < cs.Length; i++)
            {
                if (i > 6) break;
                //画圆
                Cv2.Circle(dst, (int)cs[i].Center.X + shiftX, (int)cs[i].Center.Y + shiftY, (int)cs[i].Radius, new Scalar(0, 0, 255), 2, LineTypes.AntiAlias);
                //加强圆心显示
                Cv2.Circle(dst, (int)cs[i].Center.X + shiftX, (int)cs[i].Center.Y + shiftY, 3, new Scalar(0, 0, 255), 2, LineTypes.AntiAlias);
                //寫字在旁邊
                Cv2.PutText(dst, LEN_NAME != "" ? LEN_NAME : "Name", new OpenCvSharp.Point(((((int)cs[i].Center.X + shiftX + (int)cs[i].Radius + 100) < src.Width) ? ((int)cs[i].Center.X + shiftX + (int)cs[i].Radius + 10) : ((int)cs[i].Center.X + shiftX - (int)cs[i].Radius - 20)), (int)cs[i].Center.Y + shiftY),
                       HersheyFonts.HersheyComplex, 2, new Scalar(255, 255, 255), 2, LineTypes.AntiAlias);
                Cv2.PutText(dst, (2 * cs[i].Radius).ToString() + " pixels", new OpenCvSharp.Point(((((int)cs[i].Center.X + shiftX + (int)cs[i].Radius + 100) < src.Width) ? ((int)cs[i].Center.X + shiftX + (int)cs[i].Radius + 10) : ((int)cs[i].Center.X + shiftX - (int)cs[i].Radius - 20)), (int)cs[i].Center.Y + shiftY + Rang),
                    HersheyFonts.HersheyComplex, 2, new Scalar(255, 255, 255), 2, LineTypes.AntiAlias);
                Cv2.PutText(dst, cs[i].Radius * 0.0096 + " mm", new OpenCvSharp.Point(((((int)cs[i].Center.X + shiftX + (int)cs[i].Radius + 100) < src.Width) ? ((int)cs[i].Center.X + shiftX + (int)cs[i].Radius + 10) : ((int)cs[i].Center.X + shiftX - (int)cs[i].Radius - 20)), (int)cs[i].Center.Y + shiftY + Rang * 2),
                    HersheyFonts.HersheyComplex, 2, new Scalar(255, 255, 255), 2, LineTypes.AntiAlias);
                //Cv2.PutText(dst, cs[i].Radius.ToString(), new OpenCvSharp.Point(0,0), HersheyFonts.HersheyPlain, 12, new Scalar(255, 255, 255), 5, LineTypes.AntiAlias);
            }
            //   (  (((int) cs[i].Center.X+ (int) cs[i].Radius+100)  < src.Width)?      ((int) cs[i].Center.X + (int) cs[i].Radius + 10) :            ((int) cs[i].Center.X - (int) cs[i].Radius - 20))

            // ((<src.Width)? (((int) cs[i].Center.X + (int) cs[i].Radius + 10) < src.Width))): (int) cs[i].Center.X - (int) cs[i].Radius - 20))
            /*    using (new OpenCvSharp.Window("OutputImage", WindowMode.AutoSize, dst))
                using (new OpenCvSharp.Window("InputImage", WindowMode.AutoSize, src))
                 
                    Cv2.WaitKey(0);
                }*/
            if (cs.Length == 1)
            {
                centerX = Math.Floor(cs[0].Center.X + shiftX);
                centerY = Math.Floor(cs[0].Center.Y + shiftY);
            }

            foreach (var rad in cs)
            {
                Console.Write(rad.Radius + ',');
            }
            Console.WriteLine("There are " + i + " in this frame");
            
            return dst;

        }

        private void UpdateCameraList()
        {
            // Remember the old selection (if there was any)y
            CameraInfo oldSelectedItem = m_CameraList.SelectedItem as CameraInfo;
            m_CameraList.Items.Clear();

            List<CameraInfo> cameras = m_VimbaHelper.CameraList;

            CameraInfo newSelectedItem = null;
            foreach (CameraInfo cameraInfo in cameras)
            {
                m_CameraList.Items.Add(cameraInfo);

                if (null == newSelectedItem)
                {
                    // At least select the first camera
                    newSelectedItem = cameraInfo;
                }
                else if (null != oldSelectedItem)
                {
                    // If the previous selected camera is still available
                    // then prefer this camera.
                    if (string.Compare(newSelectedItem.ID, cameraInfo.ID, StringComparison.Ordinal) == 0)
                    {
                        newSelectedItem = cameraInfo;
                    }
                }
            }

            // If available select a camera and adjust the status of the "Start acquisition" button
            if (null != newSelectedItem)
            {
                m_CameraList.SelectedItem = newSelectedItem;
                m_AcquireButton.Enabled = true;
            }
            else
            {
                m_AcquireButton.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the CameraListChanged event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="args">The EventArgs</param>
        private void OnCameraListChanged(object sender, EventArgs args)
        {
            // Start an asynchronous invoke in case this method was not
            // called by the GUI thread.
            if (InvokeRequired == true)
            {
                BeginInvoke(new CameraListChangedHandler(this.OnCameraListChanged), sender, args);
                return;
            }

            if (null != m_VimbaHelper)
            {
                try
                {
                    UpdateCameraList();

                    LogMessage("Camera list updated.");
                }
                catch (Exception exception)
                {
                    LogError("Could not update camera list. Reason: " + exception.Message);
                }
            }
        }

        /// <summary>
        /// Handles the FrameReceived event
        /// </summary>
        /// <param name="sender">The Sender</param>
        /// <param name="args">The FrameEventArgs</param>
        private void OnFrameReceived(object sender, FrameEventArgs args)
        {
            // Start an async invoke in case this method was not
            // called by the GUI thread.
            if (InvokeRequired == true)
            {
                BeginInvoke(new FrameReceivedHandler(this.OnFrameReceived), sender, args);
                return;
            }

            if (true == m_Acquiring)
            {
                // Display image
                Bitmap bmp = (Bitmap)args.Image;
                Mat mat0 = new Mat();
                mat0 = BitmapConverter.ToMat(bmp);



                // Mat mat = new Mat(image);
                //=  image.Mat;

                if (null != mat0)
                {
                    //mat = HoughCircles(mat);
                //    Mat mat1 = new Mat();
                    
                //    mat1 = previous_process(mat0);

                  //  pb_sub.Image = BitmapConverter.ToBitmap(mat1);
                    //  Mat2Bitmap(mat);
                    BMP_BUFF = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                    m_PictureBox.Image = BMP_BUFF; //<====影像
                    ScaleImage(BMP_BUFF);
                    Thread.Sleep(50);


                }
                else
                {
                    //LogMessage("An acquisition error occurred. Reason: " + args.Exception.Message);

                    try
                    {
                        try
                        {
                            // Start asynchronous image acquisition (grab) in selected camera
                            m_VimbaHelper.StopContinuousImageAcquisition();
                        }
                        finally
                        {
                            m_Acquiring = false;
                            UpdateControls();
                            m_CameraList.Enabled = true;
                        }

                        LogMessage("Asynchronous image acquisition stopped.");
                    }
                    catch (Exception exception)
                    {
                        LogError("Error while stopping asynchronous image acquisition. Reason: " + exception.Message);
                    }
                }
            }
        }
        public static Bitmap Mat2Bitmap(Mat dst)

        {
            return new Bitmap(dst.Cols, dst.Rows, (int)dst.Step(), PixelFormat.Format24bppRgb, dst.Data);

        }

        public Mat Bitmap2Mat(Bitmap bitmap)
        {
            MemoryStream s2_ms = null;
            Mat source = null;
            try
            {
                using (s2_ms = new MemoryStream())
                {
                    bitmap.Save(s2_ms, ImageFormat.Bmp);
                    source = Mat.FromStream(s2_ms, ImreadModes.AnyColor);
                }
            }
            catch (Exception e)
            {
                //  log.Error(e.ToString());
            }
            finally
            {
                if (s2_ms != null)
                {
                    s2_ms.Close();
                    s2_ms = null;
                }
                GC.Collect();
            }
            return source;
        }

        /// <summary>
        /// Handles the Form_Load event of this (MainForm)
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //自動載入PARAMETER
            List<string> Para_memory = new List<string>();
            Para_memory = File.ReadAllLines(@"param\" + "memory.txt").ToList();

            tb_crossX.Text = Para_memory[0];
            tb_crossY.Text = Para_memory[1];

            //  Mat mat0 = new Mat();
            p1 = trackBar1.Value;
            p2 = trackBar2.Value;
            minR = trackBar3.Value;
            maxR = trackBar4.Value;
            LEN_NAME = tb_lens.Text;
            try
            {
                // Start up Vimba SDK
                VimbaHelper vimbaHelper = new VimbaHelper();
                vimbaHelper.Startup(this.OnCameraListChanged);
                m_VimbaHelper = vimbaHelper;

                Text = String.Format("{0} (Vimba .NET API Version {1})", Text, m_VimbaHelper.GetVersion());
                try
                {
                    UpdateCameraList();
                    UpdateControls();
                }
                catch (Exception exception)
                {
                    LogError("Could not update camera list. Reason: " + exception.Message);
                }
            }
            catch (Exception exception)
            {
                LogError("Could not startup Vimba API. Reason: " + exception.Message);
            }
        }

        /// <summary>
        /// Handles the FormClosing event of the MainForm
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != m_VimbaHelper)
            {
                try
                {
                    try
                    {
                        // Shutdown Vimba SDK when application exits
                        m_VimbaHelper.Shutdown();
                    }
                    finally
                    {
                        m_VimbaHelper = null;
                    }
                }
                catch (Exception exception)
                {
                    LogError("Could not shutdown Vimba API. Reason: " + exception.Message);
                }
            }
        }

        /// <summary>
        /// Updates the state of the Acquisition and Trigger controls
        /// </summary>
        private void UpdateControls()
        {
            if (true == m_Acquiring)
            {
                m_AcquireButton.Text = "Stop image acquisition";
                m_AcquireButton.Enabled = true;
            }
            else
            {
                m_AcquireButton.Text = "Start image acquisition";

                CameraInfo cameraInfo = m_CameraList.SelectedItem as CameraInfo;
                if (null != cameraInfo)
                {
                    // Enable button if a camera is selected
                    m_AcquireButton.Enabled = true;
                }
                else
                {
                    // Disable button if no camera is selected
                    m_AcquireButton.Enabled = false;
                }
            }

            if (m_VimbaHelper.IsTriggerAvailable)
            {
                if (false == m_Acquiring)
                {
                    m_SoftwareTriggerCheckbox.Enabled = m_AcquireButton.Enabled;
                    m_SoftwareTriggerButton.Enabled = false;
                }
                else
                {
                    m_SoftwareTriggerCheckbox.Enabled = false;
                    m_SoftwareTriggerButton.Enabled = m_SoftwareTriggerCheckbox.Checked;
                }
            }
            else
            {
                m_SoftwareTriggerCheckbox.Checked = false;
                m_SoftwareTriggerCheckbox.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the click event of the m_AcquireButton
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void AcquireButton_Click(object sender, EventArgs e)
        {
            if (false == m_Acquiring)
            {
                try
                {
                    // Determine selected camera
                    CameraInfo selectedItem = m_CameraList.SelectedItem as CameraInfo;
                    if (null == selectedItem)
                    {
                        throw new NullReferenceException("No camera selected.");
                    }

                    // Open the camera if it was not opened before
                    m_VimbaHelper.OpenCamera(selectedItem.ID);

                    // Start asynchronous image acquisition (grab) in selected camera
                    m_VimbaHelper.StartContinuousImageAcquisition(this.OnFrameReceived);

                    m_Acquiring = true;
                    UpdateControls();

                    // Disable the camera list to inhibit changing the camera
                    m_CameraList.Enabled = false;

                    LogMessage("Asynchronous image acquisition started.");
                }
                catch (Exception exception)
                {
                    LogError("Could not start asynchronous image acquisition. Reason: " + exception.Message);
                }
            }
            else
            {
                try
                {
                    try
                    {
                        // Start asynchronous image acquisition (grab) in selected camera
                        m_VimbaHelper.StopContinuousImageAcquisition();
                    }
                    finally
                    {
                        m_Acquiring = false;
                        UpdateControls();
                    }

                    LogMessage("Asynchronous image acquisition stopped.");
                }
                catch (Exception exception)
                {
                    LogError("Error while stopping asynchronous image acquisition. Reason: " + exception.Message);
                }

                // Re-enable the camera list
                m_CameraList.Enabled = true;
            }
        }

        /// <summary>
        /// Toggle mode between zoomed and 1:1 image display
        /// </summary>
        private void ToogleDisplayMode()
        {
            if (PictureBoxSizeMode.Zoom == m_PictureBox.SizeMode)
            {
                m_PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                m_PictureBox.Dock = DockStyle.None;
            }
            else
            {
                m_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                m_PictureBox.Dock = DockStyle.Fill;
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of the m_PictureBox
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            ToogleDisplayMode();
        }

        /// <summary>
        /// Handles the DoubleClick event of the m_DisplayPanel
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void DisplayPanel_DoubleClick(object sender, EventArgs e)
        {
            ToogleDisplayMode();
        }

        /// <summary>
        /// Handles the Paint event of the m_PictureBox
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            VimbaHelper.ImageInUse = true;

            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            // Draw a line in the PictureBox.
            g.DrawLine(System.Drawing.Pens.Red, 0, Convert.ToInt32(Math.Round(global_crossY/global_scaleY)), Convert.ToInt32(m_PictureBox.Width), Convert.ToInt32(Math.Round(global_crossY / global_scaleY)));
            g.DrawLine(System.Drawing.Pens.Red, Convert.ToInt32(Math.Round(global_crossX / global_scaleX)), 0, Convert.ToInt32(Math.Round(global_crossX / global_scaleX)), Convert.ToInt32(m_PictureBox.Height ));

             //  Allied_Vision_Mako_U_130BCamera.ExposureTime
            // Draw a string on the PictureBox.
            // g.DrawString("This is a diagonal line drawn on the control",  fnt, System.Drawing.Brushes.Blue, new System.Drawing.Point(30, 30));

        }

        /// <summary>
        /// Handles the CheckedChanged event of the m_SoftwareTriggerCheckbox
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void SoftwareTriggerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (m_VimbaHelper.IsTriggerAvailable)
            {
                m_VimbaHelper.EnableSoftwareTrigger(m_SoftwareTriggerCheckbox.Checked);
            }
            UpdateControls();
        }

        /// <summary>
        /// Handles the Click event of the  m_SoftwareTriggerButton
        /// </summary>
        /// <param name="sender">The Sender (not used)</param>
        /// <param name="e">The EventArgs (not used)</param>
        private void SoftwareTriggerButton_Click(object sender, EventArgs e)
        {
            m_VimbaHelper.TriggerSoftwareTrigger();
        }

        /// <summary>
        /// Handles the selection of an entry in the camera list. Open the camera to find
        /// out about the presence of software trigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_CameraList_Click(object sender, EventArgs e)
        {
            // Close the camera if it was opened
            m_VimbaHelper.CloseCamera();

            // Determine selected camera
            CameraInfo selectedItem = m_CameraList.SelectedItem as CameraInfo;
            if (null == selectedItem)
            {
                throw new NullReferenceException("No camera selected.");
            }

            // Open selected camera
            m_VimbaHelper.OpenCamera(selectedItem.ID);

            UpdateControls();

            // In case that the check box is still checked, enable the software trigger
            if (m_VimbaHelper.IsTriggerAvailable)
            {
                m_VimbaHelper.EnableSoftwareTrigger(m_SoftwareTriggerCheckbox.Checked);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = LEN_NAME;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(m_PictureBox.Width);
                int height = Convert.ToInt32(m_PictureBox.Height);
                Bitmap bmp = new Bitmap(width, height);
                m_PictureBox.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                bmp.Save(dialog.FileName + ".bmp", ImageFormat.Bmp);
            }
        }
        Bitmap BMP_BUFF;
        private void btn_Load_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                char sp1 = '\\';
                char sp2 = '.';
                string name_buff = open.FileName.Split(sp1)[open.FileName.Split(sp1).Length - 1];
                tb_lens.Text = name_buff.Split(sp2)[0];
                LEN_NAME = tb_lens.Text;


                //Mat mat0 ;
                Bitmap bmp = new Bitmap(open.FileName);
                Mat mat0 = BitmapConverter.ToMat(bmp);

                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp;

                BMP_BUFF = bmp;
                ScaleImage(BMP_BUFF);

                // image file path  

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p1 = trackBar1.Value;
            tb_p1.Text = p1.ToString();

            if (m_Acquiring == false)
            {
                Mat mat0 = new Mat();
                Bitmap bmp = new Bitmap(BMP_BUFF);
                mat0 = BitmapConverter.ToMat(BMP_BUFF);
                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp;
                ScaleImage(BMP_BUFF);
            }

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            p2 = trackBar2.Value;
            tb_p2.Text = p2.ToString();

            if (m_Acquiring == false)
            {
                Mat mat0 = new Mat();
                Bitmap bmp = new Bitmap(BMP_BUFF);
                mat0 = BitmapConverter.ToMat(BMP_BUFF);
                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp;
               
                ScaleImage(BMP_BUFF);
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            minR = trackBar3.Value;
            tb_minR.Text = minR.ToString();

            if (m_Acquiring == false)
            {
                Mat mat0 = new Mat();
                Bitmap bmp = new Bitmap(BMP_BUFF);
                mat0 = BitmapConverter.ToMat(BMP_BUFF);
                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp;
              
                ScaleImage(BMP_BUFF);
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            maxR = trackBar4.Value;
            tb_maxR.Text = maxR.ToString();

            if (m_Acquiring == false)
            {
                Mat mat0 = new Mat();
                Bitmap bmp = new Bitmap(BMP_BUFF);
                mat0 = BitmapConverter.ToMat(BMP_BUFF);
                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp;
               
                ScaleImage(BMP_BUFF);
            }
        }

        private void tb_lens_TextChanged(object sender, EventArgs e)
        {
            LEN_NAME = tb_lens.Text;
        }

        private void tb_lens_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            tb_lens.Text = "";
        }

        private void btn_center1_Click(object sender, EventArgs e)
        {
            centerX0 = centerX;
            centerY0 = centerY;
            lb_center0.Text = "(" + centerX.ToString() + ", " + centerY.ToString() + ")";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            centerX1 = centerX;
            centerY1 = centerY;
            lb_center1.Text = "(" + centerX.ToString() + ", " + centerY.ToString() + ")";
            //===總和
            double distant = Math.Sqrt(Math.Pow(Math.Abs(centerX1 - centerX0), 2) + Math.Pow(Math.Abs(centerY1 - centerY0), 2));
            rtb_result.Text = "X軸偏移: " + Math.Abs(centerX1 - centerX0) + "\nY軸偏移: " + Math.Abs(centerY1 - centerY0) + "\n距離: " + distant;

        }

        private void btn_stamp_Click(object sender, EventArgs e)
        {
           //===先關掉標記=================
            isPainting = false;

            if (m_Acquiring == false)
            {
                Mat mat01 = new Mat();
                Bitmap bmp1 = new Bitmap(BMP_BUFF);
                mat01 = BitmapConverter.ToMat(BMP_BUFF);
                bmp1 = BitmapConverter.ToBitmap(HoughCircles(mat01, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp1;
                ScaleImage(BMP_BUFF);
            }

            //====================================
            Mat mat0 = new Mat();
            Bitmap bmp =(Bitmap)m_PictureBox.Image;
            mat0 = BitmapConverter.ToMat(bmp);

            // display image in picture box  
            //   m_PictureBox.Image = bmp;

            Mat mat1 = DrawCross(mat0);
            Cv2.PutText(mat1, LEN_NAME != "" ? LEN_NAME : "Name", new OpenCvSharp.Point(30, 80), HersheyFonts.HersheyComplex, 3, new Scalar(255, 255, 255), 2, LineTypes.AntiAlias);
            bmp = BitmapConverter.ToBitmap(mat1);

            //------Save
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = LEN_NAME + "("+centerX +"_"+ centerY + ")_stamped";
       //      string ini_dir= dialog.InitialDirectory;
         //   dialog.InitialDirectory = ini_dir+"\\stamp"; 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(dialog.FileName + ".bmp", ImageFormat.Bmp);
            }


            //=====再打開標記========================

            isPainting = true;

            if (m_Acquiring == false)
            {
                Mat mat01 = new Mat();
                Bitmap bmp1 = new Bitmap(BMP_BUFF);
                mat01 = BitmapConverter.ToMat(BMP_BUFF);
                bmp1 = BitmapConverter.ToBitmap(HoughCircles(mat01, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp1;
                ScaleImage(BMP_BUFF);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            /*string defaultPath = "";
            FolderBrowserDialog open = new FolderBrowserDialog();
            open.Description = "please select a folder";
            open.ShowNewFolderButton = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                defaultPath = open.SelectedPath;
            }
            DirectoryInfo d = new DirectoryInfo(open.SelectedPath);
            FileSystemInfo[] fsinfos = d.GetFileSystemInfos();
            foreach(FileSystemInfo fsinfo in fsinfos)
            {
                if (fsinfo is DirectoryInfo)
                    continue;
                else
                {

                }
            }
            
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                char sp1 = '\\';
                char sp2 = '.';
                string name_buff = open.FileName.Split(sp1)[open.FileName.Split(sp1).Length - 1];
                tb_lens.Text = name_buff.Split(sp2)[0];
                LEN_NAME = tb_lens.Text;
                

                Mat mat0 = new Mat();
                Bitmap bmp = new Bitmap(open.FileName);
                mat0 = BitmapConverter.ToMat(bmp);

                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0));
                // display image in picture box  
                m_PictureBox.Image = bmp;
                BMP_BUFF = bmp;

                // image file path  

            }*/
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            int step = 5;
            switch (e.KeyChar)
            {
                case (char)Key.Up:
                    global_shiftY = global_shiftY - step;
                    break;
                case (char)Key.Down:
                    global_shiftY = global_shiftY + step;
                    break;
                case (char)Key.Left:
                    global_shiftX = global_shiftX - step;
                    break;
                case (char)Key.Right:
                    global_shiftX = global_shiftX + step;
                    break;
                default:
                    break;
            }


        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            
        }

        private void trackBar5_Scroll_1(object sender, EventArgs e)
        {
            tb_expp.Text =  Math.Pow(10,tb_exp.Value/10000.0).ToString();
            double exp = Convert.ToDouble(tb_expp.Text);
            m_VimbaHelper.ExposureTime = exp;
         
        }
        private void tb_expp_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double exp = Convert.ToDouble(tb_expp.Text);
                m_VimbaHelper.ExposureTime = exp;
                tb_exp.Value = Convert.ToInt32(Math.Log10(Convert.ToDouble(tb_expp.Text)) * 10000.0);//tb_exp.Value

            }

        }
            private void cb_cross_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cross.Checked)
            {

            }
            else {

               
            }
            m_PictureBox.Refresh();

        }

        private void btn_modifyCross_Click(object sender, EventArgs e)
        {
            global_crossX=Convert.ToInt32(tb_crossX.Text);
            global_crossY = Convert.ToInt32(tb_crossY.Text);
            m_PictureBox.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //自動載入PARAMETER
            List<string> Para_memory = new List<string>();
            Para_memory = File.ReadAllLines(@"param\" + "memory.txt").ToList();
           
            tb_crossX.Text = Para_memory[0];
            tb_crossY.Text = Para_memory[1];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> para_memory = new List<string>();
            para_memory.Add(tb_crossX.Text+"\n"+ tb_crossY.Text);
            File.WriteAllLines(@"param\" + "memory.txt", para_memory);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             isPainting= checkBox1.Checked;

            if (m_Acquiring == false)
            {
                Mat mat0 = new Mat();
                Bitmap bmp = new Bitmap(BMP_BUFF);
                mat0 = BitmapConverter.ToMat(BMP_BUFF);
                bmp = BitmapConverter.ToBitmap(HoughCircles(mat0, global_shiftX, global_shiftY));
                // display image in picture box  
                m_PictureBox.Image = bmp;
                ScaleImage(BMP_BUFF);
            }

        }
    }
    }
