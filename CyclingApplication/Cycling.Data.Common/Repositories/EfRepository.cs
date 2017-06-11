using Cycling.Data.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Cycling.Data.Common.Repositories
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        public EfRepository(DbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = this.DbContext.Set<T>();
        }

        protected DbContext DbContext { get; set; }

        protected DbSet<T> DbSet { get; set; }


        public T GetById(object id)
        {
            return this.DbSet.Find(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this.DbSet.Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return this.DbSet.ToList();
        }

        public void Add(T entity)
        {
            this.DbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this.DbSet.AddRange(entities);
        }

        public void Remove(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            this.DbSet.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            var entry = this.DbContext.Entry(entity);
            entry.State = EntityState.Modified;
        }
    }
}
