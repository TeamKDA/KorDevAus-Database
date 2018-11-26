using System;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the base entity. This MUST be inherited.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity Id.
        /// </summary>
        public virtual Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the date when the record was created.
        /// </summary>
        public virtual DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the user who created the record.
        /// </summary>
        public virtual Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the record was updated.
        /// </summary>
        public virtual DateTimeOffset DateUpdated { get; set; }

        /// <summary>
        /// Gets or sets the user who updated the record.
        /// </summary>
        public virtual Guid UpdatedBy { get; set; }
    }
}
