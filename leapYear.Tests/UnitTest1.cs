using System;
using Xunit;

namespace leapYear.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void IsLeapYearReturnsTrue()
        {
            Assert.True(Program.IsLeapYear(2000));
            Assert.True(Program.IsLeapYear(4));
            Assert.True(Program.IsLeapYear(-4));
            Assert.True(Program.IsLeapYear(0));
        }
        [Fact]
        public void IsLeapYearReturnsFalse()
        {
            Assert.False(Program.IsLeapYear(1800));
            Assert.False(Program.IsLeapYear(3));
            Assert.False(Program.IsLeapYear(-1700));
        }
    }
}
