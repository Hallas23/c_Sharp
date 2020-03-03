using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2FagHoldAØvelse1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Person(string person)
        {
            this.Name = person.Split(';')[0];
            this.Age = int.Parse(person.Split(';')[1]);
            this.Weight = int.Parse(person.Split(';')[2]);
        }

        public override string ToString()
        {
            return String.Format("{0,-7} {1,-4} {2,-4}", Name, Age, Weight);
        }

            //public static List<Person> ReadCSVFile(string filename)
            //{
            //    List<Person> liste = new List<Person>();
            //    using (var file = new StreamReader(filename))
            //    {
            //        string line;
            //        while ((line = file.ReadLine()) != null)
            //        {
            //            liste.Add(new Person(line));
            //        }
            //    }
            //    return liste;
            //}
        static void Main(string[] args)
        {
            //var people = Person.ReadCSVFile(@"C:\Users\Simon\Documents\data.csv");
            //Console.WriteLine("Antal af personer i data filen :" + people.Count);
            //people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
            //people.Reverse(0, people.Count);

            

         
            List<Person> people = new List<Person>();
            people.Add(new Person("Ole; 23; 75"));  
            people.Add(new Person("Jens;26;87"));   
            people.Add(new Person("Emma;27;75"));

            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
            }


            Console.ReadLine();

        }
    }
}
