using System.Collections.Generic;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the group entity for administration purpose.
    /// </summary>
    public class Group : BaseEntity
    {
        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the group description.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="GroupUser"/> instances.
        /// </summary>
        public virtual List<GroupUser> GroupUsers { get; set; }
    }
}
