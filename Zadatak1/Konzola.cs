using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Konzola : Uredjaj, IKonzola
    {
        private int _brojDzojstika;

        public int brojDzojstika
        {
            set 
            {
                if(value < 1 || value > 4)
                {
                    throw new Exception("Broj dzojstika mora biti izmedju 1 i 4!");
                }
                else
                {
                    _brojDzojstika = value;
                }
            }
            get 
            { 
                return _brojDzojstika; 
            }
        }

        public string PokreniIgricu()
        {
            return "Konzola - PokreniIgricu";
        }
        public override string UnosTeksta()
        {
            return "Konzola - UnosTeksta";
        }
    }
}
