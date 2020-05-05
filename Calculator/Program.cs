using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculatorClass calc = new CalculatorClass();
            int sumResult = calc.Sum(2, 4);
            Console.WriteLine(sumResult);
        }        
    }
}
