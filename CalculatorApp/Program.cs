using CalculatorApp.Model;
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = Calculate.Sum(2, 4);
            Console.WriteLine($"Total sum of {sum}");

            Console.ReadKey();
        }
    }
}
