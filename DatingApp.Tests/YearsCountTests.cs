using DatingApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DatingApp.Tests
{
    public class YearsCountTests
    {
        [Fact]
        public void CanCountYears()
        {
            int yearsDiff = 18;
            DateTime adultDate = DateTime.Now.AddYears(-yearsDiff);
            DateTime childDate = DateTime.Now.AddYears(-yearsDiff).AddDays(-2);

            Assert.True(yearsDiff == adultDate.CountYears());
            Assert.False(yearsDiff == childDate.CountYears());
        }

    }
}
