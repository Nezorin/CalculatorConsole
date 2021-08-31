using System;

namespace CalculatorConsole
{
    public class CalculatorService
    {
        public double LastResult { get; private set; } = double.NaN;
        public void Reset() => LastResult = double.NaN;
        public double Evaluate(double num1, double num2, Operation op)
        {
            switch (op)
            {
                case Operation.add:
                    LastResult = num1 + num2;
                    break;
                case Operation.sub:
                    LastResult = num1 - num2;
                    break;
                case Operation.mul:
                    LastResult = num1 * num2;
                    break;
                case Operation.div:
                    if (num2 == 0)
                    {
                        Reset();
                        throw new DivideByZeroException("Division by zero");
                    }
                    LastResult = num1 / num2;
                    break;
                default:
                    return double.NaN;
            }
            if (double.IsInfinity(LastResult))
            {
                Reset();
                throw new Exception("The result of this operation is a too large number, please use smaller numbers");
            }
            return LastResult;

        }
    }
    public enum Operation
    {
        add,
        sub,
        mul,
        div
    }
}
