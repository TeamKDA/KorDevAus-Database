using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace KorDevAus.Entities
{
    /// <summary>
    /// This represents the base enum entity.
    /// </summary>
    public abstract class EnumType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumType"/> class.
        /// </summary>
        /// <param name="name">Enum name.</param>
        /// <param name="value">Enum value.</param>
        protected EnumType(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets the enum name.
        /// </summary>
        public virtual string Name { get; }

        /// <summary>
        /// Gets the enum value.
        /// </summary>
        public virtual int Value { get; set; }

        /// <summary>
        /// Gets the list of all enum instances.
        /// </summary>
        /// <typeparam name="T">Type of enum.</typeparam>
        /// <returns>List of enum instances.</returns>
        public static IEnumerable<T> GetAll<T>() where T : EnumType
        {
            var enums = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static)
                                 .Select(p => (T)p.GetValue(null)).OrderBy(p => p.Name);

            return enums;
        }

        /// <summary>
        /// Gets the list of all enum names.
        /// </summary>
        /// <typeparam name="T">Type of enum.</typeparam>
        /// <returns>List of all enum names.</returns>
        public static IEnumerable<string> GetNames<T>() where T : EnumType
        {
            return GetAll<T>().Select(p => p.Name);
        }

        /// <summary>
        /// Gets the list of all enum values.
        /// </summary>
        /// <typeparam name="T">Type of enum.</typeparam>
        /// <returns>List of all enum values.</returns>
        public static IEnumerable<int> GetValues<T>() where T : EnumType
        {
            return GetAll<T>().Select(p => p.Value);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return this.Name;
        }
    }
}
