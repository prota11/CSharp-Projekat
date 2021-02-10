using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    interface IUredjaj
    {
        string proizvodjac { get; set; }
        string model { get; set; }
        string procesor { get; set; }
        int ram { get; set; }
        double cena { get; set; }

        string Upali();
        string Ugasi();
        string Kupi();
        string Dostavi();
        string UnosTeksta();
    }

    interface IDesktopRacunar
    {
        string maticnaPloca { get; set; }
        string napajanje { get; set; }
        string tipDiska { get; set; }
        int memorijaDiska { get; set; }

        string Programiraj();
        string KopirajNaDisk();
    }

    interface ILaptop
    {
        string tipDiska { get; set; }
        int memorijaDiska { get; set; }
        int baterija { get; set; }
        double dijagonalaEkrana { get; set; }

        string GledajFilm();
        string SlusajPredavanje();
    }

    interface ITablet
    {
        int internaMemorija { get; set; }
        int baterija { get; set; }
        double dijagonalaEkrana { get; set; }

        string SurfujInternetom();
        string GledajVideo();
    }

    interface IKonzola
    {
        int brojDzojstika { get; set; }

        string PokreniIgricu();

    }

    interface ISingleBoardRacunar
    {
        string operativniSistem { get; set; }

        string SurfujInternetom();
    }

    interface ITelefon
    {
        int internaMemorija { get; set; }
        int baterija { get; set; }
        double dijagonalaEkrana { get; set; }
        string platforma { get; set; }
        int masa { get; set; }

        string Pozovi();
        string PosaljiPoruku();
        string SurfujInternetom();
    }


}
