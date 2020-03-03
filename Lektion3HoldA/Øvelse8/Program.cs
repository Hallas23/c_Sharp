using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Øvelse3.Person> people = Øvelse3.Person.ReadCSVFile(@"C:\Users\Simon\Documents\data1.csv");
            Console.WriteLine(people[0]);
        }
    }
}
