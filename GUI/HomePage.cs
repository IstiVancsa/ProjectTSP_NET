using Repository;
using Repository.Repositories;
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
    public partial class HomePage : Form
    {
        private MovieRepository _movieRepository { get; set; }
        private MovieExtraPropertyRepository _movieExtraPropertyRepository { get; set; }
        private PersonRepository _personRepository { get; set; }
        private PhotoRepository _photoRepository { get; set; }
        private PhotoExtraPropertyRepository _photoExtraPropertyRepository { get; set; }
        public HomePage()
        {
            InitializeComponent();
            this._movieRepository = new MovieRepository();
            this._movieExtraPropertyRepository = new MovieExtraPropertyRepository();
            this._photoRepository = new PhotoRepository();
            this._photoExtraPropertyRepository = new PhotoExtraPropertyRepository();
            this._personRepository = new PersonRepository();
        }

        //private void PopulateDBButton_Click(object sender, EventArgs e)
        //{
            //List<Photo> photos = new List<Photo>
            //{
            //    new Photo
            //    {
            //         DateAdded = DateTime.Now,
            //         Description = "Desctiption 1",
            //         Event = "Event 1",
            //         Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Images\2022-Tesla-Cybertruck-V1-1080.jpg",
            //         Place = "Place1"
            //    },
            //    new Photo
            //    {
            //         DateAdded = DateTime.Now,
            //         Description = "Desctiption 2",
            //         Event = "Event 2",
            //         Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Images\2022-Tesla-Cybertruck-V2-1080.jpg",
            //         Place = "Place2"
            //    },
            //    new Photo
            //    {
            //         DateAdded = DateTime.Now,
            //         Description = "Desctiption 3",
            //         Event = "Event 3",
            //         Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Images\images.jpg",
            //         Place = "Place3"
            //    },
            //    new Photo
            //    {
            //         DateAdded = DateTime.Now,
            //         Description = "Desctiption 4",
            //         Event = "Event 4",
            //         Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Images\strv_s1_wallpaper_1920x1080.jpg",
            //         Place = "Place4"
            //    },
            //    new Photo
            //    {
            //         DateAdded = DateTime.Now,
            //         Description = "Desctiption 5",
            //         Event = "Event 5",
            //         Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Images\tesla-roadster-4k-pd-1536x864.jpg",
            //         Place = "Place5"
            //    }
            //};

            //List<Movie> movies = new List<Movie>
            //{
            //    new Movie
            //    {
            //        DateAdded = DateTime.Now,
            //        Description = "Description 1",
            //        Name = "Movie name 1",
            //        Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Movies\Search_Algorithm_Computerphile.mp4"
            //    },
            //    new Movie
            //    {
            //        DateAdded = DateTime.Now,
            //        Description = "Description 2",
            //        Name = "Movie name 2",
            //        Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Movies\Dijkstra_Algorithm_Computerphile.mp4"
            //    },
            //    new Movie
            //    {
            //        DateAdded = DateTime.Now,
            //        Description = "Description 3",
            //        Name = "Movie name 3",
            //        Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Movies\Maze_Solving_Computerphile.mp4"
            //    },
            //    new Movie
            //    {
            //        DateAdded = DateTime.Now,
            //        Description = "Description 4",
            //        Name = "Movie name 4",
            //        Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Movies\A_Pathfinding.mp4"
            //    },
            //    new Movie
            //    {
            //        DateAdded = DateTime.Now,
            //        Description = "Description 5",
            //        Name = "Movie name 5",
            //        Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Movies\Road_trip_planning.mp4"
            //    }
            //};

            //List<Person> people = new List<Person>
            //{
            //    new Person
            //    {
            //        Name = "Gigel",
            //        Movie = new Movie
            //        {
            //            DateAdded = DateTime.Now,
            //            Description = "Description 1",
            //            Name = "Movie name 1",
            //            Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Movies\Search_Algorithm_Computerphile.mp4"
            //        },
            //        Photo = new Photo
            //        {
            //            DateAdded = DateTime.Now,
            //            Description = "Desctiption 1",
            //            Event = "Event 1",
            //            Path = @"D:\Info\Anul3\Sem2\TSP_NET\GitProj\Proiect1\Repository\GUI\Resouces\Images\2022-Tesla-Cybertruck-V1-1080.jpg",
            //            Place = "Place1"
            //        }
            //    }
            //};

            //foreach (Movie movie in movies)
            //    _movieRepository.AddItem(movie);
            //_movieRepository.SaveChanges();

            //foreach (Photo photo in photos)
            //    _photoRepository.AddItem(photo);
            //_photoRepository.SaveChanges();

            //foreach (Person person in people)
            //    _personRepository.AddItem(person);
            //_personRepository.SaveChanges();
        //}

        private void StartButton_Click(object sender, EventArgs e)
        {
            List<Photo> photos = _photoRepository.GetItems().ToList();
            List<Movie> movies = _movieRepository.GetItems().ToList();
            PictureBox.ImageLocation = photos[0].Path;
            VideoPlayer.URL = movies[0].Path;
            VideoPlayer.Ctlcontrols.play();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            VideoPlayer.Ctlcontrols.pause();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            VideoPlayer.Ctlcontrols.stop();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.FilePath.Text = openFileDialog.FileName;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Check if everything is Completed otherwise show popoup to alert user
        }

        private void OpenPhotosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhotosPage photo = new PhotosPage();
            photo.ShowDialog();
        }

        private void OpenVideosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VideosPage video = new VideosPage();
            video.ShowDialog();
        }
    }
}
