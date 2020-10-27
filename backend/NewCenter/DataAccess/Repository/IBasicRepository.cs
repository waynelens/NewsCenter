using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NewCenter.Repository
{
    public interface IBasicRepository<TModel> where TModel : class
    {
        // CRUD
        void Create(TModel entity);

        void Create(IEnumerable<TModel> entities);

        TModel Read(Expression<Func<TModel, bool>> predicate);

        IQueryable<TModel> ReadAll();

        void Update(TModel oldEntity,TModel newEntity);

        void Delete(TModel entity);

        bool Repeat(Expression<Func<TModel, bool>> predicate);

        void Dispose();
    }
}
