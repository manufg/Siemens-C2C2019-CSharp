using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            string sentence = "new,goat,born,lien,siemens,newborn,ecity,alien,a";
            List<string> output =
                CompositeWordFinder.FindCompositeWords(sentence);
            /*
             * new,born,newborn
             * a,lien,alien
             */
        }
    }
}
