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

            VersenyzokSzama();


            Console.ReadKey();
        }

        private static void VersenyzokSzama()
        {
            Console.Write("3. Feladat: ");
            int count = 0;
            foreach (var v in Versenyzok)
            {
                count++;
            }

            //Gyorsabb megoldas
            //count = Versenyzok.Count;

            Console.WriteLine($"A vilagranglistan {count} versenyzo szerepel");


        }
    }
}
