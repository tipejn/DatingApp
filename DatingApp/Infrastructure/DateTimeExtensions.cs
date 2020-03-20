using System;

namespace DatingApp.Infrastructure
{
    public static class DateTimeExtensions
    {
        public static double CountYears(this DateTime date)
        {
            var today = DateTime.Today;
            int diffYears = today.Year - date.Year;

            double diffDays = 1 / (double)(today.AddYears(-diffYears) - date).Days;

            return diffYears + diffDays;
        }
    }
}
