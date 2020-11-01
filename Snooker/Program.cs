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
            AtlagosBevetel();

            Console.ReadKey();
        }

        private static void AtlagosBevetel()
        {
            Console.Write("4. Feladat: ");
            int count = 0;
            double sum = 0;
            foreach (var v in Versenyzok)
            {
                count++;
                sum += v.Nyeremeny;
            }

            Console.WriteLine($" A versenyzok atlagosan {sum/count: 0.00} fontot kerestek.");

            //LINQ
            //Console.WriteLine($" A versenyzok atlagosan {(double)Versenyzok.Sum(x=>x.Nyeremeny)/Versenyzok.Count : 0.00} fontot kerestek.");



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
