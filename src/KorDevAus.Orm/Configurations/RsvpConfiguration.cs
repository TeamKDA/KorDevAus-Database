using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="Rsvp"/>.
    /// </summary>
    public class RsvpConfiguration : BaseEntityConfiguration<Rsvp>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Rsvp> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.EventId).HasColumnName("EventId").IsRequired();
            builder.Property(p => p.MemberId).HasColumnName("MemberId").IsRequired();
            builder.Property(p => p.IsHost).HasColumnName("IsHost").IsRequired().HasDefaultValue(false);
            builder.Property(p => p.Status).HasColumnName("Status").IsRequired();

            // Table
            builder.ToTable("Rsvp");

            // Relations
            builder.HasOne(p => p.Event)
                   .WithMany(p => p.Rsvps)
                   .HasForeignKey(p => p.EventId);
            builder.HasOne(p => p.Member)
                   .WithMany(p => p.Rsvps)
                   .HasForeignKey(p => p.MemberId);
        }
    }
}