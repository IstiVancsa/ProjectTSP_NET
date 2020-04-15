using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MovieModel : BaseModel
    {
        public string Name { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public bool PathChanged { get; set; }

        public virtual ICollection<PersonModel> People { get; set; }
        public virtual ICollection<MovieExtraPropertyModel> MovieExtraProperties { get; set; }
        public MovieModel()
        {

        }
        public MovieModel(Movie movie)
        {
            Name = movie.Name;
            DateAdded = movie.DateAdded;
            Description = movie.Description;
            Path = movie.Path;
            PathChanged = movie.PathChanged;
            People = movie.People.Select(x => new PersonModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            MovieExtraProperties = movie.MovieExtraProperties.Select(x => new MovieExtraPropertyModel(x)).ToList();
        }
    }
}
