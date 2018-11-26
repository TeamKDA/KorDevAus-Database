namespace KorDevAus.Entities.Tests.Fixtures
{
    /// <summary>
    /// This specifies the fake enum value.
    /// </summary>
    public class FakeEnumType : EnumType
    {
        /// <summary>
        /// Identifies lorem.
        /// </summary>
        public static FakeEnumType Lorem { get; } = new FakeEnumType("lorem", 1);

        /// <summary>
        /// Identifies ipsum.
        /// </summary>
        public static FakeEnumType Ipsum { get; } = new FakeEnumType("ipsum", 2);

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeEnumType"/> class.
        /// </summary>
        /// <param name="name">Enum name.</param>
        /// <param name="value">Enum value.</param>
        public FakeEnumType(string name, int value)
            : base(name, value)
        {
        }

        /// <summary>
        /// Overrides the <see cref="string"/> operator.
        /// </summary>
        /// <param name="instance"><see cref="FakeEnumType"/> instance.</param>
        public static implicit operator string(FakeEnumType instance)
        {
            return instance.ToString();
        }

        /// <summary>
        /// Overrides the <see cref="int"/> operator.
        /// </summary>
        /// <param name="instance"><see cref="FakeEnumType"/> instance.</param>
        public static implicit operator int(FakeEnumType instance)
        {
            return instance.Value;
        }
    }
}