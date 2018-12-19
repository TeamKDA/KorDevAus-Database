using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using KorDevAus.Entities;
using KorDevAus.Orm;

using Microsoft.EntityFrameworkCore;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="User"/>.
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public UserRepository(IKdaDbContext context)
            : base(context)
        {
        }

        /// <inheritdoc />
        public override async Task<List<User>> GetAllAsync()
        {
            var users = await this.Entities
                                  .AsNoTracking()
                                  .Include(p => p.GroupUsers)
                                      .ThenInclude(p => p.Group)
                                  .AsQueryable()
                                  .ToListAsync()
                                  .ConfigureAwait(false);

            return users;
        }

        /// <inheritdoc />
        public override async Task<User> GetAsync(Guid id)
        {
            var user = await this.Entities
                                 .AsNoTracking()
                                 .Include(p => p.GroupUsers)
                                     .ThenInclude(p => p.Group)
                                 .SingleOrDefaultAsync(p => p.Id == id)
                                 .ConfigureAwait(false);

            return user;
        }

        /// <inheritdoc />
        public async Task<User> GetByEmailAsync(string email)
        {
            var user = await this.Entities
                                 .AsNoTracking()
                                 .Include(p => p.GroupUsers)
                                     .ThenInclude(p => p.Group)
                                 .SingleOrDefaultAsync(p => p.Email.Equals(email, StringComparison.CurrentCultureIgnoreCase))
                                 .ConfigureAwait(false);

            return user;
        }
    }
}