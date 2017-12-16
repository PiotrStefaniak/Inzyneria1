using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_etap_1
{
    abstract class Pozycja : Katalog
    {

        public  Pozycja() { } // konstruktor domyslny

        public Pozycja(string tytul_, int id_, string wydawnictwo_, int rokWydania_) {}

        public string tytul
        {
            get; set;
        }

        public int id
        {
            get; set;
        }

        public string wydawnictwo
        {
            get; set;
        }

        public int rokWydania
        {
            get; set;
        }


        public abstract void WypiszInfo();

    }

}
