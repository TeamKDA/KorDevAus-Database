using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="GroupUser"/>.
    /// </summary>
    public class GroupUserConfiguration : BaseEntityConfiguration<GroupUser>
    {
        /// <summary>
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<GroupUser> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.GroupId).HasColumnName("GroupId").IsRequired();
            builder.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(p => p.DateJoined).HasColumnName("DateJoined").IsRequired().HasDefaultValueSql("GETDATE()");

            // Table
            builder.ToTable("GroupUsers");

            // Relations
            builder.HasOne(p => p.Group)
                   .WithMany(p => p.GroupUsers)
                   .HasForeignKey(p => p.GroupId);
            builder.HasOne(p => p.User)
                   .WithMany(p => p.GroupUsers)
                   .HasForeignKey(p => p.UserId);
        }
    }
}