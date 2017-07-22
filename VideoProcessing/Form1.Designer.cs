namespace VideoProcessing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setStaticImageFromLiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBackgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBroadcastingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.thresholdBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.staticImageFromLive = new System.Windows.Forms.PictureBox();
            this.backgroundImage = new System.Windows.Forms.PictureBox();
            this.browseBGImageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticImageFromLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.setImagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cameraToolStripMenuItem.Text = "Camera";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // setImagesToolStripMenuItem
            // 
            this.setImagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setStaticImageFromLiveToolStripMenuItem,
            this.openBackgroundImageToolStripMenuItem,
            this.startBroadcastingToolStripMenuItem});
            this.setImagesToolStripMenuItem.Name = "setImagesToolStripMenuItem";
            this.setImagesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.setImagesToolStripMenuItem.Text = "Set Images";
            // 
            // setStaticImageFromLiveToolStripMenuItem
            // 
            this.setStaticImageFromLiveToolStripMenuItem.Name = "setStaticImageFromLiveToolStripMenuItem";
            this.setStaticImageFromLiveToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.setStaticImageFromLiveToolStripMenuItem.Text = "Set Static Image From Live";
            this.setStaticImageFromLiveToolStripMenuItem.Click += new System.EventHandler(this.setStaticImageFromLiveToolStripMenuItem_Click);
            // 
            // openBackgroundImageToolStripMenuItem
            // 
            this.openBackgroundImageToolStripMenuItem.Name = "openBackgroundImageToolStripMenuItem";
            this.openBackgroundImageToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.openBackgroundImageToolStripMenuItem.Text = "Open Background Image";
            this.openBackgroundImageToolStripMenuItem.Click += new System.EventHandler(this.openBackgroundImageToolStripMenuItem_Click);
            // 
            // startBroadcastingToolStripMenuItem
            // 
            this.startBroadcastingToolStripMenuItem.Name = "startBroadcastingToolStripMenuItem";
            this.startBroadcastingToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.startBroadcastingToolStripMenuItem.Text = "Start Broadcasting";
            this.startBroadcastingToolStripMenuItem.Click += new System.EventHandler(this.startBroadcastingToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(338, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // thresholdBar
            // 
            this.thresholdBar.Location = new System.Drawing.Point(12, 289);
            this.thresholdBar.Maximum = 100;
            this.thresholdBar.Name = "thresholdBar";
            this.thresholdBar.Size = new System.Drawing.Size(646, 45);
            this.thresholdBar.TabIndex = 3;
            this.thresholdBar.Value = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Threshold";
            // 
            // staticImageFromLive
            // 
            this.staticImageFromLive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.staticImageFromLive.Location = new System.Drawing.Point(12, 327);
            this.staticImageFromLive.Name = "staticImageFromLive";
            this.staticImageFromLive.Size = new System.Drawing.Size(320, 240);
            this.staticImageFromLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staticImageFromLive.TabIndex = 7;
            this.staticImageFromLive.TabStop = false;
            // 
            // backgroundImage
            // 
            this.backgroundImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backgroundImage.Location = new System.Drawing.Point(338, 327);
            this.backgroundImage.Name = "backgroundImage";
            this.backgroundImage.Size = new System.Drawing.Size(320, 240);
            this.backgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundImage.TabIndex = 8;
            this.backgroundImage.TabStop = false;
            // 
            // browseBGImageDialog
            // 
            this.browseBGImageDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 578);
            this.Controls.Add(this.backgroundImage);
            this.Controls.Add(this.staticImageFromLive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.thresholdBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Video Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staticImageFromLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem setImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setStaticImageFromLiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBackgroundImageToolStripMenuItem;
        private System.Windows.Forms.TrackBar thresholdBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox staticImageFromLive;
        private System.Windows.Forms.PictureBox backgroundImage;
        private System.Windows.Forms.OpenFileDialog browseBGImageDialog;
        private System.Windows.Forms.ToolStripMenuItem startBroadcastingToolStripMenuItem;
    }
}

