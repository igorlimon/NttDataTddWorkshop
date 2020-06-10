using System;

namespace TddWorkShop.StringCalculator
{
    public class StringCalculatorApp
    {
        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            string[] numbersAString = input.Split(',');
            int result = 0;
            foreach (var numberAString in numbersAString)
            {
                result += int.Parse(numberAString);
            }

            return result;
        }
    }
}
