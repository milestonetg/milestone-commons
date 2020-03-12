using System;

namespace MilestoneTG
{
    /// <summary>
    /// Default implementation for <see cref="MilestoneTG.ICurrentDateTime" />
    /// </summary>
    /// <seealso cref="MilestoneTG.ICurrentDateTime" />
    public class DefaultCurrentDateTime : ICurrentDateTime
    {
        /// <summary>
        /// Gets the current local date time.
        /// </summary>
        /// <returns>DateTime.</returns>
        public DateTime GetCurrentLocalDateTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// Gets the current UTC date time.
        /// </summary>
        /// <returns>DateTime.</returns>
        public DateTime GetCurrentUtcDateTime()
        {
            return DateTime.UtcNow;
        }

        /// <summary>
        /// Gets the current local date time offset.
        /// </summary>
        /// <returns>DateTimeOffset.</returns>
        public DateTimeOffset GetCurrentLocalDateTimeOffset()
        {
            return DateTimeOffset.Now;
        }

        /// <summary>
        /// Gets the current UTC date time offset.
        /// </summary>
        /// <returns>DateTimeOffset.</returns>
        public DateTimeOffset GetCurrentUtcDateTimeOffset()
        {
            return DateTimeOffset.UtcNow;
        }

        /// <summary>
        /// Gets the current date time offset for timezone.
        /// </summary>
        /// <param name="tz">The TimezoneInfo instance.</param>
        /// <returns>DateTimeOffset.</returns>
        public DateTimeOffset GetCurrentDateTimeOffsetForTimezone(TimeZoneInfo tz)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime localNow = TimeZoneInfo.ConvertTimeFromUtc(utcNow, tz);

            return new DateTimeOffset(localNow, tz.GetUtcOffset(localNow));
        }

        /// <summary>
        /// Gets the current date time offset for timezone.
        /// </summary>
        /// <param name="tzId">The timezone identifier.</param>
        /// <returns>DateTimeOffset.</returns>
        public DateTimeOffset GetCurrentDateTimeOffsetForTimezone(String tzId)
        {
            if (string.IsNullOrWhiteSpace(tzId))
                throw new ArgumentException("A timezone id must be provided.", nameof(tzId));

            return GetCurrentDateTimeOffsetForTimezone(TimeZoneInfo.FindSystemTimeZoneById(tzId));
        }
    }
}
