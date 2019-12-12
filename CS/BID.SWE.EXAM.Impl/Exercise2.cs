using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    //Aufgabe: Gegebene Klasse ableiten und eine Methode überschreiben und eine Überladen
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            return new NewCell();
        }

        public int Method2()
        {
            return new AnotherCell().Grow();
        }

        public bool Method3(int o1)
        {
            return new ThirdCell().IsAlive(o1);
        }
    }
}