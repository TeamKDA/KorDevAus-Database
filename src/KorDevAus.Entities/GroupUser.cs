using System;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the group-user entity.
    /// </summary>
    public class GroupUser : BaseEntity
    {
        /// <summary>
        /// Gets or sets the group ID.
        /// </summary>
        public virtual Guid GroupId { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the date when the user joined the group.
        /// </summary>
        public virtual DateTimeOffset DateJoined { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Group"/> instance.
        /// </summary>
        public virtual Group Group { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.User"/> instance.
        /// </summary>
        public virtual User User { get; set; }
    }
}
