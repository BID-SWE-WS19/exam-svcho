using NUnit.Framework;
using BID.SWE.EXAM.Impl;
using System.IO;

namespace BID.SWE.EXAM.Test
{
    public class Tests
    {
        [Test]
        public void Ex1Test1()
        {
            Exercise1 ex1 = new Exercise1();
            CellPrinter cellPrinter = (CellPrinter)ex1.Method1();

            Assert.AreEqual(cellPrinter.PrintState(true,System.DateTime.Now,"red"), $"Cell red born on {System.DateTime.Now} is alive");
        }

        [Test]
        public void Ex1Test2()
        {
            Exercise1 ex1 = new Exercise1();
            CellPrinter cellPrinter = (CellPrinter)ex1.Method1();

            Assert.AreEqual(cellPrinter.PrintPostion(1,1), "Cell is on Position X:1 Y:1");
        }

        [Test]
        public void Ex2Test1()
        {
            Exercise2 ex2 = new Exercise2();
            Assert.AreEqual(ex2.Method2(), 2);
        }

        [Test]
        public void Ex2Test2()
        {
            Exercise2 ex2 = new Exercise2();
            Assert.AreEqual(ex2.Method3(2), true);
        }

        [Test]
        public void Ex2Test3()
        {
            Exercise2 ex2 = new Exercise2();
            Assert.AreEqual(ex2.Method3(1), false);
        }

        [Test]
        public void Ex3Test1()
        {
            Exercise3 ex3 = new Exercise3();
            MyMap myMap = (MyMap)ex3.Method1();

            Assert.AreEqual(myMap.GetMapName(), "BID-Map");
        }

        [Test]
        public void Ex3Test2()
        {
            Exercise3 ex3 = new Exercise3();
            MyMap myMap = (MyMap)ex3.Method1();

            Assert.AreEqual(myMap.GetMapSize(1), 1);
        }

        [Test]
        public void Ex3Test3()
        {
            Exercise3 ex3 = new Exercise3();
            MyMap myMap = (MyMap)ex3.Method1();

            Assert.AreEqual(myMap.AddNewCells(2), 2);
        }

        [Test]
        public void Ex3Test4()
        {
            Exercise3 ex3 = new Exercise3();
            Bewegung[] test = (Bewegung[])ex3.Method2();

            Assert.AreEqual(test.Length, 2);
        }

        [Test]
        public void Ex4Test1()
        {
            Exercise4 ex4 = new Exercise4();
            Assert.AreEqual(ex4.Method1().GetType(), typeof(MemoryStream));
        }

        [Test]
        public void Ex4Test2()
        {
            Exercise4 ex4 = new Exercise4();
            Assert.AreEqual((string)ex4.Method2(ex4.Method1()), "Frohe Weihnachten");
        }
    }
}