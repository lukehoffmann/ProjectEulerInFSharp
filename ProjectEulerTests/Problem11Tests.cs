using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem11Tests
    {
        [TestMethod]
        public void RightProductTest()
        {
            Assert.AreEqual(08 * 02 * 22 * 97, Problem11.RightProduct(1, 1));
        }

        [TestMethod]
        public void DownProductTest()
        {
            Assert.AreEqual(08 * 49 * 81 * 52, Problem11.DownProduct(1, 1));
        }

        [TestMethod]
        public void RightDownProductTest()
        {
            Assert.AreEqual(08 * 49 * 31 * 23, Problem11.RightDownProduct(1, 1));
            Assert.AreEqual(39 * 88 * 74 * 92, Problem11.RightDownProduct(7, 17));
        }

        [TestMethod]
        public void LeftDownProductTest()
        {
            Assert.AreEqual(97 * 99 * 49 * 52, Problem11.LeftDownProduct(4, 1));
        }
    }
}
