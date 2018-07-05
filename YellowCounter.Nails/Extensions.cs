using System.Collections;

namespace YellowCounter.Nails
{
    public static class Extensions
    {
        public static bool IsNull(this object value) => value == null;

        public static bool IsEmpty(this ICollection collection) =>collection.Count == 0;

        public static bool IsEmpty(this string value) => value.Length == 0;

        public static bool IsBlank(this object value)
        {
            switch(value)
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

        public static bool IsPresent(this object value) => !value.IsBlank();
    }
}
