using System;

namespace CalculatorConsole
{
    public static class ParseService
    {
        public static double DecimalParse(string input)
        {
            double result;
            while (!double.TryParse(input, out result))
            {
                Console.Write("This is not a valid input. Please enter a normal value: ");
                input = Console.ReadLine();
            }
            return result;
        }
        public static Operation OperationParse(string input)
        {
            bool parseResult = Enum.TryParse(input, true, out Operation result);
            while (!parseResult || !Enum.IsDefined(typeof(Operation), result))
            {
                Console.Write("This is not a valid input. Please enter a valid operation: ");
                input = Console.ReadLine();
                parseResult = Enum.TryParse(input, true, out result);
            }
            return result;
        }
    }
}
