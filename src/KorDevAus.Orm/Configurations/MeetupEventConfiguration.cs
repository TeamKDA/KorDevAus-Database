using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="MeetupEvent"/>.
    /// </summary>
    public class MeetupEventConfiguration : BaseEntityConfiguration<MeetupEvent>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<MeetupEvent> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.MeetupId).HasColumnName("MeetupId").IsRequired();
            builder.Property(p => p.EventId).HasColumnName("EventId").IsRequired();

            // Table
            builder.ToTable("MeetupEvents");

            // Relations
            builder.HasOne(p => p.Meetup)
                   .WithMany(p => p.MeetupEvents)
                   .HasForeignKey(p => p.MeetupId);
            builder.HasOne(p => p.Event)
                   .WithMany(p => p.MeetupEvents)
                   .HasForeignKey(p => p.EventId);
        }
    }
}