using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Models.Filters
{
    public interface IBaseFilter<TModel>
        where TModel : BaseModel
    {
        int? Id { get; set; }
        Expression<Func<TModel, bool>> GetFilter();
    }
}
