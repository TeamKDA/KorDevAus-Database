using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="Event"/>.
    /// </summary>
    public class EventConfiguration : BaseEntityConfiguration<Event>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Event> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasMaxLength(128);
            builder.Property(p => p.Description).HasColumnName("Description").IsRequired(false);
            builder.Property(p => p.IsPublic).HasColumnName("IsPublic").IsRequired().HasDefaultValue(true);
            builder.Property(p => p.MaxAttendees).HasColumnName("MaxAttendees").IsRequired();
            builder.Property(p => p.CampaignId).HasColumnName("CampaignId").IsRequired(false);
            builder.Property(p => p.VenueId).HasColumnName("VenueId").IsRequired(false);

            // Table
            builder.ToTable("Event");

            // Relations
            builder.HasOne(p => p.Venue)
                   .WithMany(p => p.Events)
                   .HasForeignKey(p => p.VenueId);
        }
    }
}