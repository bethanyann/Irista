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


        // Summary:
        //     This function returns a queryable of objects with the Interfaces applied. i.e.
        //     if your object has GenericRepository.Core.Interfaces.ISaveableDelete and GenericRepository.Core.Interfaces.ISaveableActive,
        //     this method will return all objects who are not deleted, but ignores active.
        //     if your object has GenericRepository.Core.Interfaces.ISaveableActive only, it
        //     returns objects that have the active flag set to
        //     true
        //
        // Parameters:
        //   predicate:
        //
        //   includes:
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //these are all from brent's library
        //    //
        //    // Summary:
        //    //     The Table used in this repository
        //    DbSet<TEntity> DbSet { get; }
        //    //
        //    // Summary:
        //    //     Adds or updates entities based on their interfaces. Method assumes entity being
        //    //     passed in already has been tracked by Entity Framework
        //    //
        //    // Parameters:
        //    //   entity:
        //    //     TEntity
        //    void AddOrUpdate(TEntity entity);
        //    //
        //    // Summary:
        //    //     Adds or updates entities based on their interfaces, and saves them to the table.
        //    //
        //    // Parameters:
        //    //   entity:
        //    //
        //    //   includedChildrenToUpdate:
        //    //     Child objects to update during save
        //    //
        //    // Exceptions:
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateException:
        //    //     An error occurred sending updates to the database.
        //    //
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException:
        //    //     A database command did not affect the expected number of rows. This usually indicates
        //    //     an optimistic concurrency violation; that is, a row has been changed in the database
        //    //     since it was queried.
        //    //
        //    //   T:System.NotSupportedException:
        //    //     An attempt was made to use unsupported behavior such as executing multiple asynchronous
        //    //     commands concurrently on the same context instance.
        //    TEntity AddOrUpdateAndSave(TEntity entity, Func<IQueryable<TEntity>, IQueryable<TEntity>> includedChildrenToUpdate = null);
        //    //
        //    // Summary:
        //    //     Adds or updates entities based on their interfaces, and saves them to the table.
        //    //
        //    // Parameters:
        //    //   entity:
        //    //
        //    //   includedChildrenToUpdate:
        //    //     Child objects to update during save
        //    //
        //    // Exceptions:
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateException:
        //    //     An error occurred sending updates to the database.
        //    //
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException:
        //    //     A database command did not affect the expected number of rows. This usually indicates
        //    //     an optimistic concurrency violation; that is, a row has been changed in the database
        //    //     since it was queried.
        //    Task<TEntity> AddOrUpdateAndSaveAsync(TEntity entity, Func<IQueryable<TEntity>, IQueryable<TEntity>> includedChildrenToUpdate = null);
        //    //
        //    // Summary:
        //    //     Gets System.Linq.IQueryable`1 (applies constraints based on interfaces)
        //    //
        //    // Parameters:
        //    //   includes:
        //    IQueryable<TEntity> AsQueryable(Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     Deletes an entity (Applies Updates based on interfaces)
        //    //
        //    // Parameters:
        //    //   entity:
        //    void Delete(TEntity entity);
        //    //
        //    // Summary:
        //    //     Deletes entities (Applies Updates based on interfaces)
        //    //
        //    // Parameters:
        //    //   entities:
        //    void Delete(List<TEntity> entities);
        //    //
        //    // Summary:
        //    //     Deletes entities (Applies Updates based on interfaces)
        //    //
        //    // Parameters:
        //    //   entities:
        //    //
        //    // Exceptions:
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateException:
        //    //     An error occurred sending updates to the database.
        //    //
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException:
        //    //     A database command did not affect the expected number of rows. This usually indicates
        //    //     an optimistic concurrency violation; that is, a row has been changed in the database
        //    //     since it was queried.
        //    //
        //    //   T:System.NotSupportedException:
        //    //     An attempt was made to use unsupported behavior such as executing multiple asynchronous
        //    //     commands concurrently on the same context instance.
        //    void DeleteAndSave(List<TEntity> entities);
        //    //
        //    // Summary:
        //    //     Deletes an entity (Applies Updates based on interfaces)
        //    //
        //    // Parameters:
        //    //   entity:
        //    //
        //    // Exceptions:
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateException:
        //    //     An error occurred sending updates to the database.
        //    //
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException:
        //    //     A database command did not affect the expected number of rows. This usually indicates
        //    //     an optimistic concurrency violation; that is, a row has been changed in the database
        //    //     since it was queried.
        //    //
        //    //   T:System.NotSupportedException:
        //    //     An attempt was made to use unsupported behavior such as executing multiple asynchronous
        //    //     commands concurrently on the same context instance.
        //    void DeleteAndSave(TEntity entity);
        //    //
        //    // Summary:
        //    //     Deletes entities (Applies Updates based on interfaces)
        //    //
        //    // Parameters:
        //    //   entities:
        //    //
        //    // Exceptions:
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateException:
        //    //     An error occurred sending updates to the database.
        //    //
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException:
        //    //     A database command did not affect the expected number of rows. This usually indicates
        //    //     an optimistic concurrency violation; that is, a row has been changed in the database
        //    //     since it was queried.
        //    Task DeleteAndSaveAsync(List<TEntity> entities);
        //    //
        //    // Summary:
        //    //     Deletes an entity (Applies Updates based on interfaces)
        //    //
        //    // Parameters:
        //    //   entity:
        //    //
        //    // Exceptions:
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateException:
        //    //     An error occurred sending updates to the database.
        //    //
        //    //   T:Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException:
        //    //     A database command did not affect the expected number of rows. This usually indicates
        //    //     an optimistic concurrency violation; that is, a row has been changed in the database
        //    //     since it was queried.
        //    Task DeleteAndSaveAsync(TEntity entity);
        //    //
        //    // Summary:
        //    //     Gets the first found entity based on specified parameters (applies constraints
        //    //     based on interfaces)
        //    //
        //    // Parameters:
        //    //   predicate:
        //    //
        //    //   includes:
        //    //
        //    // Returns:
        //    //     System.Collections.Generic.List`1
        //    //
        //    // Exceptions:
        //    //   T:System.ArgumentNullException:
        //    //     predicate is null.
        //    TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     Gets the first found entity based on specified parameters (applies constraints
        //    //     based on interfaces)
        //    //
        //    // Parameters:
        //    //   predicate:
        //    //
        //    //   includes:
        //    //
        //    // Returns:
        //    //     System.Collections.Generic.List`1
        //    //
        //    // Exceptions:
        //    //   T:System.ArgumentNullException:
        //    //     predicate is null.
        //    Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     Gets the Current Context
        //    DbContext GetCurrentContext();
        //    //
        //    // Summary:
        //    //     Gets an entity based on specified parameters, will error out if more than one
        //    //     are found. (applies constraints based on interfaces)
        //    //
        //    // Parameters:
        //    //   predicate:
        //    //
        //    //   includes:
        //    //
        //    // Returns:
        //    //     System.Collections.Generic.List`1
        //    //
        //    // Exceptions:
        //    //   T:System.ArgumentNullException:
        //    //     predicate is null.
        //    TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     Gets an entity based on specified parameters, will error out if more than one
        //    //     are found. (applies constraints based on interfaces)
        //    //
        //    // Parameters:
        //    //   predicate:
        //    //
        //    //   includes:
        //    //
        //    // Returns:
        //    //     System.Collections.Generic.List`1
        //    //
        //    // Exceptions:
        //    //   T:System.ArgumentNullException:
        //    //     predicate is null.
        //    Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     Gets all entities (applies constraints based on interfaces)
        //    //
        //    // Parameters:
        //    //   includes:
        //    //
        //    // Returns:
        //    //     System.Collections.Generic.List`1
        //    List<TEntity> ToList(Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     Gets all entities (applies constraints based on interfaces)
        //    //
        //    // Parameters:
        //    //   includes:
        //    //
        //    // Returns:
        //    //     System.Collections.Generic.List`1
        //    Task<List<TEntity>> ToListAsync(Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //    //
        //    // Summary:
        //    //     This function returns a queryable of objects with the Interfaces applied. i.e.
        //    //     if your object has GenericRepository.Core.Interfaces.ISaveableDelete and GenericRepository.Core.Interfaces.ISaveableActive,
        //    //     this method will return all objects who are not deleted, but ignores active.
        //    //     if your object has GenericRepository.Core.Interfaces.ISaveableActive only, it
        //    //     returns objects that have the active flag set to
        //    //     true
        //    //
        //    // Parameters:
        //    //   predicate:
        //    //
        //    //   includes:
        //    IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IQueryable<TEntity>> includes = null);
        //}
    }
}
