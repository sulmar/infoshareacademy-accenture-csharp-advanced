namespace ExtensionMethods;

internal class Helper
{
    private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);   
    public static long ToUnixTimestamp(DateTime date)
    {
        TimeSpan timeSinceUnixEpoch = date.ToUniversalTime() - UnixEpoch;
        return (long)timeSinceUnixEpoch.TotalSeconds;
    }

    public static DateTime FromUnixTimestamp(long unixTimestamp)
    {
        return UnixEpoch.AddSeconds(unixTimestamp).ToLocalTime();
    }
}
