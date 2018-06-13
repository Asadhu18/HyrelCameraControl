// Two Cameras Test sample application
// AForge.NET framework
// http://www.aforgenet.com/framework/
//
// Copyright © AForge.NET, 2006-2011
// contacts@aforgenet.com
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;
using System.Reflection;
using System.Threading.Tasks;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;

namespace HyrelCamera
{
    public partial class CameraControl : UserControl
    {
        public delegate bool BooleanDelegate();//calls movehead and moves designate axis to amount locat
        public BooleanDelegate SerialPortIsRunningSLow;

        #region Variables
        // list of video devices
        public VideoCaptureDevice videoSource1;
        FilterInfoCollection videoDevices;
        public bool VideoIsLive = false;
        public bool processForShapes = false;
        //image capture info
        public Bitmap SnappedPictureViewerImage;
        public PictureBox CaptureBox1;
        public string FileNameOfPictureToSave = "";
        public string CaptureDirectory = "";
        public int PictureNumber = 0;
        public bool SnapPicture1 = false;
        public bool SnapPicture2 = false;
        //canny variables
        public bool RgbCanny = false;
        int CannyThreshold1 = 100;
        int CannyThreshold2 = 50;
        int CannyMatrixSize = 3;//should be multiples of 3
        //
        public CustomTools.ScrollableImagePanel CurrentDisplayBox;
        public string elapsedTimer = "0";
        public Font PictureFont = new System.Drawing.Font("Helvetica", 40, FontStyle.Bold);
        public bool FlipVertical = false;
        public bool FlipHorizontal = false;
        #endregion

        public CameraControl()
        {
            InitializeComponent();
            EnumerateCameras();
        }

