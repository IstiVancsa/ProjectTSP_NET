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
    public class BaseService<TRepository, TEntity, TModel, TFilter>
        where TEntity : BaseEntity, new()
        where TRepository : GenericRepository<TEntity>, new()
        where TModel : BaseModel, new()
        where TFilter : IBaseFilter<TEntity>
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
            
            return this.BaseRepository.GetItems(modelFilter).ToList()
                .Select(x => Activator.CreateInstance(typeof(TModel), new object[] { x }) as TModel).ToList();
        }
    }
}
