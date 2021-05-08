using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsOddTest1()
        {
            Assert.IsTrue(IsOdd(3));
        }
        public void IsOddTest2()
        {
            Assert.IsFalse(IsOdd(2));
        }

        public void AreEqualTest()
        {
            Assert.AreEqual(1 + 2, 3);
        }

        public void AreSameTest()
        {
            Assert.AreSame("Azerty", "Azerty");
        }

        public bool IsOdd(int i)
        {
            return i % 2 != 0;
        }

    }
}
