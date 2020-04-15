namespace GUI
{
    partial class PhotosPage
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
            this.PhotoList = new System.Windows.Forms.ListView();
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Place = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GetAllPhotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(52, 51);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "←";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PhotoList
            // 
            this.PhotoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event,
            this.DateAdded,
            this.Place,
            this.Description});
            this.PhotoList.FullRowSelect = true;
            this.PhotoList.GridLines = true;
            this.PhotoList.HideSelection = false;
            this.PhotoList.Location = new System.Drawing.Point(12, 58);
            this.PhotoList.Name = "PhotoList";
            this.PhotoList.Size = new System.Drawing.Size(776, 380);
            this.PhotoList.TabIndex = 1;
            this.PhotoList.UseCompatibleStateImageBehavior = false;
            this.PhotoList.View = System.Windows.Forms.View.Details;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 104;
            // 
            // DateAdded
            // 
            this.DateAdded.Text = "Date Added";
            this.DateAdded.Width = 161;
            // 
            // Place
            // 
            this.Place.Text = "Place";
            this.Place.Width = 146;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 358;
            // 
            // GetAllPhotos
            // 
            this.GetAllPhotos.Location = new System.Drawing.Point(366, 12);
            this.GetAllPhotos.Name = "GetAllPhotos";
            this.GetAllPhotos.Size = new System.Drawing.Size(88, 32);
            this.GetAllPhotos.TabIndex = 2;
            this.GetAllPhotos.Text = "Get All Photos";
            this.GetAllPhotos.UseVisualStyleBackColor = true;
            this.GetAllPhotos.Click += new System.EventHandler(this.GetAllPhotos_Click);
            // 
            // PhotosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetAllPhotos);
            this.Controls.Add(this.PhotoList);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PhotosPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView PhotoList;
        private System.Windows.Forms.Button GetAllPhotos;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader DateAdded;
        private System.Windows.Forms.ColumnHeader Place;
        private System.Windows.Forms.ColumnHeader Description;
    }
}