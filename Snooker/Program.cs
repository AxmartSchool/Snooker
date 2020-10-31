using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{

    

    class Program
    {

        public static List<Versenyzo> Versenyzok;

        static void Main(string[] args)
        {


            Versenyzok = Versenyzo.Beolvasas();



            Console.ReadKey();
        }
    }
}
