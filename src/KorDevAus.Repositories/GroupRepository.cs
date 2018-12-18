using System;
using System.Threading.Tasks;

using KorDevAus.Entities;
using KorDevAus.Orm;

using Microsoft.EntityFrameworkCore;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Group"/>.
    /// </summary>
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public GroupRepository(IKdaDbContext context)
            : base(context)
        {
        }

        /// <inheritdoc />
        public async Task<Group> GetByNameAsync(string name)
        {
            var user = await this.Entities
                                 .AsNoTracking()
                                 .SingleOrDefaultAsync(p => p.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                                 .ConfigureAwait(false);

            return user;
        }
    }
}