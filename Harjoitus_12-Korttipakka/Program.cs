using Harjoitus_12_Korttipakka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Korttipakka
{
    private Dictionary<string, Kortti> pakka = new Dictionary<string, Kortti>();

    internal Dictionary<string, Kortti> Pakka { get => pakka; set => pakka = value; }

    public Korttipakka()
    {
        Lisaapakka();
    }
    public void Lisaapakka()
    {
        int pata = 1;
        int risti = 1;
        int ruutu = 1;
        int hertta = 1;
        for (int i = 1; i < 52; i++)
        {
            while (hertta < 13)  //Tehdäään while komento jossa lisätään arvo jos on alle 52.
            {
                Pakka.Add(" --Hertta " + hertta, new Kortti());
                hertta++;
            }
            while (risti < 13)
            {
                Pakka.Add(" --Risti " + risti, new Kortti());
                risti++;

            }
            while (ruutu < 13)
            {
                Pakka.Add(" --Ruutu " + ruutu, new Kortti());
                ruutu++;

            }
            while (pata < 13)
            {
                Pakka.Add(" --Pata " + pata, new Kortti());
                pata++;

            }
        }

    }
    public void Tulosta()
    {
        foreach (var k in Pakka.Keys)
        {
            Console.WriteLine("{0}", k);
        }
    }

    public void Sekoita()
    {
        Shuffle();
        Console.WriteLine(" ----Korttipakka on sekoitettu! ");
        Console.WriteLine();



    }
    public void Shuffle()
    {
        int Luku = 1;
        Random rand = new Random();
        var random = Pakka.OrderBy(item => rand.Next());
        foreach (var value in random)
        {
            Console.WriteLine("{0}. Kortti on; " + value.Key, Luku);
            Luku++;
        }
        Console.ReadLine();
    }











    

}