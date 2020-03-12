using System.Globalization;
using System.Linq;

namespace MilestoneTG.Data
{
    /// <summary>
    /// Assorted Data Utilities
    /// </summary>
    public static class DataUtil
    {
        /// <summary>
        /// Converts the specified object to type T in a null-safe manner.
        /// </summary>
        /// <typeparam name="T">The type to convert to.</typeparam>
        /// <param name="objToConvert">The object instance to convert.</param>
        /// <returns>The converted instance. Returns default if objToConvert is null.</returns>
        /// <remarks>
        /// If objToConvert is an instance of DbNull, then default(T) is returned.
        /// </remarks>
        public static T Convert<T>(object objToConvert)
        {
            if (objToConvert == null || System.Convert.IsDBNull(objToConvert))
                return default(T);

            // Special-case boolean to try an parse other boolean-context values (ie. Y or N)
            if (typeof(T) == typeof(bool))
            {
                if (TryParseBool(objToConvert.ToString(), out bool boolValue))
                {
                    return (T)System.Convert.ChangeType(boolValue, typeof(T), CultureInfo.InvariantCulture);
                }
            }

            return (T)System.Convert.ChangeType(objToConvert, typeof(T), CultureInfo.InvariantCulture);
        }

        private static readonly string[] TRUE_VALUES = new[] { "1", "Y", "YES", "T" };
        private static readonly string[] FALSE_VALUES = new[] { "0", "N", "NO", "F" };

        /// <summary>
        /// Tries the parse the string to a boolean.
        /// boolValue will be True if the string is "1", "Y", "YES", "T", or "TRUE".
        /// boolValue will be False if the string is "0", "N", "NO", "F", or "FALSE".
        /// The comparison is case-insensitive and culture invariant.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="boolValue">The parsed boolean value.</param>
        /// <returns><c>true</c> if successful, <c>false</c> otherwise.</returns>
        public static bool TryParseBool(string value, out bool boolValue)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                boolValue = false;
                return false;
            }

            string cleanValue = value.Trim().ToUpper(CultureInfo.InvariantCulture);
            if (bool.TryParse(cleanValue, out boolValue))
            {
                return true;
            }
            else if (TRUE_VALUES.Contains(cleanValue))
            {
                boolValue = true;
                return true;
            }
            else if (FALSE_VALUES.Contains(cleanValue))
            {
                boolValue = false;
                return true;
            }

            return false;
        }
    }
}
