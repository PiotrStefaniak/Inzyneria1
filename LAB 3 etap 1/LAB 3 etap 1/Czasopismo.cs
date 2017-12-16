using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_etap_1
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public  Czasopismo() { } // konstruktor domyslny

        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int numer_)
        {
            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;
            numer = numer_;
    }

        public string Tytul // wlasciwosci dostepowe
        {
            get { return tytul; }
            set { tytul = value; }
        }

        public int Id // wlasciwosci dostepowe
        {
            get { return id; }
            set { id = value; }
        }

        public string Wydawnictwo // wlasciwosci dostepowe
        {
            get { return wydawnictwo; }
            set { wydawnictwo = value; }
        }

        public int RokWydania // wlasciwosci dostepowe
        {
            get { return rokWydania; }
            set { rokWydania = value; }
        }

        public int Numer // wlasciwosci dostepowe
        {
            get { return numer; }
            set { numer = value; }
        }

        public void dodajCzasopismo(Czasopismo Czasopismo)
        {
            czasopisma.Add(Czasopismo); // dodaje czasopismo do listy
            Console.WriteLine("\nDodaje czasopismo " + Czasopismo.Tytul + " do listy czasopism\n");
            Console.WriteLine("\nLista czasopism w bibliotece:\n");

            for (int i = 0; i < czasopisma.Count; i++) // wypisuje czasopismo w liscie
            {
                Console.WriteLine("{0}, {1} ", czasopisma[i].Tytul, czasopisma[i].Numer);
            }
            Console.WriteLine(czasopisma.Count);
        }

        public  override void WypiszInfo()
        {
            Console.WriteLine("Czasopismo: " + tytul + ", identyfikator: " + id + ", wydane przez: " + wydawnictwo + ", w roku: " + rokWydania + ", o numerze: " + numer + "\n");
        }
    }
}
