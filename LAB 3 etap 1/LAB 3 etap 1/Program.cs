using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_etap_1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<Katalog> katalogi = new List<Katalog>(); // lista katalogow
            Katalog Katalog = new Katalog("Katalog");

            Autor Lem = new Autor("Stanislaw", "Lem"); // autorzy
            Autor Ross = new Autor("Kenneth", "Ross");
            Autor Feyman = new Autor("Richard", "Feynman");
            Autor Christie = new Autor("Agatha", "Christie");
            Autor Doyle = new Autor("Arthur Conan", "Doyle");

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Git");

            Ksiazka k0 = new Ksiazka("Praca zbiorowa", 0, " Wyd. Warszawa", 1961, 200); // ksiazki
            Ksiazka k1 = new Ksiazka("Matematyka dyskretna", 1, " Wyd. Wrocław", 2004, 700); // matematyka
            Ksiazka k2 = new Ksiazka("Matematyka dla maturzystow", 2, " Wyd. Wrocław", 2004, 700);

            Ksiazka k3 = new Ksiazka("Feynmana wykłady z fizyki 1", 4, " Wyd. Opole", 2016, 400); // fizyka
            Ksiazka k4 = new Ksiazka("Feynmana wykłady z fizyki 2", 5, " Wyd. Opole", 2016, 400);

            Ksiazka k5 = new Ksiazka("Solaris", 1, " Wyd. Warszawa", 1961, 200); // fantastyka

            Pozycja p1 = new Czasopismo("Zabawy matematyczne", 20, " Wyd. Mlody matematyk", 2016, 11);
            Pozycja p2 = new Czasopismo("Zabawy matematyczne", 11, " Wyd. Mlody matematyk", 2015, 1);

            Pozycja p3 = new Ksiazka("Matematyka dla gimnazjum", 6, " Wyd. PI", 2015, 1);

            Czasopismo c1 = new Czasopismo("Rebusy matematyczne", 21, " Wyd. Mlody matematyk", 2015, 7);

            Ksiazka k6 = new Ksiazka("Morderstwo w orient expressie", 6, " Wyd. Katowice", 2005, 200);

            Ksiazka k7 = new Ksiazka("Solaris", 1, " Wyd. Warszawa", 1961, 200);
            Ksiazka k8 = new Ksiazka("Cyberiada", 2, " Wyd. Poznan", 1965, 250);

            Console.WriteLine("\n\n Dodawanie autorow do ksiazek: ___________________\n"); // dodawanie autorow

            k5.DodajAutora(Lem);
            k1.DodajAutora(Ross);
            k3.DodajAutora(Feyman);
            k4.DodajAutora(Feyman);
            k6.DodajAutora(Christie);
            k7.DodajAutora(Lem);
            k8.DodajAutora(Lem);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n\n Dodawanie autorow zbiorowych do ksiazek: maksymalnie 3\n");
            k0.DodajAutora(Lem);
            k0.DodajAutora(Ross);
            k0.DodajAutora(Feyman);
            k0.DodajAutora(Feyman);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            Katalog Matematyka = new Katalog("Matematyka"); // zawiera pozycje matematyczne
            katalogi.Add(Matematyka);            

            Matematyka.DodajPozycje(k1);
            Matematyka.DodajPozycje(k2);
            Matematyka.DodajPozycje(p1);
            Matematyka.DodajPozycje(p2);
            Matematyka.DodajPozycje(p3);
            Matematyka.DodajPozycje(c1);           

            Console.WriteLine("---------------------------------------");


            Katalog Fizyka = new Katalog("Fizyka");
            katalogi.Add(Fizyka);
            Fizyka.DodajPozycje(k3);
            Fizyka.DodajPozycje(k4);

            //Fizyka.ZnajdzPozycje(k4);


            Console.WriteLine("---------------------------------------");

            Katalog Powiesci = new Katalog("Powiesci");
            katalogi.Add(Powiesci);
            Powiesci.DodajPozycje(k6);
            Powiesci.DodajPozycje(k7);
            Powiesci.DodajPozycje(k8);

            //Katalog Chemia = new Katalog("Chemia");
            //Katalog Historia = new Katalog("Historia");


            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("\nWypisanie info : \n"); // wypisanie info

            k1.WypiszInfo();
            p1.WypiszInfo();
            c1.WypiszInfo();
            k5.WypiszInfo();
            k6.WypiszInfo();



            Console.WriteLine("______________________________________________________________");
            Fizyka.WypiszInfo();
            Matematyka.WypiszInfo();
            Powiesci.WypiszInfo();

            Katalog.WypiszInfo();

            Fizyka.ZnajdzPozycje(k4);
            Fizyka.ZnajdzPozycje(k6);

            Powiesci.ZnajdzPozycje(k6);
            Matematyka.ZnajdzPozycje(k1);
            Matematyka.ZnajdzPozycje(k4);


            Console.ReadKey();
        }    
    }
}
