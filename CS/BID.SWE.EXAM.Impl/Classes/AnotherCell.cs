using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class AnotherCell : Cell
    {
        public override int Grow()
        {
            return _size * 2;
        }
    }
}
