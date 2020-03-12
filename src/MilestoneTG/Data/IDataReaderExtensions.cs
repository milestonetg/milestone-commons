using System;
using System.Data;

namespace MilestoneTG.Data
{
    /// <summary>
    /// Extension methods for classes implementing the IDataReader interface
    /// </summary>
	public static class IDataReaderExtensions
    {
	    private static readonly string COLUMN_NAME_REQUIRED = "A column name must be specified.";
		
	    #region IDataRecord implementation

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <example>
        /// <code lang="C#">
        /// SqlDataReader rdr = cmd.ExecuteReader();
        /// 
        /// String customerName = null;
        /// if (rdr.Read())
        /// {
        ///     customerName = rdr.GetString("customer_name");
        /// }
        /// </code>
        /// </example>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static String GetString(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetString(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static bool GetBoolean(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetBoolean(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static byte GetByte(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetByte(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="fieldOffset"></param>
        /// <param name="buffer"></param>
        /// <param name="bufferoffset"></param>
        /// <param name="length"></param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static long GetBytes(this IDataReader rdr, String columnName, long fieldOffset, byte[] buffer, int bufferoffset, int length)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetBytes(rdr.GetOrdinal(columnName), fieldOffset, buffer, bufferoffset, length);
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static char GetChar(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetChar(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="fieldoffset"></param>
        /// <param name="buffer"></param>
        /// <param name="bufferoffset"></param>
        /// <param name="length"></param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static long GetChars(this IDataReader rdr, String columnName, long fieldoffset, char[] buffer, int bufferoffset, int length)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetChars(rdr.GetOrdinal(columnName), fieldoffset, buffer, bufferoffset, length);
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static IDataReader GetData(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetData(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static string GetDataTypeName(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetDataTypeName(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static DateTime GetDateTime(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetDateTime(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static decimal GetDecimal(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetDecimal(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static double GetDouble(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetDouble(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static Type GetFieldType(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetFieldType(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static float GetFloat(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetFloat(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static Guid GetGuid(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetGuid(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static short GetInt16(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetInt16(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static int GetInt32(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetInt32(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Gets the strongly typed value of the column by column name.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The column value.</returns>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column is not of the return type or the value is DbNull.</exception>
        public static long GetInt64(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.GetInt64(rdr.GetOrdinal(columnName));
		}

        /// <summary>
        /// Indicates whether or not the column is DbNull.
        /// </summary>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>true if DbNull, otherwise false</returns>
        public static bool IsDBNull(this IDataReader rdr, String columnName)
		{
			if (rdr == null)
				throw new ArgumentNullException(nameof(rdr));

			if (string.IsNullOrWhiteSpace(columnName))
				throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

			return rdr.IsDBNull(rdr.GetOrdinal(columnName));
		}

		#endregion

        /// <summary>
        /// Gets the value of the specified column.
        /// </summary>
        /// <typeparam name="T">Type for the value.</typeparam>
        /// <param name="rdr">The IDataReader.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <returns>The value of the column as the type specified by the type parameter T.</returns>
        /// <remarks>If the value of the column is DbNull, then the default value for the type is returned.</remarks>
        /// <exception cref="System.InvalidCastException">Throws an InvalidCastException if the value of the column cannot be cast to type T.</exception>
        /// <example>
        /// <code lang="C#">
        /// SqlDataReader rdr = cmd.ExecuteReader();
        /// 
        /// String customerName = null;
        /// if (rdr.Read())
        /// {
        ///     customerName = rdr.GetValue&lt;String&gt;("customer_name");
        /// }
        /// </code>
        /// </example>
        public static T GetValue<T>(this IDataReader rdr, String columnName)
        {
	        if (rdr == null)
		        throw new ArgumentNullException(nameof(rdr));
	        
	        if (string.IsNullOrWhiteSpace(columnName))
		        throw new ArgumentException(COLUMN_NAME_REQUIRED, nameof(columnName));

            object obj = rdr[columnName];
        
            return DataUtil.Convert<T>(obj);
		}


	}//end class
}//end namespace

