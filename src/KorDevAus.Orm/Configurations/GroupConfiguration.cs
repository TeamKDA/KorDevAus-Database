using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="Group"/>.
    /// </summary>
    public class GroupConfiguration : BaseEntityConfiguration<Group>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasMaxLength(128);
            builder.Property(p => p.Description).HasColumnName("Description").IsRequired(false);

            // Table
            builder.ToTable("Group");

            // Relations
        }
    }
}