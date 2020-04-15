using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhotoModel : BaseModel
    {
        public string Event { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string Place { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public bool PathChanged { get; set; }
        public virtual ICollection<PersonModel> People { get; set; }
        public virtual ICollection<PhotoExtraPropertyModel> PhotoExtraProperties { get; set; }

        public PhotoModel()
        {

        }
        public PhotoModel(Photo photo)
        {
            Event = photo.Event;
            DateAdded = photo.DateAdded;
            Place = photo.Place;
            Description = photo.Description;
            Path = photo.Path;
            PathChanged = photo.PathChanged;
            People = photo.People.Select(x => new PersonModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            PhotoExtraProperties = photo.PhotoExtraProperties.Select(x => new PhotoExtraPropertyModel(x)).ToList();
        }
    }
}
