using GUI.PhotoService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PhotosPage : Form
    {
        public PhotosPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private async void GetAllPhotos_Click(object sender, EventArgs e)
        {
            PhotoServiceClient client = new PhotoServiceClient("NetTcpBinding_IPhotoService");
            var photos = await client.GetAllAsync();
            client.Close();
            foreach (var photo in photos)
            {
                ListViewItem item = new ListViewItem(photo.Event);
                item.SubItems.Add(photo.DateAdded.ToString());
                item.SubItems.Add(photo.Place);
                item.SubItems.Add(photo.Description);
                PhotoList.Items.Add(item);
            }
        }
    }
}
