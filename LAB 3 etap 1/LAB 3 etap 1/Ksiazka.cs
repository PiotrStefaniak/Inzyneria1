using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_etap_1
{
    class Ksiazka : Pozycja
    {
        private int liczbaStron;
        private int iloscAutorow;
        private Autor[] autor = { null ,null, null };
        private int pojemnosc;


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

        public int LiczbaStron // wlasciwosci dostepowe
        {
            get { return liczbaStron; }
            set { liczbaStron = value; }
        }

        public int Pojemnosc // wlasciwosci dostepowe
        {
            get { return pojemnosc; }
            set { pojemnosc = value; autor = new Autor[pojemnosc]; }
        }

        public  Ksiazka() { } // konstruktor domyslny

        public Ksiazka(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int liczbaStron_) // konstruktor z parametrami
        {
            tytul = tytul_;
            id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;
            liczbaStron = liczbaStron_;
            Autor[] autor = { null, null, null };
            iloscAutorow = 0;
            pojemnosc = 3;
            Console.WriteLine("\nWpisuje nowa ksiazke: " + tytul + ", numer id: " + id + "\n");
        }

        public static List<Autor> listaAutorow = new List<Autor>();


        public void DodajAutora(Autor Autor)
        {

            if (iloscAutorow < pojemnosc)
            {
                iloscAutorow++;
                autor[iloscAutorow - 1] = Autor;
                Console.WriteLine("+++ dodaje autora " + Autor.Nazwisko + " " + Autor.Imie +" do ksiazki " + tytul + " " + rokWydania + "\n");
            }
            else
                Console.WriteLine("\n!!! Nie moge dodac autora: "  +Autor.Nazwisko + "  - ilosc autorow ograniczona do 3!\n");
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("Autor: " + autor[0].Nazwisko + " " + autor[0].Imie + " - " + tytul + " " + ", identyfikator: " +  id + ", wydane przez: " + wydawnictwo + ", rok: " + rokWydania + ", stron: " + liczbaStron+ "\n");
        }
    }


}
