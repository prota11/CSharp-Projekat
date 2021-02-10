using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class DesktopRacunar : Uredjaj, IDesktopRacunar
    {
        private string _procesor;
        public override string procesor
        {
            set
            {
                if (value.ToUpper() == "INTEL" || value.ToUpper() == "AMD")
                {
                    _procesor = value.ToUpper();
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

        private string _maticnaPloca;
        public string maticnaPloca
        {
            get { return _maticnaPloca; }
            set { _maticnaPloca = value; }
        }

        private string _napajanje;
        public string napajanje
        {
            get { return _napajanje; }
            set { _napajanje = value; }
        }

        private string _tipDiska;
        public string tipDiska
        {
            set 
            { 
                if(value.ToUpper() == "SSD" || value.ToUpper() == "HDD")
                {
                    _tipDiska = value.ToUpper();
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
                if(value < 120 || value > 16000)
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

        public string Programiraj()
        {
            return "DesktopRacunar - Programiraj";
        }
        public string KopirajNaDisk()
        {
            return "DesktopRacunar - KopirajNaDisk";
        }
        public override string UnosTeksta()
        {
            return "DesktopRacunar - UnosTeksta";
        }
    }
}
