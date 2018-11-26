using System;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the meetup-event entity.
    /// </summary>
    public class MeetupEvent : BaseEntity
    {
        /// <summary>
        /// Gets or sets the meetup ID.
        /// </summary>
        public virtual Guid MeetupId { get; set; }

        /// <summary>
        /// Gets or sets the event ID.
        /// </summary>
        public virtual Guid EventId { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Meetup"/> instance.
        /// </summary>
        public virtual Meetup Meetup { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Event"/> instance.
        /// </summary>
        public virtual Event Event { get; set; }
    }
}
