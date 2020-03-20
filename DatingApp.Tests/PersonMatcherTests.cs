using DatingApp.Models;
using DatingApp.Models.Validators;
using System;
using System.Collections.Generic;
using Xunit;

namespace DatingApp.Tests
{
    public class PersonMatcherTests
    {
        [Fact]
        public void CanMatch()
        {
            Person w1 = new Person
            {
                BirthDate = new DateTime(1990, 1, 1),
                EyesColor = EyesColor.Blue,
                Height = 160
            };

            Person m1 = new Person
            {
                BirthDate = new DateTime(1993, 1, 1),
                EyesColor = EyesColor.Blue,
                Height = 169
            };

            Person w2 = new Person
            {
                BirthDate = new DateTime(1990, 1, 1),
                EyesColor = EyesColor.Blue,
                Height = 160
            };

            Person m2 = new Person
            {
                BirthDate = new DateTime(1996, 1, 1),
                EyesColor = EyesColor.Green,
                Height = 171
            };

            var validators = new List<IPersonValidator> { new AgeValidator(), new HeightValidator(), new EyesColorValidator() };

            PersonMatcher matcher1 = new PersonMatcher(validators) { Woman = w1, Man = m1 };
            PersonMatcher matcher2 = new PersonMatcher(validators) { Woman = w2, Man = m2 };

            Assert.True(matcher1.Matched());
            Assert.False(matcher2.Matched());
        }
    }
}
