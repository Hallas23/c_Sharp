using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse1
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
            //List<Person> personsover2 = people.FindAll(p => p.Score < 2);
            //personsover2.ForEach(p => Console.WriteLine(p));
            //List<Person> personseven = people.FindAll(p => p.Score % 2 == 0);
            //personseven.ForEach(p => Console.WriteLine(p));
            List<Person> personseven60w = people.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            personseven60w.ForEach(p => Console.WriteLine(p));
            List<Person> personsdiv3 = people.FindAll(p => p.Weight % 3 == 0);
            personsdiv3.ForEach(p => Console.WriteLine(p));

        }
    }
}
