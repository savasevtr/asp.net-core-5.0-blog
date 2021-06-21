using System;

namespace ProgrammersBlog.Shared.Utilities.Extensions
{
    public static class DateTimeExtensions
    {
        public static string FullDateAndTimeStringWithUnserscore(this DateTime dateTime)
        {
            return $"{dateTime.Millisecond}_{dateTime.Second}_{dateTime.Minute}_{dateTime.Hour}_{dateTime.Day}_{dateTime.Month}_{dateTime.Year}";
        }
    }
}
