using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsOddTest()
        {
            Assert.IsTrue(IsOdd(3));
        }

        public bool IsOdd(int i)
        {
            return i % 2 != 0;
        }

    }
}
