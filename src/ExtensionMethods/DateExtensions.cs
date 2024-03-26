
namespace Accenture
{
    internal static class DateExtensions
    {
        public static string ToString(this DateTime date)
        {
            return "Foo";
        }

        public static bool IsHoliday(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}