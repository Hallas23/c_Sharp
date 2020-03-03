x½using Øvelse3;
using System;
using System.Collections.Generic;

namespace ExtensionØvelse3
{
   public static class AcceptExtent
    {
        public static List<Person> setAccepted(this List<Person> list, Predicate<Person> lambda)
        {
           list = list.FindAll(lambda);
            list.ForEach(p => p.Accepted = true);
            return list;
        }
    }
}
