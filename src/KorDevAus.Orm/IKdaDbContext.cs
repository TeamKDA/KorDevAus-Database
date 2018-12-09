using System;
using System.Threading;
using System.Threading.Tasks;

using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;

namespace KorDevAus.Orm
{
    /// <summary>
    /// This provides interfaces to the <see cref="KdaDbContext"/> class.
    /// </summary>
    public interface IKdaDbContext : IDisposable
    {
        /// <summary>
        /// Gets or sets the set of <see cref="Event"/> records.
        /// </summary>
        DbSet<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="Group"/> records.
        /// </summary>
        DbSet<Group> Groups { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="GroupUser"/> records.
        /// </summary>
        DbSet<GroupUser> GroupUsers { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="Meetup"/> records.
        /// </summary>
        DbSet<Meetup> Meetups { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="MeetupEvent"/> records.
        /// </summary>
        DbSet<MeetupEvent> MeetupEvents { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="Member"/> records.
        /// </summary>
        DbSet<Member> Members { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="Rsvp"/> records.
        /// </summary>
        DbSet<Rsvp> Rsvps { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="User"/> records.
        /// </summary>
        DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="Venue"/> records.
        /// </summary>
        DbSet<Venue> Venues { get; set; }

        /// <summary>
        /// Gets or sets the set of <see cref="Waitlist"/> records.
        /// </summary>
        DbSet<Waitlist> Waitlists { get; set; }

        /// <summary>
        /// Creates <see cref="DbSet{TEntity}"/> that can be used to query and save instances of TEntity.
        /// </summary>
        /// <typeparam name="TEntity">Type of entity.</typeparam>
        /// <returns><see cref="DbSet{TEntity}"/> instance.</returns>
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        /// <summary>
        /// Saves all changes made in this context to the database.
        /// </summary>
        /// <param name="cancellationToken"><see cref="CancellationToken"/> to observe while waiting for the task to complete.</param>
        /// <returns>Result contains the number of state entries written to the database.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}