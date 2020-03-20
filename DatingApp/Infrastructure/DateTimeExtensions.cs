using System;

namespace DatingApp.Infrastructure
{
    public static class DateTimeExtensions
    {
        public static int CountYears(this DateTime date)
        {
            var today = DateTime.Today;
            int diff = today.Year - date.Year;
            if (date.Date > today.AddYears(-diff))
            {
                diff--;
            }
            return diff;
        }
    }
}
