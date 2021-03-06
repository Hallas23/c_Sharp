﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse1
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
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            var people = ReadCSVFile(@"C:\Users\Simon\Documents\data1.csv");
            var p1 = people.FindAll(p => p.Score < 2);
            List<Person> p2 = people.FindAll(p => p.Score % 2 == 0);
            var p3 = people.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            var p4 = people.FindAll(p => p.Score % 3 == 0);

            people.ForEach(p => Console.WriteLine(p));

 
            Console.WriteLine(p2.Count());
        }
    }
}
