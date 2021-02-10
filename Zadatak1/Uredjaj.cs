using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Uredjaj : IUredjaj
    {
        private string _proizvodjac;
        public string proizvodjac
        {
            set
            {
                _proizvodjac = value;
            }
            get
            {
                return _proizvodjac;
            }
        }

        private string _model;
        public string model
        {
            set
            {
                _model = value;
            }
            get
            {
                return _model;
            }
        }

        private string _procesor;
        public virtual string procesor
        {
            set
            { 
                _procesor = value; 
            }

            get
            {
                return _procesor;
            }
        }

        private int _ram;
        public int ram
        {
            set
            {
                if(value < 1 || value > 128)
                {
                    throw new Exception("Ram mora biti izmedju 1 i 128!");
                }
                else
                {
                    _ram = value;
                }
            }
            get
            {
                return _ram;
            }
        }

        private double _cena;
        public double cena
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Cena mora biti veca od 0!");
                }
                else
                {
                    _cena = value;
                }
            }
            get
            {
                return _cena;
            }
        }

        public string Upali()
        {
            return "Uredjaj - Upali";
        }

        public string Ugasi()
        {
            return "Uredjaj - Ugasi";
        }

        public string Kupi()
        {
            return "Uredjaj - Kupi";
        }

        public string Dostavi()
        {
            return "Uredjaj - Dostavi";
        }

        public virtual string UnosTeksta()
        {
            return "Uredjaj - UnosTeksta";
        }
    }
}
