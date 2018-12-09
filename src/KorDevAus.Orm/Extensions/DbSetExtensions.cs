using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace KorDevAus.Orm.Extensions
{
    /// <summary>
    /// This represents the extensions entity for the <see cref="DbSet{TEntity}"/> class.
    /// </summary>
    public static class DbSetExtensions
    {
        /// <summary>
        /// Updates the entity in the given DB Set.
        /// </summary>
        /// <typeparam name="TEntity">Type of the entity.</typeparam>
        /// <param name="dbSet"><see cref="DbSet{TEntity}"/> instance.</param>
        /// <param name="entity">Entity to update.</param>
        /// <returns>The <see cref="Task"/></returns>
        public static async Task UpdateAsync<TEntity>(this DbSet<TEntity> dbSet, TEntity entity) where TEntity : class
        {
            if (dbSet == null)
            {
                throw new ArgumentNullException(nameof(dbSet));
            }

            await Task.Factory.StartNew(() => dbSet.Update(entity)).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the list of entities in the given DB Set.
        /// </summary>
        /// <typeparam name="TEntity">Type of the entity.</typeparam>
        /// <param name="dbSet"><see cref="DbSet{TEntity}"/> instance.</param>
        /// <param name="entities">List of entities to update.</param>
        /// <returns>The <see cref="Task"/></returns>
        public static async Task UpdateRangeAsync<TEntity>(this DbSet<TEntity> dbSet, IEnumerable<TEntity> entities) where TEntity : class
        {
            if (dbSet == null)
            {
                throw new ArgumentNullException(nameof(dbSet));
            }

            await Task.Factory.StartNew(() => dbSet.UpdateRange(entities)).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the entity from the given DB Set.
        /// </summary>
        /// <typeparam name="TEntity">Type of the entity.</typeparam>
        /// <param name="dbSet"><see cref="DbSet{TEntity}"/> instance.</param>
        /// <param name="entity">Entity to delete.</param>
        /// <returns>The <see cref="Task"/></returns>
        public static async Task DeleteAsync<TEntity>(this DbSet<TEntity> dbSet, TEntity entity) where TEntity : class
        {
            if (dbSet == null)
            {
                throw new ArgumentNullException(nameof(dbSet));
            }

            await Task.Factory.StartNew(() => dbSet.Remove(entity)).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the list of entities from the given DB Set.
        /// </summary>
        /// <typeparam name="TEntity">Type of the entity.</typeparam>
        /// <param name="dbSet"><see cref="DbSet{TEntity}"/> instance.</param>
        /// <param name="entities">List of entities to delete.</param>
        /// <returns>The <see cref="Task"/></returns>
        public static async Task DeleteRangeAsync<TEntity>(this DbSet<TEntity> dbSet, IEnumerable<TEntity> entities) where TEntity : class
        {
            if (dbSet == null)
            {
                throw new ArgumentNullException(nameof(dbSet));
            }

            await Task.Factory.StartNew(() => dbSet.RemoveRange(entities)).ConfigureAwait(false);
        }
    }
}