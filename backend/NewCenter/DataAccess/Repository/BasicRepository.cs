using Microsoft.CodeAnalysis.FlowAnalysis;
using Microsoft.EntityFrameworkCore;
using NewCenter.DataAccess;
using NewCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using AutoMapper;

namespace NewCenter.Repository
{
    public class BasicRepository<TModel> : IBasicRepository<TModel> where TModel : BaseModel
    {
        protected DAOContext Context;

        protected DbSet<TModel> Set => Context.Set<TModel>();

        public BasicRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException(nameof(context));
            }
            Context = (DAOContext)context;
        }

        public void Create(TModel entity)
        {
            Set.Add(entity);
            Context.SaveChanges();
        }

        public void Create(IEnumerable<TModel> entities)
        {
            Set.AddRange(entities);
            Context.SaveChanges();
        }

        public TModel Read(Expression<Func<TModel, bool>> predicate)
        {
            return Set.FirstOrDefault(predicate);
        }

        public IQueryable<TModel> ReadAll()
        {
            return Set.AsQueryable();
        }
        public void Update(TModel oldEntity, TModel newEntity)
        {
            Context.Entry(oldEntity).State = EntityState.Modified;
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<TModel, TModel>(); });
            var mapper = config.CreateMapper();
            mapper.Map(newEntity, oldEntity);
            Context.SaveChangesAsync();
        }
        public void Delete(TModel entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            entity.IsDelete = true;
            entity.EditTime = DateTime.Now;
            Context.SaveChanges();
        }

        public bool Repeat(Expression<Func<TModel, bool>> predicate)
        {
            int count = Set.Where(predicate).Count();
            return count > 0 ? true : false;
        }

        public void Dispose()
        {
            Context.Dispose();
        }

    }
}
