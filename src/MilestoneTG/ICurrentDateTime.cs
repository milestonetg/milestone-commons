using System;

namespace MilestoneTG
{
    /// <summary>
    /// Abstracts the fetching of the current system date/time (eg. DateTime.Now) to facilitate unit testing logic
    /// involving System.DateTime and System.DateTimeOffset.
    /// </summary>
    public interface ICurrentDateTime
    {
        /// <summary>
        /// Gets the current local date time.
        /// </summary>
        /// <returns>DateTime.</returns>
        DateTime GetCurrentLocalDateTime();

        /// <summary>
        /// Gets the current UTC date time.
        /// </summary>
        /// <returns>DateTime.</returns>
        DateTime GetCurrentUtcDateTime();

        /// <summary>
        /// Gets the current local date time offset.
        /// </summary>
        /// <returns>DateTimeOffset.</returns>
        DateTimeOffset GetCurrentLocalDateTimeOffset();

        /// <summary>
        /// Gets the current UTC date time offset.
        /// </summary>
        /// <returns>DateTimeOffset.</returns>
        DateTimeOffset GetCurrentUtcDateTimeOffset();

        /// <summary>
        /// Gets the current date time offset for timezone.
        /// </summary>
        /// <param name="tz">A TimeZoneInfo instance.</param>
        /// <returns>DateTimeOffset.</returns>
        DateTimeOffset GetCurrentDateTimeOffsetForTimezone(TimeZoneInfo tz);

        /// <summary>
        /// Gets the current date time offset for timezone.
        /// </summary>
        /// <param name="tzId">The timezone identifier.</param>
        /// <returns>DateTimeOffset.</returns>
        DateTimeOffset GetCurrentDateTimeOffsetForTimezone(String tzId);
    }
}
