using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_4__KT_
{
    class Program
    {
        static void Main(string[] args)
        {

            Albumi albumi1 = new Albumi();


            albumi1.Nimi = "Thriller";
            albumi1.Artisti = "Michael Jackson";
            albumi1.Genre = "Pop, post-disco, funk, rock";
            albumi1.Hinta = "100$";
            albumi1.TulostaKappaleet();
            albumi1.TulostaData();
            string albuminTiedot = albumi1.ToString();
            Console.ReadLine();





        }
    }
}