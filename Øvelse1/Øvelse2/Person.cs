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
        public Person(string data)
        {
            // Name, Age, Weight, Score 
            var L = data.Split(';');
            Name = L[0];
            Age = int.Parse(L[1]);
            Weight = int.Parse(L[2]);
            Score = int.Parse(L[3]);
            Accepted = false; // <- nobody accepted by default
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }
        public override string ToString()
        {
            return String.Format("{0,-10} : {1,4} points, {2,4} years, {3,4} kg, {4,4}",
        Name, Score, Age, Weight, Accepted ? "ACCEPTED" : "NOT");
        }
        public static List<Person> ReadCSVFile(string filename)
        {
            List<Person> list = new List<Person>();
            using (var file = new StreamReader(filename))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    var p = new Person(line);
                    list.Add(p);
                    //Console.WriteLine(p);
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            var people = ReadCSVFile(@"C:\Users\Simon\Documents\data1.csv");
            int p1 = people.FindIndex(p => p.Score == 3);
            int p2 = people.FindIndex(p => p.Score == 3 && p.Age < 10);
            int p3 = people.FindAll(p => p.Score == 3 && p.Age < 10).Count();
            int p4 = people.FindIndex(p => p.Score == 3 && p.Age < 8);
            people.SetAccepted(p => p.Score >= 6 && p.Age <= 40);
            people.ForEach(p => Console.WriteLine(p));
            people.Sort((x, y) => x.Age - y.Age);
            people.Sort((x,y) => x.Score - y.Score);
            people.Sort((x, y) => y.Age - x.Age);

            Console.WriteLine(p3);
        }
    }
}
