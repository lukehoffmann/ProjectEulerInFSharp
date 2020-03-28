using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem13Tests
    {
        [TestMethod]
        public void AddTwoNumbersAsStrings_NoCarrying()
        {
            Assert.AreEqual("5432", Problem13.AddNumbersAsStrings("1111", "4321"));
            Assert.AreEqual("5555", Problem13.AddNumbersAsStrings("1234", "4321"));
            Assert.AreEqual("3348", Problem13.AddNumbersAsStrings("1111", "1234", "1000", "3"));
        }

        [TestMethod]
        public void AddTwoNumbersAsStrings_WithCarrying()
        {
            Assert.AreEqual("10000", Problem13.AddNumbersAsStrings("1", "9999"));
        }
    }
}
