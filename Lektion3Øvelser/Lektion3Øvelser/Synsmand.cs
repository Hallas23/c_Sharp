using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3Øvelser
{
    class Synsmand : Mekaniker
    {
        int antalsyn { get; set; }
        public Synsmand (string name, string adresse, int svendeprøve, double timeløn, int antalsyn) : base(name, adresse, svendeprøve, timeløn)
        {
            this.antalsyn = antalsyn;
        }
        override public string printPerson()
        {
            return (base.printPerson() + $" ,{antalsyn * 290}");
        }
        override public double regnugeLøn()
        {
            return (base.regnugeLøn() + antalsyn * 290);
        }
    }
}
