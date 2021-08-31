using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main()
        {
            var calculator = new CalculatorService();
            bool endApp = false;
            double firstNumber, secondNumber;
            Operation operation;

            Console.WriteLine("Console Calculator in C#");
            while (!endApp)
            {
                if (!double.IsNaN(calculator.LastResult))
                {
                    firstNumber = calculator.LastResult;
                }
                else
                {
                    // Ask the user to type the first number.
                    Console.Write("Type the first number, and then press Enter: ");
                    string numInput1 = Console.ReadLine();
                    firstNumber = ParseService.DecimalParse(numInput1);
                }

                // Ask the user to type the second number.
                Console.Write("Type the second number, and then press Enter: ");
                string numInput2 = Console.ReadLine();
                secondNumber = ParseService.DecimalParse(numInput2);

                // Ask the user to choose an operation.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("add - Addition sub - Subtract mul - Multiply div - Divide");
                string operationInput = Console.ReadLine();
                operation = ParseService.OperationParse(operationInput);

                //Evaluation
                try
                {
                    double result = calculator.Evaluate(firstNumber, secondNumber, operation);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Result is: {0:0.##}", result);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("An exception occurred trying to do the math.\n Details: " + e.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    continue;
                }
                //User chooses what to do next
                Console.WriteLine("If you don't want to continue with this number type \"n\". \n" +
                    "If want to exit from program type \"e\". \n" +
                    "If you want to continue with this number type any character. \n"
                    );
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                if (choice == 'n')
                {
                    calculator.Reset();
                }
                if (choice == 'e')
                {
                    endApp = true;
                }
                Console.WriteLine();
            }
        }
    }
}
