using System;
using System.Collections;

namespace Lektion2
{
    class Program
    {
        static void Årstal(in DateTime fødselsår, out int alder, out int måneder)
        {
            alder = DateTime.Now.Year- fødselsår.Year;
            måneder = DateTime.Now.Month - fødselsår.Month;
            if (måneder < 0)
            {
                alder -= 1;
                måneder = fødselsår.Month + DateTime.Now.Month - fødselsår.Month + 1;
            }
        }
        static void Main(string[] args)
        {
            DateTime fødselsår = new DateTime(1996, 4, 2);
            int alder;
            int måndeder;
            Årstal(in fødselsår, out alder, out måndeder);
            Console.WriteLine($"{alder} {måndeder}");
        }
    }
}
