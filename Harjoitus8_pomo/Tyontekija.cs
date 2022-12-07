using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8_pomo
{
    class Tyontekija
    {
        public string Nimi { get; set; }



        public Tyontekija()
        {

        }

        public static void KuinkaMonta()
        {

        }

        public virtual void Ääntele()
        {
            Console.WriteLine("Eläin Ääntelee");
        }
    }
}