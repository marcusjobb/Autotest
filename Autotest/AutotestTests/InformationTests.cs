using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Autotest.Tests
{
    [TestClass()]
    public class InformationTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            var info = new Information();
            Assert.AreEqual("Marcus", info.GetName());
        }
    }
}
