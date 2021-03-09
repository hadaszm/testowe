using IO2;
using System;
using Xunit;

namespace XUnitTestIO2
{
    public class CalculatorTest
    {
        Calculator mockedCalculator = new Calculator();
        
        
        [Theory]
        [InlineData("1", 1)]
        [InlineData("-1", -1)]
        public void Calculate_SingleNumber_ReturnsSameNumber(string arg1, int expected)
        {
            var actual = mockedCalculator.Calculate(arg1);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0 3", 3)]
        [InlineData("-1 -2", -3)]


        public void Calculate_TwoNumbersDefaultSep_ReturnsSameNumber(string arg, int expected)
        {
            var actual = mockedCalculator.Calculate(arg);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("-1+-2", "+", -3)]
        [InlineData("9.3", ".", 12)]
        public void Calculate_TwoNumberCustomSep_ReturnsSameNumber(string arg, string sep, int expected)
        {
            var actual = mockedCalculator.Calculate(arg, sep);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a")]
        [InlineData("abs")]
        public void Calculate_InputNullOrAlphabetic_ThrowsFormatException(string arg)
        {

            Action actual = () => mockedCalculator.Calculate(arg);

            Assert.Throws<FormatException>(actual);
        }

    }
}
