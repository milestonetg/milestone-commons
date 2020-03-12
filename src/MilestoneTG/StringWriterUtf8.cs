using System.IO;
using System.Text;

namespace MilestoneTG
{
    /// <summary>
    /// Class StringWriterUtf8.
    /// Implements the <see cref="System.IO.StringWriter" />
    /// </summary>
    /// <seealso cref="System.IO.StringWriter" />
    public class StringWriterUtf8 : StringWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriterUtf8"/> class.
        /// </summary>
        /// <param name="sb">The <see cref="T:System.Text.StringBuilder"></see> object to write to.</param>
        public StringWriterUtf8(StringBuilder sb) : base(sb)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StringWriterUtf8"/> class.
        /// </summary>
        public StringWriterUtf8() : base()
        {
        }

        /// <summary>
        /// Gets the <see cref="T:System.Text.Encoding"></see> in which the output is written.
        /// </summary>
        /// <value>The encoding.</value>
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
