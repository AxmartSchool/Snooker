using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            LegjobbanKeresoKinai();
            VanENorveg();

            Console.ReadKey();
        }

        private static void VanENorveg()
        {
            Console.Write("6. Feladat: ");
            bool vanNorveg = false;
            int szamlalo = 0;
            while (!vanNorveg && szamlalo < Versenyzok.Count)
            {

                if (Versenyzok[szamlalo].Orszag.Equals("Norvégia"))
                {
                    vanNorveg = true;
                }

                szamlalo++;

            }


            //LINQ
            //vanNorveg = Versenyzok.Any(x => x.Orszag.Equals("Norvégia"));
            

            Console.WriteLine($"A versenyzok kozott {(vanNorveg?"van":"nincs")} norveg versenyzo.");


        }

        private static void LegjobbanKeresoKinai()
        {

            Console.WriteLine("5. Feladat: A legjobban kereso kinai versenyzo:");

            Versenyzo legjobbanKeresoKinaiVersenyzo = null;
            int arfolyam = 380;
            int legnagyobbOsszeg = int.MinValue;

            foreach (var v in Versenyzok)
            {
                
                if (v.Orszag.Contains("Kína"))
                {
                    if (legnagyobbOsszeg < v.Nyeremeny)
                    {
                        legnagyobbOsszeg = v.Nyeremeny;
                        legjobbanKeresoKinaiVersenyzo = v;
                    }


                }


            }
            //LINQ 
            //legjobbanKeresoKinaiVersenyzo = Versenyzok.FindAll(x=> x.Orszag.Contains("Kína")).OrderByDescending(x => x.Nyeremeny).First();



            Console.WriteLine($"\tHelyezes: {legjobbanKeresoKinaiVersenyzo.Helyezes}\n\tNev: {legjobbanKeresoKinaiVersenyzo.Nev}\n\tOrszag: {legjobbanKeresoKinaiVersenyzo.Orszag}\n\tNyeremeny osszege: {legjobbanKeresoKinaiVersenyzo.Nyeremeny*arfolyam :### ### ###} Ft");



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
