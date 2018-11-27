using KorDevAus.Entities;
using KorDevAus.Orm.Configurations;

using Microsoft.EntityFrameworkCore;

namespace KorDevAus.Orm
{
    /// <summary>
    /// This represents the DB context entity for KorDevAus.
    /// </summary>
    public class KdaDbContext : DbContext, IKdaDbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KdaDbContext"/> class.
        /// </summary>
        /// <param name="options"><see cref="DbContextOptions{KdaDbContext}"/> instance.</param>
        public KdaDbContext(DbContextOptions<KdaDbContext> options)
            : base(options)
        {
        }

        /// <inheritdoc />
        public virtual DbSet<Event> Events { get; set; }

        /// <inheritdoc />
        public virtual DbSet<Group> Groups { get; set; }

        /// <inheritdoc />
        public virtual DbSet<GroupUser> GroupUsers { get; set; }

        /// <inheritdoc />
        public virtual DbSet<Meetup> Meetups { get; set; }

        /// <inheritdoc />
        public virtual DbSet<MeetupEvent> MeetupEvents { get; set; }

        /// <inheritdoc />
        public virtual DbSet<Member> Members { get; set; }

        /// <inheritdoc />
        public virtual DbSet<Rsvp> Rsvps { get; set; }

        /// <inheritdoc />
        public virtual DbSet<User> Users { get; set; }

        /// <inheritdoc />
        public virtual DbSet<Venue> Venues { get; set; }

        /// <inheritdoc />
        public virtual DbSet<Waitlist> Waitlists { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupUserConfiguration());
            modelBuilder.ApplyConfiguration(new MeetupConfiguration());
            modelBuilder.ApplyConfiguration(new MeetupEventConfiguration());
            modelBuilder.ApplyConfiguration(new MemberConfiguration());
            modelBuilder.ApplyConfiguration(new RsvpConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new VenueConfiguration());
            modelBuilder.ApplyConfiguration(new WaitlistConfiguration());
        }
    }
}