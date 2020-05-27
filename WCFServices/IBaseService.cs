using Models;
using Models.Filters;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServices
{
    [ServiceContract]
    public interface IBaseService<TModel, TFilter, TEntity>
        where TModel : BaseModel, new()
        where TFilter : IBaseFilter<TEntity>
        where TEntity : BaseEntity
    {
        [OperationContract]
        List<TModel> GetAll();
        [OperationContract]
        List<TModel> GetByFilter(TFilter filter);
    }
}
