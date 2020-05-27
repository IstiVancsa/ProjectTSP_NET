using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Models.Filters
{
    public interface IBaseFilter<TEntity>
        where TEntity : BaseEntity
    {
        int? Id { get; set; }
        Expression<Func<TEntity, bool>> GetFilter();
    }
}
