using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion3HoldASTA
{
    public class EventClass
    {
        public delegate int StringToint(string s);
        
        public static int CountChars(string s)
        {
            int nochars = 0;
            string[] chars = s.Split(' ');
            foreach (string str in chars)
            {
                nochars += str.Length;
            }
            return nochars;
        }

        public static int DelegateUser(StringToint sti, string s)
        {
            return sti(s);
        }
        
        static void Main(string[] args)
        {
            StringToint sti = new StringToint(CountChars);
            Console.WriteLine(sti("Hej Med Dig"));
            Console.WriteLine(sti("YoBitch"));
            Console.WriteLine(sti("HvaDSåNoob"));
            Console.WriteLine(DelegateUser(sti,"Yoooooo"));
            Console.ReadLine();
        }
    }
}
