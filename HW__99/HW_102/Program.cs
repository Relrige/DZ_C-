using System;

namespace HW_102
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.SetOperation(Operation.Minus);
            Console.WriteLine(calculator.Calculate(23, 6));
            calculator.SetOperation(Operation.Add);
            Console.WriteLine(calculator.Calculate(31.9, 11.4));
            calculator.SetOperation(Operation.Mult);
            Console.WriteLine(calculator.Calculate(4, 5));
        }
    }
}
