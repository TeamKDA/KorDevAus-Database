using System.Collections.Generic;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the meetup entity.
    /// </summary>
    public class Meetup : BaseEntity
    {
        /// <summary>
        /// Gets or sets the meetup name.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the meetup description.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        public virtual string Slug { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="Member"/> instances.
        /// </summary>
        public virtual List<Member> Members { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="MeetupEvent"/> instances.
        /// </summary>
        public virtual List<MeetupEvent> MeetupEvents { get; set; }
    }
}
