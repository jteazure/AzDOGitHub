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
            Assert.IsFalse(IsOdd(2));

            Assert.Equals(1 + 2, 3);
        }

        public bool IsOdd(int i)
        {
            return i % 2 != 0;
        }

    }
}
