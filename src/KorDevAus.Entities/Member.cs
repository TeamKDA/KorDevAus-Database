using System;
using System.Collections.Generic;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the member entity.
    /// </summary>
    public class Member : BaseEntity
    {
        /// <summary>
        /// Gets or sets the meetup ID.
        /// </summary>
        public virtual Guid MeetupId { get; set; }

        /// <summary>
        /// Gets or sets the user ID.
        /// </summary>
        public virtual Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the member is an organiser of the meetup or not.
        /// </summary>
        public virtual bool IsOrganiser { get; set; }

        /// <summary>
        /// Gets or sets the date when the user joined the meetup.
        /// </summary>
        public virtual DateTimeOffset DateJoined { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Meetup"/> instance.
        /// </summary>
        public virtual Meetup Meetup { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.User"/> instance.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="Rsvp"/> instances.
        /// </summary>
        public virtual List<Rsvp> Rsvps { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="Waitlist"/> instances.
        /// </summary>
        public virtual List<Waitlist> Waitlists { get; set; }
    }
}