        public void EnumerateCameras()
        {
            try
            {// enumerate video devices
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    throw new Exception();
                }
                Camera_Selection.Items.Clear();//get rid of the old list
                for (int i = 1, n = videoDevices.Count; i <= n; i++)
                {
                    string cameraName = i + " : " + videoDevices[i - 1].Name;
                    Camera_Selection.Items.Add(cameraName);
                }
                if (Camera_Selection.Items.Count > 0) Camera_Selection.SelectedIndex = 0;
                TsbStartVideo.Enabled = true;
            }
            catch
            {
                TsbStartVideo.Enabled = false;
                Camera_Selection.Items.Add("No cameras found");
                Camera_Selection.SelectedIndex = 0;
                Camera_Selection.Enabled = false;
            }
        }
        // On form closing
        private void CameraControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCameras( );
        }

        void ModifiedOutput(object sender, NewFrameEventArgs eventArgs)
        {
            return;
            Pen blackPen = new Pen(Color.Red, 1);
            Bitmap b = (Bitmap)eventArgs.Frame;

            if (CBApplyCanny.Checked)
            {
                Bitmap video2 = (Bitmap)eventArgs.Frame.Clone();
                Grayscale gray = new Grayscale(0.2125, 0.7154, 0.0721);
                Bitmap video3 = gray.Apply(video2);
                CannyEdgeDetector canny = new CannyEdgeDetector(0, 70);
                canny.ApplyInPlace(video3);
                PBCapture.Image = video3;//assign the pointer back to the clone
                if (CBFindCircles.Checked)
                {
                    //System.Drawing.Image returnImage = null;
                    //returnImage = (System.Drawing.Image)CaptureBox.Image.Clone();
                    // Clipboard.SetImage(replacementImage);
                    Bitmap cannyImage = (Bitmap)PBCapture.Image.Clone();
                    ProcessImage(cannyImage);
                    return;
                }
                //PBCapture.Image

                // Create a blank bitmap with the same dimensions
                //Bitmap tempBitmap = new Bitmap(video3.Width, video3.Height);

                //// From this bitmap, the graphics can be obtained, because it has the right PixelFormat
                //Rectangle TargetBM = new Rectangle(0, 0, video3.Width, video3.Height);

                //using (var graphics = Graphics.FromImage(tempBitmap))
                //    {
                //        graphics.DrawImage(video3, TargetBM, 0, 0, TargetBM.Width, TargetBM.Height, GraphicsUnit.Pixel);
                //        graphics.DrawLine(blackPen, 0, b.Height / 2, b.Width, b.Height / 2);
                //        graphics.DrawLine(blackPen, b.Width / 2, 0, b.Width / 2, b.Height);
                //        //PBCapture.Image = video;
                //        graphics.Dispose();
                //    }
                //PBCapture.Image = tempBitmap;
                GC.Collect();
                return;
            }
            //Bitmap video = (Bitmap)eventArgs.Frame.Clone();
            //Pen blackPen = new Pen(Color.Red, 1);
            //using (var graphics = Graphics.FromImage(video))
            //{
            //    graphics.DrawLine(blackPen, 0, video.Height / 2, video.Width, video.Height / 2);
            //    graphics.DrawLine(blackPen, video.Width / 2, 0, video.Width / 2, video.Height);
            //    PBOutPut.Image = video;
            //    graphics.Dispose();
            //    GC.Collect();
            //}

            using (var graphics = Graphics.FromImage(b))
            {
                graphics.DrawLine(blackPen, 0, b.Height / 2, b.Width, b.Height / 2);
                graphics.DrawLine(blackPen, b.Width / 2, 0, b.Width / 2, b.Height);
                //PBOutPut.Image = video;
                graphics.Dispose();
                GC.Collect();
            }
            //if (processForShapes) processForShapes(b);     
        }
        // Start cameras
        private void StartCameras( )
        {
            //VideoIsLive = true;
            //if (backgroundWorker1.IsBusy != true)
            //{
            //    // Start the asynchronous operation.
            //    backgroundWorker1.RunWorkerAsync();
            //}

            //// create first video source
            videoSource1 = new VideoCaptureDevice(videoDevices[Camera_Selection.SelectedIndex].MonikerString);
            videoSource1.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSourcePlayer1.VideoSource = videoSource1;
            videoSourcePlayer1.Start();
        }

        // Stop cameras
        private void StopCameras( )
        {
            videoSourcePlayer1.SignalToStop( );
            videoSourcePlayer1.WaitForStop( );
        }

        private void TsbStartVideo_Click(object sender, EventArgs e)
        {
            StartCameras();
            TsbStartVideo.Enabled = false;
            TsbStopVideo.Enabled = true;
        }

        private void TsbStopVideo_Click(object sender, EventArgs e)
        {
            StopCameras();
            TsbStartVideo.Enabled = true;
            TsbStopVideo.Enabled = false;
        }

        private void invokeCameraControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource1 == null) return;
            videoSource1.DisplayPropertyPage(this.Parent.Handle);
        }

        private void buttonAnalyzeImage_Click(object sender, EventArgs e)
        {
            if (PBCapture.Image == null) return;

            Bitmap modImage = (Bitmap)PBCapture.Image;
            Font selFont = new Font("TimesNewRoman",25,FontStyle.Bold , GraphicsUnit.Pixel);
            Pen blackPen = new Pen(Brushes.Black, .5F);
            Pen whitePen = new Pen(Brushes.White,.5F);
            hScrollBar1.Maximum = 75;
            hScrollBar1.Minimum = 0;
            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            float startHeight = PBCapture.Height / 2;
            float sizeMultiplier = (float)hScrollBar1.Value;
            Graphics g = Graphics.FromImage(modImage);
            float lengthSinWave = PBCapture.Image.Width / 4;
            for (float i = 0; i < lengthSinWave; i += .1F) {
                y2 = (float)Math.Sin(i);
                g.DrawLine(blackPen, x1 * sizeMultiplier, y1 * sizeMultiplier + startHeight, i * sizeMultiplier , y2 * sizeMultiplier + startHeight);

                x1 = i;
                y1 = y2;
            }
            


            g.DrawString("Greetings World", selFont, Brushes.White, (modImage.Width / 2), (modImage.Height / 2));
            
            PBCapture.Image = modImage;



            return;



            Clipboard.SetImage(PBCapture.Image);
            System.Drawing.Image returnImage = null;
            returnImage = Clipboard.GetImage();
            Bitmap image = new Bitmap(returnImage);
            ProcessImage(image);
            return;
        }

        private void TBFocus_Scroll(object sender, EventArgs e)
        {
            if (videoSource1 == null) return;
            videoSource1.SetCameraProperty(CameraControlProperty.Focus, TBFocus.Value, CameraControlFlags.Manual);
        }


        private void TBExposure_Scroll(object sender, EventArgs e)
        {
            if (videoSource1 == null) return;
            videoSource1.SetCameraProperty(CameraControlProperty.Exposure, TBExposure.Value, CameraControlFlags.Manual);
        }


        private void refreshCameraListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnumerateCameras();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if ((videoSource1 != null) & SnapPicture1)
            {
                if (videoSource1.IsRunning)
                {
                SnapPicture1 = false;
                if(SnappedPictureViewerImage!=null)
                {//Now Dispose of old image we were using before
                    SnappedPictureViewerImage.Dispose();
                    SnappedPictureViewerImage = null;
                }

                SnappedPictureViewerImage = videoSourcePlayer1.GetCurrentVideoFrame();//acquire the image please

                if (SnappedPictureViewerImage != null)
                {
                    if(PBCapture.Image!=null) PBCapture.Image.Dispose();//purge old picture to prevent memory leaks

                    PBCapture.Image =(System.Drawing.Bitmap) (System.Drawing.Image)SnappedPictureViewerImage.Clone();
                        if (Directory.Exists(CaptureDirectory))
                        {
                            System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(CaptureDirectory);
                            System.IO.FileInfo[] mainDirectoryInfo = directoryInfo.GetFiles();
                            int numberOfFilesInMainDirectory = mainDirectoryInfo.Length;
                            string fullFileName = CaptureDirectory + @"\pic" + numberOfFilesInMainDirectory.ToString() + ".png";

                            if (CaptureBox1 != null)
                            {//transfer picture to image box and write the time date info on it.
                                PBCapture.Image = SnappedPictureViewerImage;
                                Graphics g = CaptureBox1.CreateGraphics();
                                
                                g.DrawString(elapsedTimer, PictureFont, Brushes.Red, 40, 40);//mark elapsed time  and layer info
                                g.Dispose();
                            }
                            if (!File.Exists(fullFileName))
                            {//save image if the file does not already exist, do NOT overwrite existing picture file
                                PBCapture.Image.Save(fullFileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            }
                        }
                    }
                }
            }
        }
        public void SetupPictureSnap1()
        {

        }
        public void setUpCameraCaptureFileName()
        {
            if (Directory.Exists(CaptureDirectory))
            {
                System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(CaptureDirectory);
                System.IO.FileInfo[] mainDirectoryInfo = directoryInfo.GetFiles();
                int numberOfFilesInMainDirectory = mainDirectoryInfo.Length;
                //save as a jpeg so we can read it in to cad for edge detection
                //string fullFileName = CaptureDirectory + @"\pic" + numberOfFilesInMainDirectory.ToString() + ".png";
                string fullFileName = CaptureDirectory + @"\pic" + numberOfFilesInMainDirectory.ToString() + ".jpg";
                if (File.Exists(fullFileName))
                {
                    fullFileName += "_.jpg"; //fullFileName += "_.png";
                    if (File.Exists(fullFileName))
                    {
                        fullFileName += "_.jpg"; //fullFileName += "_.png";
                    }
                    if (File.Exists(fullFileName))
                    {
                        fullFileName += "_.jpg";// fullFileName += "_.png";
                    }
                }

                FileNameOfPictureToSave = fullFileName;// CaptureDirectory + @"\pic" + numberOfFilesInMainDirectory.ToString() + ".png";
                if (File.Exists(FileNameOfPictureToSave)) File.Delete(FileNameOfPictureToSave);//get rid of old pics 
            }

        }
        public void SnapPictureOnLayerChange()
        {
            string Capture_Directory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Capture_Directory += @"\HyrelPrinterPictures";
            CaptureDirectory = Capture_Directory;
            if (!Directory.Exists(CaptureDirectory)) Directory.CreateDirectory(CaptureDirectory);
            CaptureDirectory += @"\snap Shots";
            if (!Directory.Exists(CaptureDirectory)) Directory.CreateDirectory(CaptureDirectory);
            SnapPictureOnLayerChange(CaptureDirectory);
        }

        public void SnapPictureOnLayerChange(string DestinationFolder)
        {
            if (!TSButtonSnapLayer.Checked) return;//only take pics when enabled
            if (videoSource1 == null) return;
            if (!videoSource1.IsRunning) return;
            requestSnapPicture(DestinationFolder);
        }
        public void requestSnapPicture()
        {
            string Capture_Directory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Capture_Directory += @"\HyrelPrinterPictures";
            CaptureDirectory = Capture_Directory;
            if (!Directory.Exists(CaptureDirectory)) Directory.CreateDirectory(CaptureDirectory);
            CaptureDirectory += @"\snap Shots";
            if (!Directory.Exists(CaptureDirectory)) Directory.CreateDirectory(CaptureDirectory);
            requestSnapPicture(CaptureDirectory);
        }

        public void requestSnapPicture(string destinationFolder)
        {
            CaptureDirectory = destinationFolder;
            if (!Directory.Exists(CaptureDirectory)) Directory.CreateDirectory(CaptureDirectory);
            CaptureDirectory += @"\snap Shots";
            if (!Directory.Exists(CaptureDirectory)) Directory.CreateDirectory(CaptureDirectory);
            PictureNumber += 1;
            SnapPicture1 = true;
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            requestSnapPicture();
        }

        //RotateNoneFlipNone
        //Rotate180FlipXY
        //Rotate90FlipNone
        //Rotate270FlipXY
        //Rotate180FlipNone
        //RotateNoneFlipXY
        //Rotate270FlipNone
        //Rotate90FlipXY
        //RotateNoneFlipX
        //Rotate180FlipY
        //Rotate90FlipX
        //Rotate270FlipY
        //Rotate180FlipX
        //RotateNoneFlipY

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            int VideoOrientation = 0; // TSComboBoxImageRotation.SelectedIndex;
            int CenterXofPicture = eventArgs.Frame.Width/2;
            int CenterYofPicture = eventArgs.Frame.Height/2;

            Pen blackRed = new Pen(Color.Red, 3);

            // Draw line to screen.
            using (var graphics = Graphics.FromImage((Bitmap)eventArgs.Frame))
            {
                graphics.DrawLine(blackRed, CenterXofPicture - 200, CenterYofPicture, CenterXofPicture + 200, CenterYofPicture);
                graphics.DrawLine(blackRed, CenterXofPicture, CenterYofPicture - 200, CenterXofPicture, CenterYofPicture + 200);
            }

            //Graphics.FromImage(bmp))

            //Bitmap lastframe = (Bitmap)eventArgs.Frame.Clone();

            switch (VideoOrientation)
            {
                //RotateNoneFlipNone
                case 0: eventArgs.Frame.RotateFlip(RotateFlipType.RotateNoneFlipNone); break;
                //Rotate180FlipXY
                case 1: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipXY); break;
                //Rotate90FlipNone
                case 2: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                //Rotate270FlipXY
                case 3: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate270FlipXY); break;
                //Rotate180FlipNone
                case 4: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                //RotateNoneFlipXY
                case 5: eventArgs.Frame.RotateFlip(RotateFlipType.RotateNoneFlipXY); break;
                //Rotate270FlipNone
                case 6: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                //Rotate90FlipXY
                case 7: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate90FlipXY); break;
                //RotateNoneFlipX
                case 8: eventArgs.Frame.RotateFlip(RotateFlipType.RotateNoneFlipX); break;
                //Rotate180FlipY
                case 9: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipY); break;
                //Rotate90FlipX
                case 10: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate90FlipX); break;
                //Rotate270FlipY
                case 11: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate270FlipY); break;
                //Rotate180FlipX
                case 12: eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipX); break;
                //RotateNoneFlipY
                case 13: eventArgs.Frame.RotateFlip(RotateFlipType.RotateNoneFlipY); break;
