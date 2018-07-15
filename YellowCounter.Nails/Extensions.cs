using System.Collections;

namespace YellowCounter.Nails
{
    public static class Extensions
    {
        /// <summary>
        /// Determines whether this instance is null.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull(this object value) => value == null;

        /// <summary>
        /// Determines whether this collection is empty.
        /// </summary>
        /// <param name="collection">The collection.</param>
        /// <returns>
        ///   <c>true</c> if the specified collection is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty(this ICollection collection) => collection.Count == 0;

        /// <summary>
        /// Determines whether this string is empty.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty(this string value) => value.Length == 0;

        /// <summary>
        /// Determines whether this instance is null, empty, whitespace or false.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is null, empty, whitespace or false; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBlank(this object value)
        {
            switch (value)
            {
                case ICollection collection:
                    return collection.IsEmpty();
                case string str:
                    return string.IsNullOrWhiteSpace(str);
                case bool boolean:
                    return !boolean;
            }

            return value.IsNull();
        }

        /// <summary>
        /// Determines whether this instance is present. The opposite of <see cref="IsBlank(object)"/>. 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is present; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPresent(this object value) => !value.IsBlank();
    }
}
