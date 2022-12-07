using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8_pomo
{
    class Pomo : Tyontekija
    {
        private static int instanssit = 0;
        private static int tunnit;
        private static int palkka;
        private static string nimi;
        private static string auto;
        private static int bonus;


        public Pomo(int _tunnit, int _palkka, string _nimi, string _auto, int _bonus)  // Määrritellään arvot ja muutetaan ne public muotoiseksi.

        {
            instanssit++;
            tunnit = _tunnit;
            palkka = _palkka;
            nimi = _nimi;
            auto = _auto;
            bonus = _bonus;
        }


        public static new void KuinkaMonta() //Tuodaan tiedot esille konsoliin.
        {
            Console.WriteLine("Pomon nimi on: {0}.", nimi);
            Console.WriteLine("Pomo tekee noin {0} tuntia töitä viikossa", tunnit);
            Console.WriteLine("Pomon palkka: {0} euroa/kk ", palkka);
            Console.WriteLine("Pomon auto on: {0}  ", auto);
            Console.WriteLine("Pomon bonus on: {0} euroa kuukaudessa.  ", bonus);
            Console.WriteLine("Paina ENTER Lopettaakseksi.");
            Console.ReadLine();
        }
    }
}







