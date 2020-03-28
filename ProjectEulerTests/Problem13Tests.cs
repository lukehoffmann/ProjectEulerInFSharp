using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEulerInCSharp;

namespace ProjectEulerTests
{
    [TestClass]
    public class Problem13Tests
    {
        [TestMethod]
        public void AddTwoNumbersAsStrings_NoRemainders()
        {
            Assert.AreEqual("5432", Problem13.AddNumbersAsStrings("1111", "4321"));
            Assert.AreEqual("5555", Problem13.AddNumbersAsStrings("1234", "4321"));
            Assert.AreEqual("3348", Problem13.AddNumbersAsStrings("1111", "1234", "1000", "3"));
        }
    }
}
