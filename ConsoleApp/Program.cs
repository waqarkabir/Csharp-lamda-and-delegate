// See https://aka.ms/new-console-template for more information
using Handlers;
using Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int result = Square(2);
            Console.WriteLine(result);

            Func<int, int> func = Square;

            Console.WriteLine(func(10));

            Func<decimal> resultRate = TaxRate;

            Func<int, int, int> multiply = (x, y) => x * y;
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> subtract = (x, y) => x - y;
            Func<int, int, int> divide = (x, y) => x / y;

            var utility = new Utility();

            Console.WriteLine(utility.Calculate(10, 20, multiply));
            Console.WriteLine(utility.Calculate(10, 20, add));
            Console.WriteLine(utility.Calculate(10, 20, subtract));
            Console.WriteLine(utility.Calculate(10, 20, divide));
        }

        private static decimal TaxRate()
        {
            return 0.06M;
        }

        private static int Square(int number)
        {
            return number * number;
        }

        

    }
}
