using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Telefon : Uredjaj, ITelefon
    {
        private int _internaMemorija;
        public int internaMemorija
        {
            get { return _internaMemorija; }
            set { _internaMemorija = value; }
        }

        private int _baterija;
        public int baterija
        {
            get { return _baterija; }
            set { _baterija = value; }
        }

        private double _dijagonalaEkrana;
        public double dijagonalaEkrana
        {
            get { return _dijagonalaEkrana; }
            set { _dijagonalaEkrana = value; }
        }

        private string _platforma;
        public string platforma
        {
            set 
            { 
                if(value == "Android" || value == "iOS")
                {
                    _platforma = value;
                }
                else
                {
                    throw new Exception("Platforma mora biti Android ili iOS!");
                }
            }
            get 
            { 
                return _platforma; 
            }
        }

        private int _masa;
        public int masa
        {
            set 
            { 
                if(value <= 100)
                {
                    throw new Exception("Masa mora biti veca od 100 grama!");
                }
                else
                {
                    _masa = value;
                }
            }
            get 
            { 
                return _masa; 
            }
        }

        public string Pozovi()
        {
            return "Telefon - Pozovi";
        }
        public string PosaljiPoruku()
        {
            return "Telefon - PosaljiPoruku";
        }
        public string SurfujInternetom()
        {
            return "Telefon - SurfujInternetom";
        }
        public override string UnosTeksta()
        {
            return "Telefon - UnosTeksta";
        }
    }
}
