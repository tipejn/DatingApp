using DatingApp.Models;
using DatingApp.Models.Validators;
using System;
using Xunit;

namespace DatingApp.Tests
{
    public class PersonValidatorTests
    {

        [Fact]
        public void CanValidateAgeDiff()
        {
            Person w1 = new Person { BirthDate = new DateTime(2000, 1, 1) };
            Person m1 = new Person { BirthDate = new DateTime(2000, 1, 1) };
            Person w2 = new Person { BirthDate = new DateTime(2000, 1, 1) };
            Person m2 = new Person { BirthDate = new DateTime(1994, 12, 31) };

            AgeValidator validator = new AgeValidator();

            Assert.True(validator.Matched(w1, m1));
            Assert.False(validator.Matched(w2, m2));
        }

        [Fact]
        public void CanValidateHeight()
        {
            Person w1 = new Person { Height = 1.6 };
            Person m1 = new Person { Height = 1.69 };
            Person w2 = new Person { Height = 1.60 };
            Person m2 = new Person { Height = 1.71 };

            HeightValidator validator = new HeightValidator();

            Assert.False(validator.Matched(w1, m1));
            Assert.True(validator.Matched(w2, m2));
        }

        [Fact]
        public void CanValidateEyesColor()
        {
            Person w1 = new Person { EyesColor = EyesColor.Blue };
            Person m1 = new Person { EyesColor = EyesColor.Blue };
            Person w2 = new Person { EyesColor = EyesColor.Blue };
            Person m2 = new Person { EyesColor = EyesColor.Green };

            EyesColorValidator validator = new EyesColorValidator();

            Assert.True(validator.Matched(w1, m1));
            Assert.False(validator.Matched(w2, m2));
        }
    }
}
