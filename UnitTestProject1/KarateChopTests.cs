﻿using System;
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
            AssertPositionInArray(-1, 3, new int[] { });
        }

        [TestMethod]
        public void TestArrayWithoutNumberDoesNotFindNumber()
        {
            AssertPositionInArray(-1, 3, new int[] { 1 });
        }

        [TestMethod]
        public void TestOneElementArrayWithNumberFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[] { 1 });
        }

        [TestMethod]
        public void TestOddElementsArrayWithNumberOnFirstPositionFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestEvenElementsArrayWithNumberOnFirstPositionFindsNumber()
        {
            AssertPositionInArray(0, 1, new int[] { 1, 3, 5, 7 });
        }

        [TestMethod]
        public void TestOddElementsArrayWithNumberOnSecondPositionFindsNumber()
        {
            AssertPositionInArray(1,3, new int[] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestEvenElementsArrayWithNumberOnSecondPositionFindsNumber()
        {
            AssertPositionInArray(1, 3, new int[] { 1, 3, 5, 7 });
        }

        [TestMethod]
        public void TestEvenElementsArrayWithNumberOnThirdPositionFindsNumber()
        {
            AssertPositionInArray(2, 5, new int[] { 1, 3, 5, 7 });
        }

        [TestMethod]
        public void TestOddElementsArrayWithNumberOnLastPositionFindsNumber()
        {
            AssertPositionInArray(2, 5, new int[] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestEvenElementsArrayWithNumberOnLastPositionFindsNumber()
        {
            AssertPositionInArray(3, 7, new int[] { 1, 3, 5, 7 });
        }

        [TestMethod]
        public void TestOddElementsArrayWithoutNumberDoesNotFindIt()
        {
            AssertPositionInArray(-1, 0, new int[] { 1, 3, 5 });
            AssertPositionInArray(-1, 2, new int[] { 1, 3, 5 });
            AssertPositionInArray(-1, 4, new int[] { 1, 3, 5 });
            AssertPositionInArray(-1, 6, new int[] { 1, 3, 5 });
        }

        [TestMethod]
        public void TestEvenElementsArrayWithoutNumberDoesNotFindIt()
        {
            AssertPositionInArray(-1, 0, new int[] { 1, 3, 5, 7 });
            AssertPositionInArray(-1, 2, new int[] { 1, 3, 5, 7 });
            AssertPositionInArray(-1, 4, new int[] { 1, 3, 5, 7 });
            AssertPositionInArray(-1, 6, new int[] { 1, 3, 5, 7 });
            AssertPositionInArray(-1, 8, new int[] { 1, 3, 5, 7 });
        }
    }
}