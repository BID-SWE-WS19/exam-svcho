using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class ThirdCell : Cell
    {
        public bool IsAlive(int Neigbours)
        {
            if (Neigbours % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
