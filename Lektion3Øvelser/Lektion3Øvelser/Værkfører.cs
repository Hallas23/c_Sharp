using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3Øvelser
{
    class Værkfører : Mekaniker
    {
        int udnævnelse { get; set; }    
        int tillæg { get; set; }
        public Værkfører(string name, string adresse, int svendeprøve, double timeløn, int udnævnelse, int tillæg) : base(name, adresse, svendeprøve, timeløn)
        {
            this.udnævnelse = udnævnelse;
            this.tillæg = tillæg;
        }
        override public string printPerson()
        {
            return (base.printPerson() + $" ,{udnævnelse}, {tillæg}");
        }
        override public double regnugeLøn()
        {
            return (base.regnugeLøn() + tillæg);
        }
    }
}
