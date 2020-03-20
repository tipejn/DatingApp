using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.Infrastructure
{
    public class MustBeAdult : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && DateTime.TryParse(value.ToString(), out DateTime birthDate) && IsAdult(birthDate);
        }

        private bool IsAdult(DateTime birthDate)
        {
            return birthDate.CountYears() >= 18;
        }
    }
}
