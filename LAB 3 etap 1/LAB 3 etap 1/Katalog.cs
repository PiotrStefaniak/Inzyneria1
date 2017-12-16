using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_etap_1
{
    class Katalog
    {
        protected string dzialTematyczny;

        public Katalog()  { } // konstruktor

        public Katalog(string dzialTematyczny_) // konstruktor z parametrem
        {
            dzialTematyczny = dzialTematyczny_;

        }

        public static List<Katalog> katalogi = new List<Katalog>(); // lista katalogow
        public static List<Czasopismo> czasopisma = new List<Czasopismo>(); // lista czasopism

        // listy katalogow tematycznie
        List<Katalog> fizyka = new List<Katalog>(); // lista pozycji z fizyki
        List<Katalog> matematyka = new List<Katalog>(); // lista pozycji z matematyki
        List<Katalog> powiesci = new List<Katalog>(); // lista pozycji powiesci

        public static List<Pozycja> pozycje = new List<Pozycja>(); // lista pozycji


        public string DzialTematyczny // wlasciwosci dostepowe
        {
            get { return dzialTematyczny; }
            set { dzialTematyczny = value; }
        }


        public void WypiszInfo()
        {
            Console.WriteLine("");

            if ((DzialTematyczny == "Fizyka"))
            {
                Console.WriteLine("W katalogu fizyka jest: \n");
                foreach (Pozycja obiekt in fizyka)
                {
                    Console.WriteLine(obiekt.tytul);
                }
            }

            if ((DzialTematyczny == "Matematyka"))
            {
                Console.WriteLine("W katalogu Matematyka jest: \n");
                foreach (Pozycja obiekt in matematyka)
                {
                    Console.WriteLine(obiekt.tytul);
                }
            }

            if ((DzialTematyczny == "Powiesci"))
            {
                Console.WriteLine("W katalogu Powiesci jest: \n");
                foreach (Pozycja obiekt in powiesci)
                {
                    Console.WriteLine(obiekt.tytul);
                }
            }

            if ((DzialTematyczny == "Katalog"))
            {
                Console.WriteLine("Wszystkie pozycje: \n");
                for (int i = 0; i < pozycje.Count; i++)
                {
                    Console.WriteLine(pozycje[i].tytul + ", " + pozycje[i].rokWydania + ", " + pozycje[i].wydawnictwo);
                }
            }

        }



        public void DodajPozycje(Pozycja Pozycja) // dodaje pozycje
        {
            Console.WriteLine(dzialTematyczny);
            Console.WriteLine("\nDo katalogu: " + DzialTematyczny + "  ...\n");
            Console.WriteLine("\ndodaje pozycje: " + Pozycja.tytul + " do listy pozycji...\n");

            if ((DzialTematyczny == "Fizyka"))
            {
                fizyka.Add(Pozycja);
            }

            if ((DzialTematyczny == "Matematyka"))
            {
                matematyka.Add(Pozycja);
            }

            if ((DzialTematyczny == "Powiesci"))
            {
                powiesci.Add(Pozycja);
            }

            pozycje.Add(Pozycja);

            }

        public void ZnajdzPozycje(Pozycja Pozycja) // dodaje pozycje
        {
            Console.WriteLine("\nSzukam pozycji: " + Pozycja.tytul + " , w katalogu: " + DzialTematyczny + "\n");

            if ((DzialTematyczny == "Fizyka"))
            {
                int jest = 0;
                foreach (Pozycja obiekt in fizyka)
                {
                    if ((obiekt.tytul == Pozycja.tytul))
                    {
                        Console.WriteLine("\nPozycja " + Pozycja.tytul + " jest w katalogu: " + DzialTematyczny);
                        jest++;
                    }

                }
                if (jest == 0)
                {
                    Console.WriteLine("Pozycji nie ma w katalogu");
                }
            }

            if ((DzialTematyczny == "Matematyka"))
            {
                int jest = 0;
                foreach (Pozycja obiekt in matematyka)
                {
                    if ((obiekt.tytul == Pozycja.tytul))
                    {
                        Console.WriteLine("\nPozycja " + Pozycja.tytul + " jest w katalogu: " + DzialTematyczny);
                        jest++;
                    }

                }
                if (jest == 0)
                {
                    Console.WriteLine("Pozycji nie ma w katalogu");
                }
            }

            if ((DzialTematyczny == "Powiesci"))
            {
                int jest = 0;
                foreach (Pozycja obiekt in powiesci)
                {
                    if ((obiekt.tytul == Pozycja.tytul))
                    {
                        Console.WriteLine("\nPozycja " + Pozycja.tytul + " jest w katalogu: " + DzialTematyczny);
                        jest++;
                    }

                }
                if (jest == 0)
                {
                    Console.WriteLine("Pozycji nie ma w katalogu");
                }
            }

        }
    }


    }

