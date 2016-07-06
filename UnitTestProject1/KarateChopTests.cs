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
            Assert.AreEqual(-1, new KarateChop().Chop(3, new int[0] { }));
        }

        [TestMethod]
        public void TestArrayWithoutNumberDoesNotFindNumber()
        {
            Assert.AreEqual(-1, new KarateChop().Chop(3, new int[1] {1}));
        }

        [TestMethod]
        public void TestArrayWithNumberFindsNumber()
        {
            Assert.AreEqual(0, new KarateChop().Chop(1, new int[1] { 1 }));
        }
    }
}
