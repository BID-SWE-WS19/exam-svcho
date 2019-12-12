using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    //Aufgabe 3: Abstrakte Klasse ableiten und ein Heterogenes Array erstellen in dem zwei verschiedene Objekte sind
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MyMap();
        }

        public object Method2()
        {
            return new Bewegung[] { new Springen(), new Laufen() };
        }

    }
}