using System;
namespace BID.SWE.EXAM.Impl
{
    public abstract class Map
    {
        public abstract string GetMapName();
        public abstract float GetMapSize(float amount);
        public abstract int AddNewCells(int count);
    }
}
