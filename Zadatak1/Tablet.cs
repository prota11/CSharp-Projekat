using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Tablet : Uredjaj, ITablet
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

        public string SurfujInternetom()
        {
            return "Tablet - SurfujInternetom";
        }
        public string GledajVideo()
        {
            return "Tablet - GledajVideo";
        }
        public override string UnosTeksta()
        {
            return "Tablet - UnosTeksta";
        }
    }
}
