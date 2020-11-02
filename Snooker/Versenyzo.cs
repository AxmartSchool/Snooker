using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snooker
{
    public class Versenyzo
    {

        public int Helyezes { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public int Nyeremeny { get; set; }



        public static List<Versenyzo> Beolvasas()
        {
             var sr = new StreamReader("../../snooker.txt",encoding: Encoding.UTF8);
            sr.ReadLine();
            var output = new List<Versenyzo>();
            string[] tempTomb;
            while (!sr.EndOfStream)
            {
                tempTomb = sr.ReadLine().Split(';');
                output.Add(new Versenyzo() { Helyezes = int.Parse(tempTomb[0]), Nev = tempTomb[1], Orszag = tempTomb[2], Nyeremeny = int.Parse(tempTomb[3]) });

            }
            sr.Close();
            return output;

        }

    }
}
