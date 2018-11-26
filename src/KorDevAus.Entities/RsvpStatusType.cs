namespace KorDevAus.Entities
{
    /// <summary>
    /// This specifies the RSVP status.
    /// </summary>
    public class RsvpStatusType : EnumType
    {
        /// <summary>
        /// Identifies "Going".
        /// </summary>
        public static RsvpStatusType Going { get; } = new RsvpStatusType("Going", 1);

        /// <summary>
        /// Identifies "Not Sure".
        /// </summary>
        public static RsvpStatusType NotSure { get; } = new RsvpStatusType("Not Sure", 0);

        /// <summary>
        /// Identifies "Not Going"
        /// </summary>
        public static RsvpStatusType NotGoing { get; } = new RsvpStatusType("Not Going", -1);

        /// <summary>
        /// Initializes a new instance of the <see cref="RsvpStatusType"/> class.
        /// </summary>
        /// <param name="name">Enum name.</param>
        /// <param name="value">Enum value.</param>
        public RsvpStatusType(string name, int value)
            : base(name, value)
        {
        }

        /// <summary>
        /// Overrides the <see cref="string"/> operator.
        /// </summary>
        /// <param name="instance"><see cref="RsvpStatusType"/> instance.</param>
        public static implicit operator string(RsvpStatusType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Overrides the <see cref="int"/> operator.
        /// </summary>
        /// <param name="instance"><see cref="RsvpStatusType"/> instance.</param>
        public static implicit operator int(RsvpStatusType instance)
        {
            return instance.Value;
        }
    }
}
