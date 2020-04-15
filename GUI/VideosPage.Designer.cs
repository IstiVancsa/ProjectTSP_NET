namespace GUI
{
    partial class VideosPage
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
            this.BackButton = new System.Windows.Forms.Button();
            this.VideoList = new System.Windows.Forms.ListView();
            this.GetAllVideos = new System.Windows.Forms.Button();
            this.VideoName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 51);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "←";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // VideoList
            // 
            this.VideoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VideoName,
            this.DateAdded,
            this.Description});
            this.VideoList.FullRowSelect = true;
            this.VideoList.GridLines = true;
            this.VideoList.HideSelection = false;
            this.VideoList.Location = new System.Drawing.Point(12, 60);
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(776, 378);
            this.VideoList.TabIndex = 2;
            this.VideoList.UseCompatibleStateImageBehavior = false;
            this.VideoList.View = System.Windows.Forms.View.Details;
            // 
            // GetAllVideos
            // 
            this.GetAllVideos.Location = new System.Drawing.Point(362, 12);
            this.GetAllVideos.Name = "GetAllVideos";
            this.GetAllVideos.Size = new System.Drawing.Size(85, 34);
            this.GetAllVideos.TabIndex = 3;
            this.GetAllVideos.Text = "Get All Videos";
            this.GetAllVideos.UseVisualStyleBackColor = true;
            this.GetAllVideos.Click += new System.EventHandler(this.GetAllVideos_Click);
            // 
            // VideoName
            // 
            this.VideoName.Text = "Name";
            this.VideoName.Width = 189;
            // 
            // DateAdded
            // 
            this.DateAdded.Text = "Date Added";
            this.DateAdded.Width = 175;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 406;
            // 
            // VideosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetAllVideos);
            this.Controls.Add(this.VideoList);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VideosPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Videos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView VideoList;
        private System.Windows.Forms.Button GetAllVideos;
        private System.Windows.Forms.ColumnHeader VideoName;
        private System.Windows.Forms.ColumnHeader DateAdded;
        private System.Windows.Forms.ColumnHeader Description;
    }
}