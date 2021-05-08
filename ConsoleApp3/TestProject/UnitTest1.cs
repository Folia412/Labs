using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var race = new Race();
            race.Start();
            Thread.Sleep(100);
            Assert.AreEqual("I am thread # 0", race.Results[0].Name);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var race = new Race();
            race.Start();
            Thread.Sleep(100);
            Assert.AreEqual("I am thread # 9", race.Results[9].Name);
        }
    }
}
