using GUI.MovieService;
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
    public partial class VideosPage : Form
    {
        public VideosPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }
        private async void GetAllVideos_Click(object sender, EventArgs e)
        {
            MovieServiceClient client = new MovieServiceClient("NetTcpBinding_IMovieService");
            var videos = await client.GetAllAsync();
            client.Close();
            foreach (var video in videos)
            {
                ListViewItem item = new ListViewItem(video.Name);
                item.SubItems.Add(video.DateAdded.ToString());
                item.SubItems.Add(video.Description);
                VideoList.Items.Add(item);
            }
        }
    }
}
