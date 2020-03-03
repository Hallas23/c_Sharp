using Lektion2FagHoldAØvelse1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2FagHoldA
{
    public class SortByWeight : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Weight.CompareTo(y.Weight);
        }
    }
}
