using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models.Filters
{
    public class PersonFilter : IBaseFilter<PersonModel>
    {
        public int? Id { get; set; }

        public Expression<Func<PersonModel, bool>> GetFilter()
        {
            Expression<Func<PersonModel, bool>> filter = x => true;

            if (Id.HasValue)
                filter = filter.And(x => x.Id == Id);

            return filter;
        }
    }
}
