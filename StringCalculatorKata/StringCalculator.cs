namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
            string[] delimiters = GetDelimiters(ref numbers);
            string[] splitedNumbers = GetSplitedNumbers(numbers, delimiters);
            bool thereIsANegativeNumbers = splitedNumbers.Any(c => c[0] == '-');
            if (thereIsANegativeNumbers)
            {
                ThrowException(splitedNumbers);
            }
            int[] intNumbers = splitedNumbers.Select(x => Int32.Parse(x)).ToArray();
            int sum = intNumbers.Where(x => x < 1000).Sum();
            return sum;
        }

        private string[] GetDelimiters(ref string numbers)
        {
            List<string> delimiters = new List<string> { ",", "\n" };
            if (numbers[0] == '/')
            {
                int endPoint = numbers.IndexOf('\n');
                delimiters.Add(numbers.Substring(2, endPoint - 2));
                numbers = numbers.Substring(endPoint + 1);
            }
            return delimiters.ToArray();
        }

        private string[] GetSplitedNumbers(string numbers, string[] delimiters)
        {
            string[] SplitedNumbers = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            return SplitedNumbers;
        }

        private void ThrowException(string[] splitedNumbers)
        {
            string[] negativeNumbers = splitedNumbers.Where(c => c[0] == '-').ToArray();
            string nums = string.Join(',', negativeNumbers);
            throw new ArgumentException($"negatives not allowed: {nums}");
        }
    }
}