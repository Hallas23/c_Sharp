using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3Øvelser
{
    class Mekaniker : Person
    {
        int svendeprøve { get; set; }
        double timeløn { get; set; }

        public Mekaniker(string name, string adresse, int svendeprøve, double timeløn) : base(name,adresse)
        {
            this.svendeprøve = svendeprøve;
            this.timeløn = timeløn;
        }
        override public string printPerson()
        {
            return (base.printPerson() + $" ,{svendeprøve}, {timeløn}");
        }
        virtual public double regnugeLøn()
        {
            return (timeløn * 37);
        }
    }
}

