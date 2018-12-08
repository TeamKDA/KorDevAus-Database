using KorDevAus.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KorDevAus.Orm.Configurations
{
    /// <summary>
    /// This represents the configuration entity for <see cref="TEntity"/>. This MUST be inherited.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity.</typeparam>
    public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Configures the <see cref="TEntity"/> entity.
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder{TEntity}"/> instance.</param>
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            // Key
            builder.HasKey(p => p.Id);

            // Properties
            builder.Property(p => p.Id).HasColumnName("Id").IsRequired();

            builder.Property(p => p.DateCreated).HasColumnName("DateCreated").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.CreatedBy).HasColumnName("CreatedBy").IsRequired();
            builder.Property(p => p.DateUpdated).HasColumnName("DateUpdated").IsRequired().HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.UpdatedBy).HasColumnName("UpdatedBy").IsRequired();

            // Table

            // Relations
        }
    }
}