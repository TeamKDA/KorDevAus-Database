namespace KorDevAus.Entities
{
    /// <summary>
    /// This specifies the state of Australia.
    /// </summary>
    public class StateType : EnumType
    {
        /// <summary>
        /// Identifies Australian Capital Territory..
        /// </summary>
        public static StateType ACT { get; } = new StateType("ACT", 1);

        /// <summary>
        /// Identifies New South Wales.
        /// </summary>
        public static StateType NSW { get; } = new StateType("NSW", 2);

        /// <summary>
        /// Identifies Northern Territory.
        /// </summary>
        public static StateType NT { get; } = new StateType("NT", 3);

        /// <summary>
        /// Identifies Queensland.
        /// </summary>
        public static StateType QLD { get; } = new StateType("QLD", 4);

        /// <summary>
        /// Identifies South Australia.
        /// </summary>
        public static StateType SA { get; } = new StateType("SA", 5);

        /// <summary>
        /// Identifies Tasmania.
        /// </summary>
        public static StateType TAS { get; } = new StateType("TAS", 6);

        /// <summary>
        /// Identifies Victoria.
        /// </summary>
        public static StateType VIC { get; } = new StateType("VIC", 7);

        /// <summary>
        /// Identifies Western Australia.
        /// </summary>
        public static StateType WA { get; } = new StateType("WA", 8);

        /// <summary>
        /// Initializes a new instance of the <see cref="StateType"/> class.
        /// </summary>
        /// <param name="name">Enum name.</param>
        /// <param name="value">Enum value.</param>
        public StateType(string name, int value)
            : base(name, value)
        {
        }

        /// <summary>
        /// Overrides the <see cref="string"/> operator.
        /// </summary>
        /// <param name="instance"><see cref="StateType"/> instance.</param>
        public static implicit operator string(StateType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Overrides the <see cref="int"/> operator.
        /// </summary>
        /// <param name="instance"><see cref="StateType"/> instance.</param>
        public static implicit operator int(StateType instance)
        {
            return instance.Value;
        }
    }
}
