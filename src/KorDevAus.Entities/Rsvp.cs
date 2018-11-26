using System;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the RSVP entity.
    /// </summary>
    public class Rsvp : BaseEntity
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
        /// Gets or sets the value indicating whether the RSVP'd member is a host or not.
        /// </summary>
        public virtual bool IsHost { get; set; }

        /// <summary>
        /// Gets or sets the RSVP status - Going, Not Sure, Not Going.
        /// </summary>
        public virtual string Status { get; set; }

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
