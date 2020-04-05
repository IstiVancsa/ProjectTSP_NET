using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
         where TEntity : BaseEntity, new()
    {
        private static Model1Container _databaseContext = null;
        private static Model1Container DatabaseContext
        {
            get
            {
                if (_databaseContext == null)
                    _databaseContext = new Model1Container();
                return _databaseContext;
            }
        }
        public GenericRepository()
        {
        }

        internal virtual IQueryable<TEntity> PrepareSet()
        {
            return DatabaseContext.Set<TEntity>().AsQueryable();
        }
        public void AddItem(TEntity item)
        {
            DatabaseContext.Set<TEntity>().Add(item);
            SaveChanges();
        }

        public IQueryable<TEntity> GetItems()
        {
            IQueryable<TEntity> items = DatabaseContext.Set<TEntity>().Where(x => true)
                .OrderBy(x => x.Id);

            return items;
        }

        public IQueryable<TEntity> GetItems(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> items = DatabaseContext.Set<TEntity>().Where(predicate)
                .OrderBy(x => x.Id);

            return items;
        }

        public TEntity GetItem(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity myItem = PrepareSet().Where(predicate)
                .FirstOrDefault();

            return myItem;
        }

        public void UpdateItem(TEntity entity)
        {
            DatabaseContext.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public void DeleteItem(TEntity entity)
        {
            DatabaseContext.Set<TEntity>().Remove(entity);
            SaveChanges();
        }

        public void DeleteItem(int id)
        {
            TEntity myEntity = PrepareSet().FirstOrDefault(x => x.Id == id);
            if (myEntity != null)
                DatabaseContext.Set<TEntity>().Remove(myEntity);
            SaveChanges();
        }

        public int SaveChanges() { return DatabaseContext.SaveChanges(); }
    }
}
