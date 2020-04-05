namespace GUI
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.PopulateDBButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.VideoRadioButton = new System.Windows.Forms.RadioButton();
            this.PhotoRadioButton = new System.Windows.Forms.RadioButton();
            this.OpenPhotosButton = new System.Windows.Forms.Button();
            this.OpenVideosButton = new System.Windows.Forms.Button();
            this.ShowPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // PopulateDBButton
            // 
            this.PopulateDBButton.Location = new System.Drawing.Point(9, 0);
            this.PopulateDBButton.Margin = new System.Windows.Forms.Padding(2);
            this.PopulateDBButton.Name = "PopulateDBButton";
            this.PopulateDBButton.Size = new System.Drawing.Size(1042, 19);
            this.PopulateDBButton.TabIndex = 0;
            this.PopulateDBButton.Text = "Populate DB";
            this.PopulateDBButton.UseVisualStyleBackColor = true;
            this.PopulateDBButton.Click += new System.EventHandler(this.PopulateDBButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(9, 24);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(495, 415);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(529, 29);
            this.VideoPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(522, 435);
            this.VideoPlayer.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(8, 443);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 24);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(69, 443);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(56, 24);
            this.PauseButton.TabIndex = 4;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(129, 443);
            this.StopButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(56, 25);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(8, 494);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(56, 19);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(106, 472);
            this.FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(275, 20);
            this.FilePath.TabIndex = 8;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(8, 471);
            this.ChooseFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(94, 21);
            this.ChooseFileButton.TabIndex = 9;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // VideoRadioButton
            // 
            this.VideoRadioButton.AutoSize = true;
            this.VideoRadioButton.Location = new System.Drawing.Point(73, 496);
            this.VideoRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.VideoRadioButton.Name = "VideoRadioButton";
            this.VideoRadioButton.Size = new System.Drawing.Size(52, 17);
            this.VideoRadioButton.TabIndex = 10;
            this.VideoRadioButton.TabStop = true;
            this.VideoRadioButton.Text = "Video";
            this.VideoRadioButton.UseVisualStyleBackColor = true;
            // 
            // PhotoRadioButton
            // 
            this.PhotoRadioButton.AutoSize = true;
            this.PhotoRadioButton.Location = new System.Drawing.Point(127, 496);
            this.PhotoRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.PhotoRadioButton.Name = "PhotoRadioButton";
            this.PhotoRadioButton.Size = new System.Drawing.Size(53, 17);
            this.PhotoRadioButton.TabIndex = 11;
            this.PhotoRadioButton.TabStop = true;
            this.PhotoRadioButton.Text = "Photo";
            this.PhotoRadioButton.UseVisualStyleBackColor = true;
            // 
            // OpenPhotosButton
            // 
            this.OpenPhotosButton.Location = new System.Drawing.Point(637, 483);
            this.OpenPhotosButton.Name = "OpenPhotosButton";
            this.OpenPhotosButton.Size = new System.Drawing.Size(102, 23);
            this.OpenPhotosButton.TabIndex = 12;
            this.OpenPhotosButton.Text = "Open Photos";
            this.OpenPhotosButton.UseVisualStyleBackColor = true;
            this.OpenPhotosButton.Click += new System.EventHandler(this.OpenPhotosButton_Click);
            // 
            // OpenVideosButton
            // 
            this.OpenVideosButton.Location = new System.Drawing.Point(851, 483);
            this.OpenVideosButton.Name = "OpenVideosButton";
            this.OpenVideosButton.Size = new System.Drawing.Size(101, 23);
            this.OpenVideosButton.TabIndex = 13;
            this.OpenVideosButton.Text = "Open Videos";
            this.OpenVideosButton.UseVisualStyleBackColor = true;
            this.OpenVideosButton.Click += new System.EventHandler(this.OpenVideosButton_Click);
            // 
            // ShowPhoto
            // 
            this.ShowPhoto.Location = new System.Drawing.Point(190, 441);
            this.ShowPhoto.Name = "ShowPhoto";
            this.ShowPhoto.Size = new System.Drawing.Size(75, 27);
            this.ShowPhoto.TabIndex = 14;
            this.ShowPhoto.Text = "Show Photo";
            this.ShowPhoto.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1058, 518);
            this.Controls.Add(this.ShowPhoto);
            this.Controls.Add(this.OpenVideosButton);
            this.Controls.Add(this.OpenPhotosButton);
            this.Controls.Add(this.PhotoRadioButton);
            this.Controls.Add(this.VideoRadioButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.VideoPlayer);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.PopulateDBButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PopulateDBButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.RadioButton VideoRadioButton;
        private System.Windows.Forms.RadioButton PhotoRadioButton;
        private System.Windows.Forms.Button OpenPhotosButton;
        private System.Windows.Forms.Button OpenVideosButton;
        private System.Windows.Forms.Button ShowPhoto;
    }
}

