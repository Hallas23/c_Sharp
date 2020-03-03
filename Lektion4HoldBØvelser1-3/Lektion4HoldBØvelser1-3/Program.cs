using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    static class Program
    {
        public static int Factorial(this int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        public static int Power(this int n, int p)
        {
            if (p == 0)
                return 1;
            else
                return n * Power(n, p - 1);
        }

        public static bool IsPalindrom(this string s)
        {
            if (s.Length == 1 || s.Length == 0)
                return true;

            if (s.SubstringSimon(0, 1) != s.SubstringSimon(s.Length - 1, s.Length))
                return false;

            return IsPalindrom(s[1..^1]);
        }

        public static string SubstringSimon(this string s, int start, int slut)
        {
            string result = "";
            for (int i = start; i < slut; i++)
            {
                result += s[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(10.Power(3));
            Console.WriteLine("ABBA".IsPalindrom());
            Console.WriteLine("ollo".IsPalindrom());
            Console.ReadLine();
        }
    }
}

