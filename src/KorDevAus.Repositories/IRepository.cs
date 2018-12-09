using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using KorDevAus.Entities;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This provides interfaces to the repository layers.
    /// </summary>
    /// <typeparam name="T">Type of database entity.</typeparam>
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        /// <summary>
        /// Gets all database entities of the type T.
        /// </summary>
        /// <returns>Returns the all database entities of the type T.</returns>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// Gets a database entity with Id.
        /// </summary>
        /// <param name="id">Entity Id.</param>
        /// <returns>Returns the database entity with Id.</returns>
        Task<T> GetAsync(Guid id);

        /// <summary>
        /// Inserts a database entity.
        /// </summary>
        /// <param name="entity">Database entity object to insert.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task InsertAsync(T entity, bool commit = true);

        /// <summary>
        /// Inserts set of database entities.
        /// </summary>
        /// <param name="entities">List of database entity objects to insert.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task InsertRangeAsync(IEnumerable<T> entities, bool commit = true);

        /// <summary>
        /// Updates a database entity.
        /// </summary>
        /// <param name="entity">Database entity object to update.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task UpdateAsync(T entity, bool commit = true);

        /// <summary>
        /// Updates set of database entities.
        /// </summary>
        /// <param name="entities">List of database entity objects to update.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task UpdateRangeAsync(IEnumerable<T> entities, bool commit = true);

        /// <summary>
        /// Adds or updates a database entity.
        /// </summary>
        /// <param name="entity">Database entity object to update.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task UpsertAsync(T entity, bool commit = true);

        /// <summary>
        /// Adds or updates set of database entities.
        /// </summary>
        /// <param name="entities">List of database entity objects to update.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task UpsertRangeAsync(IEnumerable<T> entities, bool commit = true);

        /// <summary>
        /// Deletes a database entity.
        /// </summary>
        /// <param name="entity">Database entity object to delete.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task DeleteAsync(T entity, bool commit = true);

        /// <summary>
        /// Deletes set of database entities.
        /// </summary>
        /// <param name="entities">List of database entity objects to delete.</param>
        /// <param name="commit">Value indicating whether to complete transaction or not.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task DeleteRangeAsync(IEnumerable<T> entities, bool commit = true);
    }
}