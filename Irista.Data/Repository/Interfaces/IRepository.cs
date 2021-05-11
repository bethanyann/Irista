using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Irista.Data.Repository.Interfaces
{
    public interface IRepository<TKey, TEntity> where TEntity : class where TKey : IEquatable<TKey>
    {
        //these are from mosh's version of IRepository
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        // This method was not in the videos, but I thought it would be useful to add.
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);

        //From Brent's Repository class that was inplmeneting an interface, fix this later
        //public override AddOrUpdate(TEntity entity);
        //public override TEntity AddOrUpdateAndSaveAsync(TEntity entity, Func<IQueryable<TEntity>, IQueryable<TEntity>> includeChildrenToUpdate = null);
        //public override Task<TEntity> AddOrUpdateAndSaveAsync(TEntity entity, Func<IQueryable<TEntity>, IQueryable<TEntity>> includedChildrenToUpdate = null);
        //public override bool Exists(TKey id);
        //public override Task<bool> ExistsAsync(TKey id);
        //public override IQueryable<TEntity> GetByIdQueryable(TKey id, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
    }
}
