using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models.Filters
{
    public class MovieExtraPropertyFilter : IBaseFilter<MovieExtraPropertyModel>
    {
        public int? Id { get; set; }

        public Expression<Func<MovieExtraPropertyModel, bool>> GetFilter()
        {
            Expression<Func<MovieExtraPropertyModel, bool>> filter = x => true;

            if (Id.HasValue)
                filter = filter.And(x => x.Id == Id);

            return filter;
        }
    }
}
