using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="User"/>.
    /// </summary>
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired().HasMaxLength(128);
            builder.Property(p => p.LastName).HasColumnName("LastName").IsRequired().HasMaxLength(128);
            builder.Property(p => p.DisplayName).HasColumnName("DisplayName").IsRequired();
            builder.Property(p => p.Email).HasColumnName("Email").IsRequired();
            builder.Property(p => p.ProfileImageUrl).HasColumnName("ProfileImageUrl").IsRequired(false);
            builder.Property(p => p.ActiveDirectoryId).HasColumnName("ActiveDirectoryId").IsRequired();
            builder.Property(p => p.MailChimpId).HasColumnName("MailChimpId").IsRequired();

            // Table
            builder.ToTable("User");

            // Relations
        }
    }
}