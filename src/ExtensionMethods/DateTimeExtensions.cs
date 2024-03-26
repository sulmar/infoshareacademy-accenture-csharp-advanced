namespace ExtensionMethods;

internal static class DateTimeExtensions
{
    private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    public static long ToUnixTimestamp(this DateTime date)
    {
        TimeSpan timeSinceUnixEpoch = date.ToUniversalTime() - UnixEpoch;
        return (long)timeSinceUnixEpoch.TotalSeconds;
    }

    public static DateTime FromUnixTimestamp(this long unixTimestamp)
    {
        return UnixEpoch.AddSeconds(unixTimestamp).ToLocalTime();
    }
}

