using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Models.Filters
{
    public class MovieFilter : IBaseFilter<Movie>
    {
        public int? Id { get; set; }

        public Expression<Func<Movie, bool>> GetFilter()
        {
            Expression<Func<Movie, bool>> filter = x => true;

            if (Id.HasValue)
                filter = filter.And(x => x.Id == Id);

            return filter;
        }
    }
}
