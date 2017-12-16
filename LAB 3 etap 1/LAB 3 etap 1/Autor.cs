using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_etap_1
{
    class Autor : Ksiazka
    {
        private string imie;
        private string nazwisko;        

        public string Imie // wlasciwosci dostepowe
        {
            get { return imie; }
            set { imie = value; }
        }

        public string Nazwisko // wlasciwosci dostepowe
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }

        public Autor() // konstruktor
        {
            imie = " nieznany";
            nazwisko = " nieznany";
        }

        public Autor(string imie_, string nazwisko_) // konstruktor parametry
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }

    }
}
