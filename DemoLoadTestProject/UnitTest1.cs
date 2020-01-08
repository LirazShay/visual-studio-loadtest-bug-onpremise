using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoLoadTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = "fds";
            Console.WriteLine(x);
            System.Threading.Thread.Sleep(1000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var x = "fds";
            Console.WriteLine(x);
            System.Threading.Thread.Sleep(1000);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var x = "fds";
            Console.WriteLine(x);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
