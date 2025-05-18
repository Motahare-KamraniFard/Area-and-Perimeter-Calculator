using Area_and_Perimeter_Calculator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_Calculator.Helper
{
    public static class InputHelper
    {
        public static InputResult GetValidation(string prompt)
        {
            double number;
            string input;
            bool isValid;

            do
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    return new InputResult(null, true);
                }

                isValid = double.TryParse(input, out number);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (!isValid);

            return new InputResult(number, false);
        }
    }
}
