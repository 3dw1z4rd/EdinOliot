using System;
using System.Collections.Generic;

namespace tehtava4albumi
{
    class Program
    {
        static void Main(string[] args)
        {

            Albumi albumi1 = new Albumi();
            {

                albumi1.Nimi = "Kirkkonummi joka päivä";
                albumi1.Artisti = "Mc Rambo";
                albumi1.Genre = "Rap, Finnish rap";
                albumi1.Hinta = "10000$";
                albumi1.TulostaKappaleet();
                albumi1.TulostaData();
                string albuminTiedot = albumi1.ToString();
                Console.ReadLine();

            }

        }
    }
}

