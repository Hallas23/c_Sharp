using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3Øvelser
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            Mekaniker m1 = new Mekaniker("Mech", "MechVEj", 1990, 200);
            Værkfører v1 = new Værkfører("Vech", "VechVEj", 2000, 210, 2010, 1000);
            Synsmand s1 = new Synsmand("Synch", "SynchVEj", 1995, 220, 6);
            personer.Add(m1);
            personer.Add(v1);   
            personer.Add(s1);
            foreach(Mekaniker m in personer)
            {
                Console.WriteLine(m.printPerson());
                Console.WriteLine(m.regnugeLøn());

            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        string name { get; set; }
        string adresse { get; set; }

        public Person(string name, string adresse)
        {
            this.name = name;
            this.adresse = adresse;
        }

        virtual public string printPerson()
        {
            return ($"{name}, {adresse}");
        }

    }
}
