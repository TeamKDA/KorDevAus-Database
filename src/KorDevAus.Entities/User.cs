using System;
using System.Collections.Generic;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the user entity.
    /// </summary>
    public class User : BaseEntity
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public virtual string LastName { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public virtual string Email { get; set; }

        /// <summary>
        /// Gets or sets the profile image URL.
        /// </summary>
        public virtual string ProfileImageUrl { get; set; }
        /// <summary>
        /// Gets or sets the ID from Azure Active Directory B2C.
        /// </summary>
        public virtual Guid ActiveDirectoryId { get; set; }

        /// <summary>
        /// Gets or sets the ID from MailChimp.
        /// </summary>
        public virtual Guid MailChimpId { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="Member"/> instances.
        /// </summary>
        public virtual List<Member> Members { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="GroupUser"/> instances.
        /// </summary>
        public virtual List<GroupUser> GroupUsers { get; set; }
    }
}
