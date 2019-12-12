using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    //Aufgabe Interface implementieren mit gegebenem output
    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            return new CellPrinter();
        }
    }
}
