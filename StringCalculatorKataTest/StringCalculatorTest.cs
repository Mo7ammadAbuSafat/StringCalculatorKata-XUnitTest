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
        public void AddMethodWithTwoNumbersStringInput(string input, int expectedOutput)
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
    }
}