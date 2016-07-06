using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class KarateChopTests
    {
        private static void AssertPositionInArray(int position, int number, int[] numbers)
        {
            Assert.AreEqual(position, new KarateChop().Chop(number, numbers));
        }

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
        public void TestOddElementsArrayWithNumberOnFirstPositionFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[3] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestEvenElementsArrayWithNumberOnFirstPositionFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[4] { 1, 3, 5, 7 });
        }

        [TestMethod]
        public void TestMultipleElementsArrayWithNumberOnSecondPositionFindsNumber()
        {
            AssertPositionInArray(1,3, new int[3] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestMultipleElementsArrayWithNumberOnLastPositionFindsNumber()
        {
            AssertPositionInArray(2, 5, new int[3] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestThreeElementsArrayWithoutNumberDoesNotFindIt()
        {
            AssertPositionInArray(-1, 0, new int[3] { 1, 3, 5 });
            AssertPositionInArray(-1, 2, new int[3] { 1, 3, 5 });
            AssertPositionInArray(-1, 4, new int[3] { 1, 3, 5 });
            AssertPositionInArray(-1, 6, new int[3] { 1, 3, 5 });
        }
    }
}