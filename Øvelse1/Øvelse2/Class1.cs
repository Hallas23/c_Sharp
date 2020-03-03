using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse2
{
    public static class PersonAccepted
    {
        public static List<Person> SetAccepted(this List<Person> list, Predicate<Person> lambda)
        {
            foreach(Person p in list)
            {
                if (lambda(p))
                    p.Accepted = true;
            }
            return list;
        }
    }
}
