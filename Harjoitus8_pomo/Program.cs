using System;

namespace Harjoitus8_pomo
{
    class Program
    {
        static void Main(string[] args)  // Annetaan tiedot työntekijästä ja pomosta.
        {
            Tyontekija.KuinkaMonta();



            Henkilo henkilo1 = new Henkilo(38, 7660, "Pekka Jaakkonen");
            henkilo1.Ääntele();



            Pomo pomo2 = new Pomo(38, 7660, "Niko Ikonen", "Polaris-6006", 500);
            Pomo.KuinkaMonta();
            Tyontekija.KuinkaMonta();
            Henkilo.KuinkaMonta();
            Tyontekija.KuinkaMonta();
            Console.ReadLine();

        }
    }
}
