using System;

namespace Tehtävä_5_laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.0f;  //Määritellään arvot.
            float b = 2.5f;

            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float kertolasku = Laskin.Kertolasku(a, b);
            float jakolasku = Laskin.Jakolasku(a, b);
            Console.WriteLine("Numeroiden {0} ja {1}:", a, b);
            Console.WriteLine("summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("Kertolasku: " + kertolasku);
            Console.WriteLine("Jakolasku: " + jakolasku);
            Console.ReadLine();
        }
    }
}
