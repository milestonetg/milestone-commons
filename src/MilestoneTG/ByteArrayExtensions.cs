using System;
using System.Text;

namespace MilestoneTG
{
    /// <summary>
    /// Extension methods for byte arrays.
    /// </summary>
    public static class ByteArrayExtensions
    {
        /// <summary>
        /// Decodes all of the bytes in the array to a string using the UTF8 encoding.
        /// </summary>
        /// <param name="this">The buffer.</param>
        /// <returns>The decoded string</returns>
        public static string GetUtf8String(this byte[] @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return Encoding.UTF8.GetString(@this);
        }

        /// <summary>
        /// Decodes all of the bytes in the array to a string using the specified encoding.
        /// </summary>
        /// <param name="this">The buffer.</param>
        /// <param name="encoding">The encoding used to decode the byte array.</param>
        /// <returns>The decoded string.</returns>
        public static string GetString(this byte[] @this, Encoding encoding)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (encoding == null)
                throw new ArgumentNullException(nameof(encoding));

            return encoding.GetString(@this);
        }

        /// <summary>
        /// Decodes all of the bytes in the array to a string using the default code page of the current system. 
        /// On .Net Core, this is always UTF8.
        /// </summary>
        /// <param name="@this'">The buffer.</param>
        /// <param name="this"></param>
        /// <returns>The decoded string.</returns>
        public static string GetString(this byte[] @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return Encoding.Default.GetString(@this);
        }
    }
}
