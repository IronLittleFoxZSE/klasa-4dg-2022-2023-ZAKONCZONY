﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizm.Geometria
{
    class TestFigur
    {

        public void Test1()
        {
            Trojkat trojkat = new Trojkat("Trojkat", 3, 4, 5, 2.5);
            /*trojkat.ObliczObwod();
            trojkat.ObliczPole();
            trojkat.Info();*/
            PracaNaObiekcie(trojkat);

            TrojkatRownoboczny trojkatRownoboczny = new TrojkatRownoboczny("Tr", 4, 2.5);
            /*trojkatRownoboczny.ObliczObwod();
            trojkatRownoboczny.ObliczPole();
            trojkatRownoboczny.Info();*/
            PracaNaObiekcie(trojkatRownoboczny);

            Kwadrat kwadrat = new Kwadrat("Kwadrat", 5);
            /*kwadrat.ObliczObwod();
            kwadrat.ObliczPole();
            kwadrat.Info();*/
            PracaNaObiekcie(kwadrat);

            Prostokat figura = new Kwadrat("Kwadrat", 5);
            /*figura.ObliczObwod();
            figura.ObliczPole();
            figura.Info();*/
            PracaNaObiekcie(figura);

            Trojkat trojkat1 = new Kwadrat("Kwadrat", 5);
            /*trojkat1.ObliczObwod();
            trojkat1.ObliczPole();
            trojkat1.Info();*/
            PracaNaObiekcie(trojkat1);

            Kolo kolo = new Kolo("Koło", 6);
            /*kolo.ObliczObwod();
            kolo.ObliczPole();
            kolo.Info();*/
            PracaNaObiekcie(kolo);

            //Figura f = new Figura("adsads");
        }

        void PracaNaObiekcie(Figura f)
        {
            f.ObliczObwod();
            f.ObliczPole();
            f.Info();
        }
    }
}