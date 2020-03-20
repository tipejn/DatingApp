using DatingApp.Infrastructure;
using System;

namespace DatingApp.Models.Validators
{
    public class AgeValidator : IPersonValidator
    {
        private int maxDiff = 5;
        public bool Matched(Person woman, Person man)
        {
            return Math.Abs(man.BirthDate.CountYears() - woman.BirthDate.CountYears()) <= maxDiff;
        }
    }
}
