using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models.Filters
{
    public class MovieFilter : IBaseFilter<MovieModel>
    {
        public int? Id { get; set; }

        public Expression<Func<MovieModel, bool>> GetFilter()
        {
            Expression<Func<MovieModel, bool>> filter = x => true;

            if (Id.HasValue)
                filter = filter.And(x => x.Id == Id);

            return filter;
        }
    }
}
