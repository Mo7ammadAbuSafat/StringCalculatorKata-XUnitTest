﻿namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers.Equals(""))
            {
                return 0;
            }

            string[] SplitedNumbers = numbers.Split(',');
            int sum = 0;
            for (int i = 0; i < SplitedNumbers.Length; i++)
            {
                sum += Int32.Parse(SplitedNumbers[i]);
            }
            return sum;
        }
    }
}