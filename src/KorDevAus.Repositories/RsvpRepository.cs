using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Rsvp"/>.
    /// </summary>
    public class RsvpRepository : BaseRepository<Rsvp>, IRsvpRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RsvpRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public RsvpRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}