using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Laptop : Uredjaj, ILaptop
    {
        private string _procesor;
        public override string procesor
        {
            set
            {
                if (value == "INTEL" || value == "AMD")
                {
                    _procesor = value;
                }
                else
                {
                    throw new Exception("Procesora mora biti INTEL ili AMD!");
                }
            }
            get
            {
                return _procesor;
            }
        }

        private string _tipDiska;
        public string tipDiska
        {
            set
            {
                if (value == "SSD" || value == "HDD")
                {
                    _tipDiska = value;
                }
                else
                {
                    throw new Exception("Disk mora biti HDD ili SSD!");
                }
            }
            get
            {
                return _tipDiska;
            }
        }

        private int _memorijaDiska;
        public int memorijaDiska
        {
            set
            {
                if (value < 120 || value > 16000)
                {
                    throw new Exception("Memorija diska mora biti izmedju 120 i 16000 gigabajta!");
                }
                else
                {
                    _memorijaDiska = value;
                }
            }
            get
            {
                return _memorijaDiska;
            }
        }

        private int _baterija;
        public int baterija
        {
            set
            {
                if (value < 2000 || value > 6000)
                {
                    throw new Exception("Baterija mora biti izmedju 2000 i 6000 mAh!");
                }
                else
                {
                    _baterija = value;
                }
            }
            get
            {
                return _baterija;
            }
        }

        private double _dijagonalaEkrana;

        public double dijagonalaEkrana
        {
            set
            {
                if(value < 13 || value > 17.3)
                {
                    throw new Exception("Dijagonala ekrana mora biti izmedju 13 i 17.3 inca");
                }
                else
                {
                    _dijagonalaEkrana = value;
                }
            }
            get 
            { 
                return _dijagonalaEkrana; 
            }
        }

        public string GledajFilm()
        {
            return "Laptop - GledajFilm";
        }
        public string SlusajPredavanje()
        {
            return "Laptop - SlusajPredavanje";
        }
        public override string UnosTeksta()
        {
            return "Laptop - UnosTeksta";
        }
    }
}
