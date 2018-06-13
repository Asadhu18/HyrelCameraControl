namespace HyrelCamera
{
    partial class CameraControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

# region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraControl));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbStartVideo = new System.Windows.Forms.ToolStripButton();
            this.Camera_Selection = new System.Windows.Forms.ToolStripComboBox();
            this.TSDDButtonCamerSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.TSComboBoxImageRotation = new System.Windows.Forms.ToolStripComboBox();
            this.readCameraPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invokeCameraControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCameraResolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.x480ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x600ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x768ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x800ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCameraListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TsbStopVideo = new System.Windows.Forms.ToolStripButton();
            this.TSButtonSnapLayer = new System.Windows.Forms.ToolStripButton();
            this.CMImageCopyPaste = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyImageToClipBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteImageFromClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBExposure = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBFocus = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.Focus_LBL = new System.Windows.Forms.Label();
            this.CBApplyCanny = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CBCopyImageToClipboard = new System.Windows.Forms.CheckBox();
            this.CBFindLines = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBFindRectangles = new System.Windows.Forms.CheckBox();
            this.buttonAnalyzeImage = new System.Windows.Forms.Button();
            this.CBFindCircles = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CBTakePictureOnLayerChange = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.PBCanny = new CustomTools.ScrollableImagePanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PBAnalysis = new CustomTools.ScrollableImagePanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PBCapture = new CustomTools.ScrollableImagePanel();
            this.labelthreshold2 = new System.Windows.Forms.Label();
            this.TBCannyThreshold1 = new System.Windows.Forms.TrackBar();
            this.TBCannyThreshold2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.labelthreshold1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.CMImageCopyPaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFocus)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBCannyThreshold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCannyThreshold2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Aqua;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbStartVideo,
            this.Camera_Selection,
            this.TSDDButtonCamerSettings,
            this.toolStripButton1,
            this.TsbStopVideo,
            this.TSButtonSnapLayer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(570, 76);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbStartVideo
            // 
            this.TsbStartVideo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbStartVideo.Image = ((System.Drawing.Image)(resources.GetObject("TsbStartVideo.Image")));
            this.TsbStartVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbStartVideo.Name = "TsbStartVideo";
            this.TsbStartVideo.Size = new System.Drawing.Size(52, 73);
            this.TsbStartVideo.Text = "toolStripButton1";
            this.TsbStartVideo.ToolTipText = "Start / Stop Live Video";
            this.TsbStartVideo.Click += new System.EventHandler(this.TsbStartVideo_Click);
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.AutoSize = false;
            this.Camera_Selection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(320, 33);
            // 
            // TSDDButtonCamerSettings
            // 
            this.TSDDButtonCamerSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSDDButtonCamerSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSDDButtonCamerSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSComboBoxImageRotation,
            this.readCameraPropertiesToolStripMenuItem,
            this.invokeCameraControlToolStripMenuItem,
            this.selectCameraResolutionToolStripMenuItem,
            this.refreshCameraListToolStripMenuItem});
            this.TSDDButtonCamerSettings.Image = ((System.Drawing.Image)(resources.GetObject("TSDDButtonCamerSettings.Image")));
            this.TSDDButtonCamerSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDButtonCamerSettings.Name = "TSDDButtonCamerSettings";
            this.TSDDButtonCamerSettings.Size = new System.Drawing.Size(61, 73);
            this.TSDDButtonCamerSettings.Text = "toolStripDropDownButton1";
            // 
            // TSComboBoxImageRotation
            // 
            this.TSComboBoxImageRotation.BackColor = System.Drawing.Color.Black;
            this.TSComboBoxImageRotation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSComboBoxImageRotation.ForeColor = System.Drawing.Color.Cyan;
            this.TSComboBoxImageRotation.Items.AddRange(new object[] {
            "        RotateNoneFlipNone",
            "        Rotate180FlipXY",
            "        Rotate90FlipNone",
            "        Rotate270FlipXY",
            "        Rotate180FlipNone",
            "        RotateNoneFlipXY",
            "        Rotate270FlipNone",
            "        Rotate90FlipXY",
            "        RotateNoneFlipX",
            "        Rotate180FlipY",
            "        Rotate90FlipX",
            "        Rotate270FlipY",
            "        Rotate180FlipX",
            "        RotateNoneFlipY",
            "        Rotate270FlipX",
            "        Rotate90FlipY"});
            this.TSComboBoxImageRotation.Name = "TSComboBoxImageRotation";
            this.TSComboBoxImageRotation.Size = new System.Drawing.Size(250, 33);
            this.TSComboBoxImageRotation.Text = "NO Image Rotation";
            // 
            // readCameraPropertiesToolStripMenuItem
            // 
            this.readCameraPropertiesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readCameraPropertiesToolStripMenuItem.Image")));
            this.readCameraPropertiesToolStripMenuItem.Name = "readCameraPropertiesToolStripMenuItem";
            this.readCameraPropertiesToolStripMenuItem.Size = new System.Drawing.Size(342, 54);
            this.readCameraPropertiesToolStripMenuItem.Text = "Read Camera Properties";
            // 
            // invokeCameraControlToolStripMenuItem
            // 
            this.invokeCameraControlToolStripMenuItem.Image = global::HyrelCamera.Properties.Resources.Camera;
            this.invokeCameraControlToolStripMenuItem.Name = "invokeCameraControlToolStripMenuItem";
            this.invokeCameraControlToolStripMenuItem.Size = new System.Drawing.Size(342, 54);
            this.invokeCameraControlToolStripMenuItem.Text = "Invoke Camera Control";
            this.invokeCameraControlToolStripMenuItem.Click += new System.EventHandler(this.invokeCameraControlToolStripMenuItem_Click);
            // 
            // selectCameraResolutionToolStripMenuItem
            // 
            this.selectCameraResolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.x480ToolStripMenuItem,
            this.x600ToolStripMenuItem,
            this.x768ToolStripMenuItem,
            this.x800ToolStripMenuItem,
            this.x1200ToolStripMenuItem});
            this.selectCameraResolutionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectCameraResolutionToolStripMenuItem.Image")));
            this.selectCameraResolutionToolStripMenuItem.Name = "selectCameraResolutionToolStripMenuItem";
            this.selectCameraResolutionToolStripMenuItem.Size = new System.Drawing.Size(342, 54);
            this.selectCameraResolutionToolStripMenuItem.Text = "Select Camera Resolution";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(161, 26);
            this.toolStripMenuItem2.Text = "320x240";
            // 
            // x480ToolStripMenuItem
            // 
            this.x480ToolStripMenuItem.Name = "x480ToolStripMenuItem";
            this.x480ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.x480ToolStripMenuItem.Text = "640x480";
            // 
            // x600ToolStripMenuItem
            // 
            this.x600ToolStripMenuItem.Name = "x600ToolStripMenuItem";
            this.x600ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.x600ToolStripMenuItem.Text = "800x600";
            // 
            // x768ToolStripMenuItem
            // 
            this.x768ToolStripMenuItem.Name = "x768ToolStripMenuItem";
            this.x768ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.x768ToolStripMenuItem.Text = "1024x768";
            // 
            // x800ToolStripMenuItem
            // 
            this.x800ToolStripMenuItem.Name = "x800ToolStripMenuItem";
            this.x800ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.x800ToolStripMenuItem.Text = "1280x800";
            // 
            // x1200ToolStripMenuItem
            // 
            this.x1200ToolStripMenuItem.Name = "x1200ToolStripMenuItem";
            this.x1200ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.x1200ToolStripMenuItem.Text = "1600x1200";
            // 
            // refreshCameraListToolStripMenuItem
            // 
            this.refreshCameraListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshCameraListToolStripMenuItem.Image")));
            this.refreshCameraListToolStripMenuItem.Name = "refreshCameraListToolStripMenuItem";
            this.refreshCameraListToolStripMenuItem.Size = new System.Drawing.Size(342, 54);
            this.refreshCameraListToolStripMenuItem.Text = "Refresh Camera List";
            this.refreshCameraListToolStripMenuItem.Click += new System.EventHandler(this.refreshCameraListToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 73);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // TsbStopVideo
            // 
            this.TsbStopVideo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsbStopVideo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbStopVideo.Image = global::HyrelCamera.Properties.Resources.Stop48x48;
            this.TsbStopVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbStopVideo.Name = "TsbStopVideo";
            this.TsbStopVideo.Size = new System.Drawing.Size(52, 73);
            this.TsbStopVideo.Text = "toolStripButton2";
            this.TsbStopVideo.Click += new System.EventHandler(this.TsbStopVideo_Click);
            // 
            // TSButtonSnapLayer
            // 
            this.TSButtonSnapLayer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSButtonSnapLayer.BackColor = System.Drawing.Color.Gray;
            this.TSButtonSnapLayer.CheckOnClick = true;
            this.TSButtonSnapLayer.Image = global::HyrelCamera.Properties.Resources.Camera;
            this.TSButtonSnapLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSButtonSnapLayer.Name = "TSButtonSnapLayer";
            this.TSButtonSnapLayer.Size = new System.Drawing.Size(56, 73);
            this.TSButtonSnapLayer.Text = "M790";
            this.TSButtonSnapLayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TSButtonSnapLayer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TSButtonSnapLayer.ToolTipText = "Snaps Picture on start of each layer when it encounters M790 code";
            this.TSButtonSnapLayer.CheckedChanged += new System.EventHandler(this.flilpHorizontalToolStripMenuItem_Click);
            // 
            // CMImageCopyPaste
            // 
            this.CMImageCopyPaste.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMImageCopyPaste.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.CMImageCopyPaste.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyImageToClipBoardToolStripMenuItem,
            this.pasteImageFromClipboardToolStripMenuItem});
            this.CMImageCopyPaste.Name = "CMImageCopyPaste";
            this.CMImageCopyPaste.Size = new System.Drawing.Size(423, 112);
            // 
            // copyImageToClipBoardToolStripMenuItem
            // 
            this.copyImageToClipBoardToolStripMenuItem.Image = global::HyrelCamera.Properties.Resources.Clipboard;
            this.copyImageToClipBoardToolStripMenuItem.Name = "copyImageToClipBoardToolStripMenuItem";
            this.copyImageToClipBoardToolStripMenuItem.Size = new System.Drawing.Size(422, 54);
            this.copyImageToClipBoardToolStripMenuItem.Text = "Copy Image to ClipBoard";
            this.copyImageToClipBoardToolStripMenuItem.Click += new System.EventHandler(this.copyImageToClipBoardToolStripMenuItem_Click);
            // 
            // pasteImageFromClipboardToolStripMenuItem
            // 
            this.pasteImageFromClipboardToolStripMenuItem.Image = global::HyrelCamera.Properties.Resources.Paste;
            this.pasteImageFromClipboardToolStripMenuItem.Name = "pasteImageFromClipboardToolStripMenuItem";
            this.pasteImageFromClipboardToolStripMenuItem.Size = new System.Drawing.Size(422, 54);
            this.pasteImageFromClipboardToolStripMenuItem.Text = "Paste Image From Clipboard";
            this.pasteImageFromClipboardToolStripMenuItem.Click += new System.EventHandler(this.pasteImageFromClipboardToolStripMenuItem_Click);
            // 
            // TBExposure
            // 
            this.TBExposure.BackColor = System.Drawing.Color.Black;
            this.TBExposure.Location = new System.Drawing.Point(151, 45);
            this.TBExposure.Maximum = 250;
            this.TBExposure.Minimum = -200;
            this.TBExposure.Name = "TBExposure";
            this.TBExposure.Size = new System.Drawing.Size(130, 45);
            this.TBExposure.TabIndex = 24;
            this.TBExposure.TickFrequency = 5;
            this.TBExposure.Scroll += new System.EventHandler(this.TBExposure_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(158, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Exposure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(248, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "0";
            // 
            // TBFocus
            // 
            this.TBFocus.BackColor = System.Drawing.Color.Black;
            this.TBFocus.Location = new System.Drawing.Point(15, 45);
            this.TBFocus.Maximum = 250;
            this.TBFocus.Minimum = -200;
            this.TBFocus.Name = "TBFocus";
            this.TBFocus.Size = new System.Drawing.Size(130, 45);
            this.TBFocus.TabIndex = 21;
            this.TBFocus.TickFrequency = 5;
            this.TBFocus.Scroll += new System.EventHandler(this.TBFocus_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Focus";
            // 
            // Focus_LBL
            // 
            this.Focus_LBL.AutoSize = true;
            this.Focus_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Focus_LBL.ForeColor = System.Drawing.Color.Lime;
            this.Focus_LBL.Location = new System.Drawing.Point(97, 25);
            this.Focus_LBL.Name = "Focus_LBL";
            this.Focus_LBL.Size = new System.Drawing.Size(19, 20);
            this.Focus_LBL.TabIndex = 22;
            this.Focus_LBL.Text = "0";
            // 
            // CBApplyCanny
            // 
            this.CBApplyCanny.AutoSize = true;
            this.CBApplyCanny.BackColor = System.Drawing.Color.Black;
            this.CBApplyCanny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBApplyCanny.ForeColor = System.Drawing.Color.Cyan;
            this.CBApplyCanny.Location = new System.Drawing.Point(271, 57);
            this.CBApplyCanny.Name = "CBApplyCanny";
            this.CBApplyCanny.Size = new System.Drawing.Size(123, 20);
            this.CBApplyCanny.TabIndex = 405;
            this.CBApplyCanny.Text = "Enable Canny\r\n";
            this.CBApplyCanny.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 150);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 150);
            this.panel2.TabIndex = 405;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(570, 150);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.hScrollBar1);
            this.tabPage4.Controls.Add(this.CBCopyImageToClipboard);
            this.tabPage4.Controls.Add(this.CBApplyCanny);
            this.tabPage4.Controls.Add(this.CBFindLines);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.CBFindRectangles);
            this.tabPage4.Controls.Add(this.buttonAnalyzeImage);
            this.tabPage4.Controls.Add(this.CBFindCircles);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(562, 117);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Control";
            // 
            // CBCopyImageToClipboard
            // 
            this.CBCopyImageToClipboard.AutoSize = true;
            this.CBCopyImageToClipboard.BackColor = System.Drawing.Color.Black;
            this.CBCopyImageToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBCopyImageToClipboard.ForeColor = System.Drawing.Color.Cyan;
            this.CBCopyImageToClipboard.Location = new System.Drawing.Point(271, 76);
            this.CBCopyImageToClipboard.Name = "CBCopyImageToClipboard";
            this.CBCopyImageToClipboard.Size = new System.Drawing.Size(152, 20);
            this.CBCopyImageToClipboard.TabIndex = 406;
            this.CBCopyImageToClipboard.Text = "Copy to Clipbaord";
            this.CBCopyImageToClipboard.UseVisualStyleBackColor = false;
            // 
            // CBFindLines
            // 
            this.CBFindLines.AutoSize = true;
            this.CBFindLines.BackColor = System.Drawing.Color.Black;
            this.CBFindLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFindLines.ForeColor = System.Drawing.Color.Cyan;
            this.CBFindLines.Location = new System.Drawing.Point(271, 39);
            this.CBFindLines.Name = "CBFindLines";
            this.CBFindLines.Size = new System.Drawing.Size(98, 20);
            this.CBFindLines.TabIndex = 404;
            this.CBFindLines.Text = "Find Lines";
            this.CBFindLines.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.MaximumSize = new System.Drawing.Size(120, 95);
            this.button1.MinimumSize = new System.Drawing.Size(120, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 95);
            this.button1.TabIndex = 22;
            this.button1.Text = "Snap \r\n\r\n\r\nNOW";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBFindRectangles
            // 
            this.CBFindRectangles.AutoSize = true;
            this.CBFindRectangles.BackColor = System.Drawing.Color.Black;
            this.CBFindRectangles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFindRectangles.ForeColor = System.Drawing.Color.Cyan;
            this.CBFindRectangles.Location = new System.Drawing.Point(271, 21);
            this.CBFindRectangles.Name = "CBFindRectangles";
            this.CBFindRectangles.Size = new System.Drawing.Size(136, 20);
            this.CBFindRectangles.TabIndex = 403;
            this.CBFindRectangles.Text = "FindRectangles";
            this.CBFindRectangles.UseVisualStyleBackColor = false;
            // 
            // buttonAnalyzeImage
            // 
            this.buttonAnalyzeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAnalyzeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalyzeImage.ForeColor = System.Drawing.Color.Cyan;
            this.buttonAnalyzeImage.Location = new System.Drawing.Point(126, 0);
            this.buttonAnalyzeImage.MaximumSize = new System.Drawing.Size(120, 95);
            this.buttonAnalyzeImage.MinimumSize = new System.Drawing.Size(120, 95);
            this.buttonAnalyzeImage.Name = "buttonAnalyzeImage";
            this.buttonAnalyzeImage.Size = new System.Drawing.Size(120, 95);
            this.buttonAnalyzeImage.TabIndex = 405;
            this.buttonAnalyzeImage.Text = "Analyze\r\n\r\n\r\nPicture";
            this.buttonAnalyzeImage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAnalyzeImage.UseCompatibleTextRendering = true;
            this.buttonAnalyzeImage.UseVisualStyleBackColor = false;
            this.buttonAnalyzeImage.Click += new System.EventHandler(this.buttonAnalyzeImage_Click);
            // 
            // CBFindCircles
            // 
            this.CBFindCircles.AutoSize = true;
            this.CBFindCircles.BackColor = System.Drawing.Color.Black;
            this.CBFindCircles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBFindCircles.ForeColor = System.Drawing.Color.Cyan;
            this.CBFindCircles.Location = new System.Drawing.Point(271, 3);
            this.CBFindCircles.Name = "CBFindCircles";
            this.CBFindCircles.Size = new System.Drawing.Size(109, 20);
            this.CBFindCircles.TabIndex = 402;
            this.CBFindCircles.Text = "Find Circles";
            this.CBFindCircles.UseVisualStyleBackColor = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Black;
            this.tabPage5.Controls.Add(this.CBTakePictureOnLayerChange);
            this.tabPage5.Controls.Add(this.TBExposure);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.Focus_LBL);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.TBFocus);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(562, 117);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Settings";
            // 
            // CBTakePictureOnLayerChange
            // 
            this.CBTakePictureOnLayerChange.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBTakePictureOnLayerChange.AutoSize = true;
            this.CBTakePictureOnLayerChange.BackColor = System.Drawing.Color.DarkGray;
            this.CBTakePictureOnLayerChange.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CBTakePictureOnLayerChange.FlatAppearance.BorderSize = 3;
            this.CBTakePictureOnLayerChange.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.CBTakePictureOnLayerChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTakePictureOnLayerChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTakePictureOnLayerChange.ForeColor = System.Drawing.Color.Black;
            this.CBTakePictureOnLayerChange.Image = ((System.Drawing.Image)(resources.GetObject("CBTakePictureOnLayerChange.Image")));
            this.CBTakePictureOnLayerChange.Location = new System.Drawing.Point(352, 3);
            this.CBTakePictureOnLayerChange.MaximumSize = new System.Drawing.Size(120, 95);
            this.CBTakePictureOnLayerChange.MinimumSize = new System.Drawing.Size(120, 95);
            this.CBTakePictureOnLayerChange.Name = "CBTakePictureOnLayerChange";
            this.CBTakePictureOnLayerChange.Size = new System.Drawing.Size(120, 95);
            this.CBTakePictureOnLayerChange.TabIndex = 399;
            this.CBTakePictureOnLayerChange.Text = "Snap layer\r\n\r\n\r\nM790";
            this.CBTakePictureOnLayerChange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CBTakePictureOnLayerChange.UseCompatibleTextRendering = true;
            this.CBTakePictureOnLayerChange.UseVisualStyleBackColor = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Black;
            this.tabPage6.Controls.Add(this.PBCanny);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(562, 521);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "CANNY IMAGE";
            // 
            // PBCanny
            // 
            this.PBCanny.CanvasSize = new System.Drawing.Size(60, 40);
            this.PBCanny.ContextMenuStrip = this.CMImageCopyPaste;
            this.PBCanny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBCanny.Image = null;
            this.PBCanny.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PBCanny.Location = new System.Drawing.Point(3, 3);
            this.PBCanny.Margin = new System.Windows.Forms.Padding(5);
            this.PBCanny.Name = "PBCanny";
            this.PBCanny.ROTATION = 0F;
            this.PBCanny.Size = new System.Drawing.Size(556, 515);
            this.PBCanny.TabIndex = 0;
            this.PBCanny.Zoom = 1F;
            this.PBCanny.MouseEnter += new System.EventHandler(this.PBCanny_MouseEnter);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.PBAnalysis);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(562, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "analysis output";
            // 
            // PBAnalysis
            // 
            this.PBAnalysis.CanvasSize = new System.Drawing.Size(60, 40);
            this.PBAnalysis.ContextMenuStrip = this.CMImageCopyPaste;
            this.PBAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBAnalysis.Image = null;
            this.PBAnalysis.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PBAnalysis.Location = new System.Drawing.Point(3, 3);
            this.PBAnalysis.Margin = new System.Windows.Forms.Padding(5);
            this.PBAnalysis.Name = "PBAnalysis";
            this.PBAnalysis.ROTATION = 0F;
            this.PBAnalysis.Size = new System.Drawing.Size(556, 515);
            this.PBAnalysis.TabIndex = 0;
            this.PBAnalysis.Zoom = 1F;
            this.PBAnalysis.MouseEnter += new System.EventHandler(this.PBAnalysis_MouseEnter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.PBCapture);
            this.tabPage2.Controls.Add(this.labelthreshold2);
            this.tabPage2.Controls.Add(this.TBCannyThreshold1);
            this.tabPage2.Controls.Add(this.TBCannyThreshold2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.labelthreshold1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Capture Picure";
            // 
            // PBCapture
            // 
            this.PBCapture.CanvasSize = new System.Drawing.Size(60, 40);
            this.PBCapture.ContextMenuStrip = this.CMImageCopyPaste;
            this.PBCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBCapture.Image = null;
            this.PBCapture.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.PBCapture.Location = new System.Drawing.Point(3, 3);
            this.PBCapture.Margin = new System.Windows.Forms.Padding(5);
            this.PBCapture.Name = "PBCapture";
            this.PBCapture.ROTATION = 0F;
            this.PBCapture.Size = new System.Drawing.Size(556, 515);
            this.PBCapture.TabIndex = 30;
            this.PBCapture.Zoom = 1F;
            this.PBCapture.MouseEnter += new System.EventHandler(this.PBCapture_MouseEnter);
            // 
            // labelthreshold2
            // 
            this.labelthreshold2.AutoSize = true;
            this.labelthreshold2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthreshold2.ForeColor = System.Drawing.Color.Lime;
            this.labelthreshold2.Location = new System.Drawing.Point(484, 573);
            this.labelthreshold2.Name = "labelthreshold2";
            this.labelthreshold2.Size = new System.Drawing.Size(19, 20);
            this.labelthreshold2.TabIndex = 27;
            this.labelthreshold2.Text = "0";
            // 
            // TBCannyThreshold1
            // 
            this.TBCannyThreshold1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBCannyThreshold1.BackColor = System.Drawing.Color.Black;
            this.TBCannyThreshold1.Location = new System.Drawing.Point(399, 541);
            this.TBCannyThreshold1.Maximum = 250;
            this.TBCannyThreshold1.Minimum = 5;
            this.TBCannyThreshold1.Name = "TBCannyThreshold1";
            this.TBCannyThreshold1.Size = new System.Drawing.Size(163, 45);
            this.TBCannyThreshold1.TabIndex = 24;
            this.TBCannyThreshold1.TickFrequency = 5;
            this.TBCannyThreshold1.Value = 100;
            // 
            // TBCannyThreshold2
            // 
            this.TBCannyThreshold2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBCannyThreshold2.BackColor = System.Drawing.Color.Black;
            this.TBCannyThreshold2.Location = new System.Drawing.Point(399, 586);
            this.TBCannyThreshold2.Maximum = 250;
            this.TBCannyThreshold2.Minimum = 5;
            this.TBCannyThreshold2.Name = "TBCannyThreshold2";
            this.TBCannyThreshold2.Size = new System.Drawing.Size(166, 45);
            this.TBCannyThreshold2.TabIndex = 25;
            this.TBCannyThreshold2.TickFrequency = 5;
            this.TBCannyThreshold2.Value = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(390, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cany 2";
            // 
            // labelthreshold1
            // 
            this.labelthreshold1.AutoSize = true;
            this.labelthreshold1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthreshold1.ForeColor = System.Drawing.Color.Lime;
            this.labelthreshold1.Location = new System.Drawing.Point(109, 569);
            this.labelthreshold1.Name = "labelthreshold1";
            this.labelthreshold1.Size = new System.Drawing.Size(19, 20);
            this.labelthreshold1.TabIndex = 26;
            this.labelthreshold1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(16, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cany 1";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.videoSourcePlayer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Live Video";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.ForeColor = System.Drawing.Color.White;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(556, 515);
            this.videoSourcePlayer1.TabIndex = 4;
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 554);
            this.tabControl1.TabIndex = 28;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(410, 39);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(155, 14);
            this.hScrollBar1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 407;
            this.label5.Text = "Sine Wave Size";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CameraControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Name = "CameraControl";
            this.Size = new System.Drawing.Size(570, 780);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.CMImageCopyPaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFocus)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBCannyThreshold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBCannyThreshold2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbStartVideo;
        private System.Windows.Forms.ToolStripComboBox Camera_Selection;
        private System.Windows.Forms.ToolStripDropDownButton TSDDButtonCamerSettings;
        private System.Windows.Forms.ToolStripMenuItem readCameraPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invokeCameraControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCameraResolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem x480ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x600ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x768ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x800ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCameraListToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton TsbStopVideo;
        private System.Windows.Forms.TrackBar TBExposure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TBFocus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Focus_LBL;
        private System.Windows.Forms.CheckBox CBApplyCanny;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAnalyzeImage;
        private System.Windows.Forms.CheckBox CBFindLines;
        private System.Windows.Forms.CheckBox CBFindRectangles;
        private System.Windows.Forms.CheckBox CBFindCircles;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox CBTakePictureOnLayerChange;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip CMImageCopyPaste;
        private System.Windows.Forms.ToolStripMenuItem copyImageToClipBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteImageFromClipboardToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton TSButtonSnapLayer;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox CBCopyImageToClipboard;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelthreshold2;
        private System.Windows.Forms.TrackBar TBCannyThreshold1;
        private System.Windows.Forms.TrackBar TBCannyThreshold2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelthreshold1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        public System.Windows.Forms.TabControl tabControl1;
        public CustomTools.ScrollableImagePanel PBCanny;
        public CustomTools.ScrollableImagePanel PBAnalysis;
        public CustomTools.ScrollableImagePanel PBCapture;
        public System.Windows.Forms.ToolStripComboBox TSComboBoxImageRotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        //private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
    }
}

