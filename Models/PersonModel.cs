using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PersonModel : BaseModel
    {
        public string Name { get; set; }
        public virtual MovieModel Movie { get; set; }
        public virtual PhotoModel Photo { get; set; }
    }
}
