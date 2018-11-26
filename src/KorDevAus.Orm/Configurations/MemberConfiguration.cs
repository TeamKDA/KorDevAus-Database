using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="Member"/>.
    /// </summary>
    public class MemberConfiguration : BaseEntityConfiguration<Member>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Member> builder)
        {
            base.Configure(builder);

            // Properties
            builder.Property(p => p.MeetupId).HasColumnName("MeetupId").IsRequired();
            builder.Property(p => p.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(p => p.IsOrganiser).HasColumnName("IsOrganiser").IsRequired().HasDefaultValue(false);
            builder.Property(p => p.DateJoined).HasColumnName("DateJoined").IsRequired();

            // Table
            builder.ToTable("Member");

            // Relations
            builder.HasOne(p => p.Meetup)
                   .WithMany(p => p.Members)
                   .HasForeignKey(p => p.MeetupId);
            builder.HasOne(p => p.User)
                   .WithMany(p => p.Members)
                   .HasForeignKey(p => p.UserId);
        }
    }
}