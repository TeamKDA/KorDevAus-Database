using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="GroupUser"/>.
    /// </summary>
    public class GroupUserRepository : BaseRepository<GroupUser>, IGroupUserRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUserRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public GroupUserRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}