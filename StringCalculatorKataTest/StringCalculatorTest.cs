using StringCalculatorKata;

namespace StringCalculatorKataTest
{
    public class StringCalculatorTest
    {
        [Fact]
        public void AddMethodWithEmptyStringInput()
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add("");

            int expected = 0;

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("4", 4)]
        public void AddMethodWithOneNumberStringInput(string input, int expectedOutput)
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add(input);

            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("4,6", 10)]
        public void AddMethodWithTwoNumbersStringWithCommaSplitInput(string input, int expectedOutput)
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add(input);

            Assert.Equal(expectedOutput, result);
        }


        [Theory]
        [InlineData("1,2,6,4,7", 20)]
        [InlineData("4,6,6", 16)]
        public void AddMethodWithUnknownAmountOfNumbersStringInput(string input, int expectedOutput)
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add(input);

            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("1,2\n6,4\n7", 20)]
        [InlineData("4\n6", 10)]
        public void AddMethodNumbersStringWithCommaAndNewLineSplitersInput(string input, int expectedOutput)
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add(input);

            Assert.Equal(expectedOutput, result);
        }


        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//#\n1#2", 3)]
        [InlineData("//%^\n1%^2", 3)]
        public void AddMethodNumbersStringWithDifferentDelimitersInput(string input, int expectedOutput)
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add(input);

            Assert.Equal(expectedOutput, result);
        }

        [Theory]
        [InlineData("1,4,-1", "negatives not allowed: -1, ")]
        [InlineData("1,-4,-1", "negatives not allowed: -4, -1, ")]
        [InlineData("-1,-4,-1", "negatives not allowed: -1, -4, -1, ")]
        public void AddMethodNumbersStringThrowExceptionWhenNegativeNumbersInput(string input, string expectedMassege)
        {
            StringCalculator calculator = new StringCalculator();

            var exception = Assert.Throws<ArgumentException>(() =>
            calculator.Add(input));

            Assert.Equal(expectedMassege, exception.Message);
        }
    }
}