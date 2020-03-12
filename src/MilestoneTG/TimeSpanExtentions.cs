using System;

namespace MilestoneTG
{
	/// <exclude />
	public static class DateAndTimeSpanExtentions
	{
		/// <summary>
		/// Gets the total nanoseconds in the TimeSpan.
		/// </summary>
		/// <param name="this">The timeSpan.</param>
		/// <returns>System.Double.</returns>
		public static double GetTotalNanoseconds(this TimeSpan @this)
		{
			if (@this == null)
				throw new ArgumentNullException(nameof(@this));

			return (double)@this.Ticks / 100.0;
		}

		/// <summary>
		/// Gets the current time millis.
		/// </summary>
		/// <param name="this">The DateTime.</param>
		/// <returns>System.Int64.</returns>
		public static long GetCurrentTimeMillis(this DateTime @this)
		{
			if (@this == null)
				throw new ArgumentNullException(nameof(@this));
			
			return @this.Ticks / 10000;
		}
	}
}

