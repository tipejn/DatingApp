using System;

namespace DatingApp.Infrastructure
{
    public static class DateTimeExtensions
    {
        public static double CountYears(this DateTime date)
        {
            var today = DateTime.Today;
            int diffYears = today.Year - date.Year;
            double diffDays = (today.AddYears(-diffYears) - date).Days;

            if (diffDays != 0)
            {
                return diffYears + 1 / diffDays;
            }

            return diffYears;
        }
    }
}
