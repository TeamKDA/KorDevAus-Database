using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using KorDevAus.Entities;
using KorDevAus.Orm;
using KorDevAus.Orm.Extensions;

using Microsoft.EntityFrameworkCore;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the base entity for repositories
    /// </summary>
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IKdaDbContext _context;

        private bool _disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{T}"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        protected BaseRepository(IKdaDbContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));

            this.Entities = this._context.Set<T>();
        }

        /// <summary>
        /// Gets the sets of entities.
        /// </summary>
        protected DbSet<T> Entities { get; }

        /// <inheritdoc />
        public virtual async Task<List<T>> GetAllAsync()
        {
            var entities = await this.Entities
                                     .AsNoTracking()
                                     .AsQueryable()
                                     .ToListAsync()
                                     .ConfigureAwait(false);

            return entities;
        }

        /// <inheritdoc />
        public virtual async Task<T> GetAsync(Guid id)
        {
            var entity = await this.Entities
                                   .AsNoTracking()
                                   .SingleOrDefaultAsync(p => p.Id == id)
                                   .ConfigureAwait(false);

            return entity;
        }

        /// <inheritdoc />
        public virtual async Task InsertAsync(T entity, bool commit = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await this.Entities.AddAsync(entity).ConfigureAwait(false);

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task InsertRangeAsync(IEnumerable<T> entities, bool commit = true)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            await this.Entities.AddRangeAsync(entities).ConfigureAwait(false);

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task UpdateAsync(T entity, bool commit = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await this.Entities.UpdateAsync(entity).ConfigureAwait(false);

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task UpdateRangeAsync(IEnumerable<T> entities, bool commit = true)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            await this.Entities.UpdateRangeAsync(entities).ConfigureAwait(false);

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task UpsertAsync(T entity, bool commit = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var item = await this.GetAsync(entity.Id).ConfigureAwait(false);
            if (item == null)
            {
                await this.InsertAsync(entity, commit).ConfigureAwait(false);
            }
            else
            {
                await this.UpdateAsync(entity, commit).ConfigureAwait(false);
            }

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task UpsertRangeAsync(IEnumerable<T> entities, bool commit = true)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            foreach (var entity in entities)
            {
                await this.UpsertAsync(entity, commit: false).ConfigureAwait(false);
            }

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(T entity, bool commit = true)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await this.Entities.DeleteAsync(entity).ConfigureAwait(false);

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <inheritdoc />
        public virtual async Task DeleteRangeAsync(IEnumerable<T> entities, bool commit = true)
        {
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }

            await this.Entities.DeleteRangeAsync(entities).ConfigureAwait(false);

            if (commit)
            {
                await this._context.SaveChangesAsync().ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <param name="disposing">Value indicating whether to disposing unmanaged resources or not.</param>
        protected void Dispose(bool disposing)
        {
            if (this._disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed resources.
            }

            // Dispose unmanaged resources.

            this._disposed = true;
        }
    }
}