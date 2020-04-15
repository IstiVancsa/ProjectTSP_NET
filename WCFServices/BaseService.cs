using AutoMapper;
using Models;
using Models.Filters;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WCFServices
{
    public class BaseService<TRepository, TEntity, TModel, TFilter> : IBaseService<TModel, TFilter>
        where TEntity : BaseEntity, new()
        where TRepository : GenericRepository<TEntity>, new()
        where TModel : BaseModel, new()
        where TFilter : IBaseFilter<TModel>
    {
        #region Properties
        public TRepository BaseRepository { get; set; }
        #endregion
        #region Initialization
        public BaseService()
        {
            BaseRepository = new TRepository();
        }
        #endregion
        public List<TModel> GetAll()
        {
            return this.BaseRepository.GetItems().ToList()
                .Select(x => Activator.CreateInstance(typeof(TModel), new object[] { x }) as TModel).ToList();
        }

        public List<TModel> GetByFilter(TFilter filter)
        {
            Expression<Func<TEntity, bool>> myFilter;
            var modelFilter = filter.GetFilter();

            var parameters = Expression.Parameter(typeof(TEntity));
            myFilter = Expression.Lambda<Func<TEntity, bool>>(Expression.Invoke(modelFilter, Expression.Convert(parameters, typeof(TEntity))), parameters);
            
            return this.BaseRepository.GetItems(myFilter).ToList()
                .Select(x => Activator.CreateInstance(typeof(TModel), new object[] { x }) as TModel).ToList();
        }
    }
}
