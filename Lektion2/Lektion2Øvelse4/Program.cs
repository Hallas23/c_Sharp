using System;

namespace Lektion2Øvelse4
{
    class Program
    {
        static private void Fibonacci(int number)
        {
            int num1 = 1; int num2 = 1;
            while (num1 <= number)
            {
                Console.Write(num1 + ", ");
                int sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
