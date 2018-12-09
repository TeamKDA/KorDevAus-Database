using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Group"/>.
    /// </summary>
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public GroupRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}