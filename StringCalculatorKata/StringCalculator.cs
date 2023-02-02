namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Equals(""))
            {
                return 0;
            }
            string[] SplitedNumbers = stringNumbersSpliter(numbers);
            int sum = 0;
            for (int i = 0; i < SplitedNumbers.Length; i++)
            {
                int num = Int32.Parse(SplitedNumbers[i]);
                sum += num;
            }
            return sum;
        }

        private string[] stringNumbersSpliter(string numbers)
        {
            List<string> spliters = new List<string> { ",", "\n" };
            if (numbers[0] == '/')
            {
                int endPoint = numbers.IndexOf('\n');
                spliters.Add(numbers.Substring(2, endPoint - 2));
                numbers = numbers.Substring(endPoint + 1);
            }
            string[] SplitedNumbers = numbers.Split(spliters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            return SplitedNumbers;
        }


    }
}