using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aborted
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(false);
        }
        public void TestMethod2()
        {
            Assert.IsFalse(true);
        }
  
        public void TestMethod3()
        {
            Assert.IsFalse(false);
        }
        public void TestMethod4()
        {
            Assert.IsFalse(true);
        }
        public void TestMethod5()
        {
            Assert.IsFalse(false);
        }
        public void TestMethod6()
        {
            Assert.IsFalse(false);
        }
    }
}
