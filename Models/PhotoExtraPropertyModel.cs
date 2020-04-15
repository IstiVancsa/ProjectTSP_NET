using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PhotoExtraPropertyModel : BaseModel
    {
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public  PhotoModel Photo { get; set; }
        public PhotoExtraPropertyModel()
        {

        }
        public PhotoExtraPropertyModel(PhotoExtraProperty photoExtraProperty)
        {
            Id = photoExtraProperty.Id;
            PropertyName = photoExtraProperty.PropertyName;
            PropertyValue = photoExtraProperty.PropertyValue;
        }
    }
}
