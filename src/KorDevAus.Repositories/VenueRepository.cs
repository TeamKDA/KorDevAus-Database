using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Venue"/>.
    /// </summary>
    public class VenueRepository : BaseRepository<Venue>, IVenueRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VenueRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public VenueRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}