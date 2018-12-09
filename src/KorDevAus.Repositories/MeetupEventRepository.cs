using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="MeetupEvent"/>.
    /// </summary>
    public class MeetupEventRepository : BaseRepository<MeetupEvent>, IMeetupEventRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetupEventRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public MeetupEventRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}