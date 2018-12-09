using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="Waitlist"/>.
    /// </summary>
    public class WaitlistConfiguration : BaseEntityConfiguration<Waitlist>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Waitlist> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.EventId).HasColumnName("EventId").IsRequired();
            builder.Property(p => p.MemberId).HasColumnName("MemberId").IsRequired();
            builder.Property(p => p.IsShortlisted).HasColumnName("IsShortlisted").IsRequired().HasDefaultValue(false);

            // Table
            builder.ToTable("Waitlists");

            // Relations
            builder.HasOne(p => p.Event)
                   .WithMany(p => p.Waitlists)
                   .HasForeignKey(p => p.EventId);
            builder.HasOne(p => p.Member)
                   .WithMany(p => p.Waitlists)
                   .HasForeignKey(p => p.MemberId);
        }
    }
}