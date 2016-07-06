using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class KarateChopTests
    {
        [TestMethod]
        public void TestEmptyArrayDoesNotFindNumber()
        {
            AssertPositionInArray(-1, 3, new int[0] { });
        }

        [TestMethod]
        public void TestArrayWithoutNumberDoesNotFindNumber()
        {
            AssertPositionInArray(-1, 3, new int[1] { 1 });
        }

        [TestMethod]
        public void TestOneElementArrayWithNumberFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[1] { 1 });
        }

        [TestMethod]
        public void TestMultipleElementsArrayWithNumberOnFirstPositionFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[3] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestMultipleElementsArrayWithNumberOnSecondPositionFindsNumber()
        {
            AssertPositionInArray(1,3, new int[3] { 1, 3, 5 });
        }

        private static void AssertPositionInArray(int position, int number, int[] numbers)
        {
            Assert.AreEqual(position, new KarateChop().Chop(number, numbers));
        }
    }
}
