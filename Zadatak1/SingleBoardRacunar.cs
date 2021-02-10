using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class SingleBoardRacunar : Uredjaj, ISingleBoardRacunar
    {
        private string _operativniSistem;
        public string operativniSistem
        {
            get { return _operativniSistem; }
            set { _operativniSistem = value; }
        }

        public string SurfujInternetom()
        {
            return "SingleBoardRacunar - SurfujInternetom";
        }
        public override string UnosTeksta()
        {
            return "SingleBoardRacunar - UnosTeksta";
        }
    }
}
