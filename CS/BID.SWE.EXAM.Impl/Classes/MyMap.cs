using System;

namespace BID.SWE.EXAM.Impl
{
    public class MyMap : Map
    {
        public override int AddNewCells(int count)
        {
            return count;
        }

        public override string GetMapName()
        {
            return "BID-Map";
        }

        public override float GetMapSize(float amount)
        {
            return amount * amount;
        }
    }
}
