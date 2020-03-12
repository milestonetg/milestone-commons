using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MilestoneTG
{
    /// <summary>
    /// EncodingType
    /// </summary>
	[Obsolete("This enum is redundent and will be removed in a future release.")]
    public enum EncodingType 
	{ 
	    ASCII, 
	    Unicode, 
	    UTF7, 
	    UTF8,
		UTF32
	} 
	
    /// <summary>
    /// Provides Extension methods to the System.String class
    /// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Returns the string as a byte array using the default code page of the current system. On .Net Core, 
        /// this is always UTF8.
		/// </summary>
		/// <returns>
		/// The bytes.
		/// </returns>
        public static byte[] GetBytes(this String @this)
		{
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

			return System.Text.Encoding.Default.GetBytes(@this);
		}

        /// <summary>
        /// Returns the string as a byte array using UTF8 Encoding.
        /// </summary>
        /// <returns>
        /// The bytes.
        /// </returns>
        public static byte[] GetUtf8Bytes(this String @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return System.Text.Encoding.UTF8.GetBytes(@this);
        }

        /// <summary>
        /// Returns the string as a byte array using the specified MilestoneTG.EncodingType
        /// </summary>
        /// <returns>
        /// The bytes.
        /// </returns>
        /// <param name="this"></param>
        /// <param name='encodingType'>
        /// Encoding type.
        /// </param>
        [Obsolete("Use the GetBytes(Encoding) extension method instead.")]
        public static byte[] GetBytes(this String @this, EncodingType encodingType)
		{
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

			byte[] buffer = null;

			switch(encodingType)
			{
				case EncodingType.ASCII:
					buffer = System.Text.Encoding.ASCII.GetBytes(@this);
					break;
					
				case EncodingType.Unicode:
					buffer = System.Text.Encoding.Unicode.GetBytes(@this);
					break;
					
				case EncodingType.UTF7:
					buffer = System.Text.Encoding.UTF7.GetBytes(@this);
					break;
					
				case EncodingType.UTF8:
					buffer = System.Text.Encoding.UTF8.GetBytes(@this);
					break;
					
				case EncodingType.UTF32:
					buffer = System.Text.Encoding.UTF32.GetBytes(@this);
					break;
			}
			
			return buffer;
		}

        /// <summary>
        /// Checks if all letter characters are uppercase
        /// </summary>
        /// <param name="this">String to check</param>
        /// <returns>True if the entire string us upper case, otherwise, False</returns>
        public static bool IsUpperCase(this string @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return @this.Where(Char.IsLetter).All(c => char.IsUpper(c));
        }

        /// <summary>
        /// Instantiates the respective encoding object
        /// </summary>
        /// <param name="encodingType">Type of encoding</param>
        /// <returns>Encoding object</returns>
        public static Encoding GetEncoding(this EncodingType encodingType)
        {
            Encoding encoding = null;
            switch (encodingType)
            {
                case EncodingType.ASCII:
                    encoding = new ASCIIEncoding();
                    break;
                case EncodingType.UTF32:
                    encoding = new UTF32Encoding();
                    break;
                case EncodingType.UTF7:
                    encoding = new UTF7Encoding();
                    break;
                case EncodingType.UTF8:
                    encoding = new UTF8Encoding();
                    break;
                case EncodingType.Unicode:
                    encoding = new UnicodeEncoding();
                    break;
            }
            return encoding;
        }

        /// <summary>
        /// Removes the last occurance of the value specific from the string and returns resulting string
        /// </summary>
        /// <param name="this">String for which to remove value from</param>
        /// <param name="value">Value to be removed</param>
        /// <returns>Resulting string</returns>
        public static string RemoveLast(this string @this, string value)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (value == null)
	            throw new ArgumentNullException(nameof(value));
            
            return @this.Remove(@this.LastIndexOf(value, StringComparison.Ordinal), value.Length);
        }

        /// <summary>
        /// Converts each word in the string to Proper case.
        /// </summary>
        /// <param name="value">The string to convert</param>
        /// <returns>A <see cref="System.String"/> with each word converted to Proper case.</returns>
        public static String ToTitleCase(this string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                return value;

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        /// <summary>
        /// Capitalizes the first word of every sentence in the string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String ToSentenceCase(this string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                return value;

            char[] ca = value.ToCharArray();

            bool firstLetterFound = false;
            for (int i = 0; i < ca.Length; i++)
            {
                if (Char.IsUpper(ca[i]))
                    firstLetterFound = true;

                if (Char.IsLower(ca[i]) && !firstLetterFound)
                {
                    firstLetterFound = true;

                    ca[i] = Char.ToUpper(ca[i], CultureInfo.InvariantCulture);
                }

                if (".!?".Contains(ca[i]))
                {
                    firstLetterFound = false;
                }
            }

            return new String(ca);
        }
	}//end class
}//end namespace

