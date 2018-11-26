using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="Venue"/>.
    /// </summary>
    public class VenueConfiguration : BaseEntityConfiguration<Venue>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Venue> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasMaxLength(128);
            builder.Property(p => p.Description).HasColumnName("Description").IsRequired(false);
            builder.Property(p => p.Address1).HasColumnName("Address1").IsRequired().HasMaxLength(256);
            builder.Property(p => p.Address2).HasColumnName("Address2").IsRequired(false).HasMaxLength(256);
            builder.Property(p => p.Suburb).HasColumnName("Suburb").IsRequired().HasMaxLength(64);
            builder.Property(p => p.State).HasColumnName("State").IsRequired().HasMaxLength(4);
            builder.Property(p => p.Postcode).HasColumnName("Postcode").IsRequired().HasMaxLength(4);
            builder.Property(p => p.Country).HasColumnName("Country").IsRequired().HasMaxLength(32);

            // Table
            builder.ToTable("Venue");

            // Relations
        }
    }
}