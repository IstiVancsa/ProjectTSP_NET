using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MovieExtraPropertyModel : BaseModel
    {
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public  MovieModel Movie { get; set; }
        public MovieExtraPropertyModel()
        {

        }
        public MovieExtraPropertyModel(MovieExtraProperty movieExtraProperty)
        {
            Id = movieExtraProperty.Id;
            PropertyName = movieExtraProperty.PropertyName;
            PropertyValue = movieExtraProperty.PropertyValue;
        }
    }
}
