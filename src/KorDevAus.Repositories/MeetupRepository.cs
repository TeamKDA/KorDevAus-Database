using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Meetup"/>.
    /// </summary>
    public class MeetupRepository : BaseRepository<Meetup>, IMeetupRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetupRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public MeetupRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}