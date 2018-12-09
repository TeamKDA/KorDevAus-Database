using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Event"/>.
    /// </summary>
    public class EventRepository : BaseRepository<Event>, IEventRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public EventRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}