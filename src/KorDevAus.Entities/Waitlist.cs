using System;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the waitlist entity.
    /// </summary>
    public class Waitlist : BaseEntity
    {
        /// <summary>
        /// Gets or sets the event ID.
        /// </summary>
        public virtual Guid EventId { get; set; }

        /// <summary>
        /// Gets or sets the member ID.
        /// </summary>
        public virtual Guid MemberId { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the waitlisted member has been shortlisted or not.
        /// </summary>
        public virtual bool IsShortlisted { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Event"/> instance.
        /// </summary>
        public virtual Event Event { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Member"/> instance.
        /// </summary>
        public virtual Member Member { get; set; }
    }
}
