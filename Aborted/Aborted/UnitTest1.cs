using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Threading;
using System.Threading.Tasks;

namespace Aborted
{
    [TestClass]
    public class SomeTestClass
    {
        //Thread testThread;

        //[TestInitialize]
        //public void BeforeTest()
        //{
        //    testThread = Thread.CurrentThread;
        //    var task = new Task(abortIfTestStilRunsAfterTimeout);
        //    task.Start();
        //}

        //[TestMethod]
        //public void TestMethod()
        //{
        //    try
        //    {
        //        Thread.Sleep(5000);
        //    }
        //    catch (ThreadAbortException e)
        //    {
        //        Assert.Fail((string)e.ExceptionState);
        //    }
        //}

        //private void abortIfTestStilRunsAfterTimeout()
        //{
        //    testThread.Abort("timeout passed!");
        //}
        [TestMethod]
        public void TestMethod1()
        {
            foo();
        }


        public void foo()
        {
            foo();
        }
    }
}