//
                default: eventArgs.Frame.RotateFlip(RotateFlipType.RotateNoneFlipNone); break;
            }
            if (SerialPortIsRunningSLow == null) return;
            if (SerialPortIsRunningSLow())
            {
                System.Threading.Thread.Sleep(100);//kill a tenth of a second before continuing with the video
            }
                return; ;//check to see if we need to send some info please

        }

        private void ProcessImage(Bitmap bitmap)
        {
            if(CBApplyCanny.Checked)
            {

                    Bitmap video2 = (Bitmap)bitmap.Clone();
                    Grayscale gray = new Grayscale(0.2125, 0.7154, 0.0721);
                    Bitmap video3 = gray.Apply(video2);
                    CannyEdgeDetector canny = new CannyEdgeDetector(0, 70);
                    canny.ApplyInPlace(video3);
                //PictureViewerEditor.Image = (Bitmap)Image.FromFile(imageFileName);
                PBCanny.Image = (Bitmap)video3.Clone();//assign the pointer back to the clone
                    //if (CBFindCircles.Checked)
                    //{
                    //    //System.Drawing.Image returnImage = null;
                    //    //returnImage = (System.Drawing.Image)CaptureBox.Image.Clone();
                    //    // Clipboard.SetImage(replacementImage);
                    //    Bitmap cannyImage = (Bitmap)PBCapture.Image.Clone();
                    //    ProcessImage(cannyImage);
                    //    return;
                    //}
                    GC.Collect();
                    //return;
            }
            // lock image
            BitmapData bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, bitmap.PixelFormat);

            // step 1 - turn background to black
            ColorFiltering colorFilter = new ColorFiltering();

            colorFilter.Red = new IntRange(0, 64);
            colorFilter.Green = new IntRange(0, 64);
            colorFilter.Blue = new IntRange(0, 64);
            colorFilter.FillOutsideRange = false;

            colorFilter.ApplyInPlace(bitmapData);

            // step 2 - locating objects
            BlobCounter blobCounter = new BlobCounter();

            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 5;
            blobCounter.MinWidth = 5;

            blobCounter.ProcessImage(bitmapData);
            Blob[] blobs = blobCounter.GetObjectsInformation();
            bitmap.UnlockBits(bitmapData);
            PBCanny.Image = (Bitmap)bitmap.Clone();
            // step 3 - check objects' type and highlight
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

            Graphics g = Graphics.FromImage(bitmap);
            Pen yellowPen = new Pen(Color.Yellow, 2); // circles
            Pen redPen = new Pen(Color.Red, 2);       // quadrilateral
            Pen brownPen = new Pen(Color.Brown, 2);   // quadrilateral with known sub-type
            Pen greenPen = new Pen(Color.Green, 2);   // known triangle
            Pen bluePen = new Pen(Color.Blue, 2);     // triangle

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blobs[i]);

                AForge.Point center;
                float radius;

                // is circle ?
                if (shapeChecker.IsCircle(edgePoints, out center, out radius))
                {
                    g.DrawEllipse(yellowPen,
                        (float)(center.X - radius), (float)(center.Y - radius),
                        (float)(radius * 2), (float)(radius * 2));
                }
                else
                {
                    List<IntPoint> corners;

                    // is triangle or quadrilateral
                    if (shapeChecker.IsConvexPolygon(edgePoints, out corners))
                    {
                        // get sub-type
                        PolygonSubType subType = shapeChecker.CheckPolygonSubType(corners);

                        Pen pen;

                        if (subType == PolygonSubType.Unknown)
                        {
                            pen = (corners.Count == 4) ? redPen : bluePen;
                        }
                        else
                        {
                            pen = (corners.Count == 4) ? brownPen : greenPen;
                        }

                        g.DrawPolygon(pen, ToPointsArray(corners));
                    }
                }
            }

            yellowPen.Dispose();
            redPen.Dispose();
            greenPen.Dispose();
            bluePen.Dispose();
            brownPen.Dispose();
            g.Dispose();

            // put new image to clipboard
            //Clipboard.SetDataObject(bitmap);
            // and to picture box
            PBAnalysis.Image = bitmap;

            //UpdatePictureBoxPosition();
        }

        // Conver list of AForge.NET's points to array of .NET points
        public System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
        {
            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];

            for (int i = 0, n = points.Count; i < n; i++)
            {
                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
            }

            return array;
        }

        private void copyImageToClipBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentDisplayBox == null) return;
            if (CurrentDisplayBox.Image == null) return;
            Clipboard.SetImage(CurrentDisplayBox.Image);
        }

        private void pasteImageFromClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetImage() == null) return;
            CurrentDisplayBox.Image = (Bitmap)Clipboard.GetImage().Clone();//get a copy of the image and cast it to bitmap.

        }
        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {//copy image to clipboard
            if (CurrentDisplayBox == null) return;
            if (CurrentDisplayBox.Image == null) return;
            Clipboard.SetImage(CurrentDisplayBox.Image);
        }


        private void flipVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //videoSource1.
        }

        private void flilpHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void PBCanny_MouseEnter(object sender, EventArgs e)
        {
            CurrentDisplayBox = PBCanny;
        }

        private void PBAnalysis_MouseEnter(object sender, EventArgs e)
        {
            CurrentDisplayBox = PBAnalysis;
        }

        private void PBCapture_MouseEnter(object sender, EventArgs e)
        {
            CurrentDisplayBox = PBCapture;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }






        //public void PerformShapeDetection(Mat frame)//Image<Bgr, Byte> img)
        //{
        //    //if (fileNameTextBox.Text != String.Empty)
        //    //{
        //    StringBuilder msgBuilder = new StringBuilder("Performance: ");

        //    //Load the image from file and resize it for display
        //    //Image<Bgr, Byte> img =
        //    //   new Image<Bgr, byte>(fileNameTextBox.Text)
        //    //   .Resize(400, 400, Emgu.CV.CvEnum.Inter.Linear, true);

        //    //Convert the image to grayscale and filter out the noise
        //    //Mat frame;
        //    //Mat grayFrame = new Mat();
        //    //CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
        //    //Mat smallGrayFrame = new Mat();
        //    //CvInvoke.PyrDown(grayFrame, smallGrayFrame);


        //    UMat uimage = new UMat();
        //    CvInvoke.CvtColor(frame, uimage, ColorConversion.Bgr2Gray);
        //    //CvInvoke.CvtColor(img, uimage,ColorConversion.Bgr2Gray);

        //    //use image pyr to remove noise
        //    UMat pyrDown = new UMat();
        //    CvInvoke.PyrDown(uimage, pyrDown);
        //    CvInvoke.PyrUp(pyrDown, uimage);

        //    //Image<Gray, Byte> gray = img.Convert<Gray, Byte>().PyrDown().PyrUp();

        //    #region circle detection
        //    // Stopwatch watch = Stopwatch.StartNew();
        //    double cannyThreshold = 180.0;
        //    double circleAccumulatorThreshold = 120;
        //    CircleF[] circles = CvInvoke.HoughCircles(uimage, HoughType.Gradient, 2.0, 20.0, cannyThreshold, circleAccumulatorThreshold, 5);

        //    //watch.Stop();
        //    //msgBuilder.Append(String.Format("Hough circles - {0} ms; ", watch.ElapsedMilliseconds));
        //    #endregion

        //    #region Canny and edge detection
        //    //watch.Reset(); watch.Start();
        //    double cannyThresholdLinking = 120.0;
        //    UMat cannyEdges = new UMat();
        //    CvInvoke.Canny(uimage, cannyEdges, cannyThreshold, cannyThresholdLinking);

        //    LineSegment2D[] lines = CvInvoke.HoughLinesP(
        //       cannyEdges,
        //       1, //Distance resolution in pixel-related units
        //       Math.PI / 45.0, //Angle resolution measured in radians.
        //       20, //threshold
        //       30, //min Line width
        //       10); //gap between lines

        //    //watch.Stop();
        //    //msgBuilder.Append(String.Format("Canny & Hough lines - {0} ms; ", watch.ElapsedMilliseconds));
        //    #endregion

        //    #region Find triangles and rectangles
        //    //watch.Reset(); watch.Start();
        //    List<Triangle2DF> triangleList = new List<Triangle2DF>();
        //    List<RotatedRect> boxList = new List<RotatedRect>(); //a box is a rotated rectangle

        //    using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
        //    {
        //        CvInvoke.FindContours(cannyEdges, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
        //        int count = contours.Size;
        //        for (int i = 0; i < count; i++)
        //        {
        //            using (VectorOfPoint contour = contours[i])
        //            using (VectorOfPoint approxContour = new VectorOfPoint())
        //            {
        //                CvInvoke.ApproxPolyDP(contour, approxContour, CvInvoke.ArcLength(contour, true) * 0.05, true);
        //                if (CvInvoke.ContourArea(approxContour, false) > 250) //only consider contours with area greater than 250
        //                {
        //                    if (approxContour.Size == 3) //The contour has 3 vertices, it is a triangle
        //                    {
        //                        Point[] pts = approxContour.ToArray();
        //                        triangleList.Add(new Triangle2DF(
        //                           pts[0],
        //                           pts[1],
        //                           pts[2]
        //                           ));
        //                    }
        //                    else if (approxContour.Size == 4) //The contour has 4 vertices.
        //                    {
        //                        #region determine if all the angles in the contour are within [80, 100] degree
        //                        bool isRectangle = true;
        //                        Point[] pts = approxContour.ToArray();
        //                        LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

        //                        for (int j = 0; j < edges.Length; j++)
        //                        {
        //                            double angle = Math.Abs(
        //                               edges[(j + 1) % edges.Length].GetExteriorAngleDegree(edges[j]));
        //                            if (angle < 80 || angle > 100)
        //                            {
        //                                isRectangle = false;
        //                                break;
        //                            }
        //                        }
        //                        #endregion

        //                        if (isRectangle) boxList.Add(CvInvoke.MinAreaRect(approxContour));
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    // watch.Stop();
        //    //msgBuilder.Append(String.Format("Triangles & Rectangles - {0} ms; ", watch.ElapsedMilliseconds));
        //    #endregion
        //    //LargeDisplayBox
        //    //LargeDisplayBox.Image = img;
        //    //this.Text = msgBuilder.ToString();

        //    #region draw triangles and rectangles
        //    //Mat triangleRectangleImage = new Mat(img.Size, DepthType.Cv8U, 3);
        //    //triangleRectangleImage.SetTo(new MCvScalar(0));
        //    //foreach (Triangle2DF triangle in triangleList)
        //    //{
        //    //    CvInvoke.Polylines(triangleRectangleImage, Array.ConvertAll(triangle.GetVertices(), Point.Round), true, new Bgr(Color.DarkBlue).MCvScalar, 2);
        //    //}
        //    if (CBFindRectangles.Checked)
        //    {
        //        foreach (RotatedRect box in boxList)
        //        {
        //            CvInvoke.Polylines(frame, Array.ConvertAll(box.GetVertices(), Point.Round), true, new Bgr(Color.DarkOrange).MCvScalar, 2);
        //        }
        //    }

        //    // triangleRectangleImageBox.Image = triangleRectangleImage;
        //    #endregion

        //    #region draw circles
        //    //Mat circleImage = new Mat(img.Size, DepthType.Cv8U, 3);
        //    //circleImage.SetTo(new MCvScalar(0));
        //    if (CBFindCircles.Checked)
        //    {
        //        foreach (CircleF circle in circles)
        //            CvInvoke.Circle(frame, Point.Round(circle.Center), (int)circle.Radius, new Bgr(Color.Red).MCvScalar, 2);
        //    }
        //    // circleImageBox.Image = circleImage;
        //    #endregion

        //    #region draw lines
        //    //Mat lineImage = new Mat(img.Size, DepthType.Cv8U, 3);
        //    //lineImage.SetTo(new MCvScalar(0));
        //    if (CBFindLines.Checked)
        //    {
        //        foreach (LineSegment2D line in lines)
        //        {
        //            //CvInvoke.Line(img, CrossHairX1, CrossHairX2, new MCvScalar(255, 0, 0), 1, Emgu.CV.CvEnum.LineType.EightConnected);
        //            CvInvoke.Line(frame, line.P1, line.P2, new Bgr(Color.Fuchsia).MCvScalar, 2);
        //        }
        //        //lineImageBox.Image = lineImage;
        //    }
        //    //LargeDisplayBox.Image = frame;

        //    #endregion
        //    //AnalysisOutputBox.Image = (Image) frame.Bitmap.Clone();
        //    GC.Collect();
        //    //}
        //}


    }
}
