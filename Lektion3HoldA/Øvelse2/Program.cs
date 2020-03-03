using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public int Score { get; set; }

        public Person(string person)
        {
            this.Name = person.Split(';')[0];
            this.Age = int.Parse(person.Split(';')[1]);
            this.Weight = int.Parse(person.Split(';')[2]);
            this.Score = int.Parse(person.Split(';')[3]);
        }

        public override string ToString()
        {
            return String.Format("{0,-10} {1,-4} {2,-4} {3,-4}", Name, Age, Weight, Score);
        }

        public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> liste = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    liste.Add(new Person(line));
                }
            }
            return liste;
        }
        static void Main(string[] args)
        {
            List<Person> people = Person.ReadCSVFile(@"C:\Users\Simon\Documents\data1.csv");
            //Console.WriteLine(people.FindIndex(p => p.Score == 3));
            //Console.WriteLine(people.FindIndex(p => p.Age < 10 && p.Score == 3));
            //Console.WriteLine(people.FindAll(p => p.Age < 10 && p.Score == 3).Count());
            //Console.WriteLine(people.FindIndex(p => p.Age < 8 && p.Score == 3));
            var s = from p in people orderby p.Score select p.Name;
            foreach (var v in s)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("----------------");
            var s2 = (from p in people orderby p.Score select p.Name).Reverse();
            foreach (var v in s2)
            {
                Console.WriteLine(v);
            }
            // if FindIndex doesn't find anything, returns -1

        }
    }
}
