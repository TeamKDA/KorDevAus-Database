using System;
using System.Collections.Generic;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the event entity.
    /// </summary>
    public class Event : BaseEntity
    {
        /// <summary>
        /// Gets or sets the venue name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the venue description.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the event is public or not.
        /// </summary>
        public virtual bool IsPublic { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of attendees.
        /// </summary>
        public virtual int MaxAttendees { get; set; }

        /// <summary>
        /// Gets or sets the campaign ID from MailChimp.
        /// </summary>
        public virtual Guid? CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the venue ID.
        /// </summary>
        public virtual Guid? VenueId { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Entities.Venue"/> instance.
        /// </summary>
        public virtual Venue Venue { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="MeetupEvent"/> instances.
        /// </summary>
        public virtual List<MeetupEvent> MeetupEvents { get; set; }

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
