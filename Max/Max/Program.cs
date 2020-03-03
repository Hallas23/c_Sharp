using System;

namespace Max
{
    class Program
    {
        public static double Max(params double[] numbers)
        {
            double max = double.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                double temp = numbers[i];
                if (temp > max)
                {
                    max = temp;
                }
            }
           
            return max;
        }
        static void Main(string[] args)
        {
            double m1 = Max(28.5, 17);
            double m2 = Max(4.0, 10.8, 34.25, 2.0, 23.6);

            Console.WriteLine(m1 + " " + m2);
            Console.ReadLine();

        }
    }
}
