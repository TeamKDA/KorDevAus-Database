using KorDevAus.Entities;
using KorDevAus.Orm;

namespace KorDevAus.Repositories
{
    /// <summary>
    /// This represents the repository entity for the <see cref="Waitlist"/>.
    /// </summary>
    public class WaitlistRepository : BaseRepository<Waitlist>, IWaitlistRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitlistRepository"/> class.
        /// </summary>
        /// <param name="context"><see cref="IKdaDbContext"/> instance.</param>
        public WaitlistRepository(IKdaDbContext context)
            : base(context)
        {
        }
    }
}