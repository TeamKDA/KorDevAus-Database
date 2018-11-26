using System.Collections.Generic;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the venue entity.
    /// </summary>
    public class Venue : BaseEntity
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
        /// Gets or sets the address line #1.
        /// </summary>
        public virtual string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address line #2.
        /// </summary>
        public virtual string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the suburb.
        /// </summary>
        public virtual string Suburb { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public virtual string State { get; set; }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        public virtual string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public virtual string Country { get; set; }

        /// <summary>
        /// Gets or sets the list of <see cref="Event"/> instances.
        /// </summary>
        public virtual List<Event> Events { get; set; }
    }
}