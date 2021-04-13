using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new ConsoleApp1.List();
            var actual = list.add_elem(value: "f");
            var expected = "f";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var list = new ConsoleApp1.List();
            var actual = list.add_elem(value: "poo");
            var expected = "poo";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var list = new ConsoleApp1.List();
            list.add_elem(value: "f");
            list.add_elem(value: "z");
            list.add_elem(value: "f");
            var list1 = new ConsoleApp1.List();
            list1.add_elem(value: "f");
            list1.add_elem(value: "z");
            list1.add_elem(value: "f");
            var actual = list.Equal(list, list1);
            var expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var list = new ConsoleApp1.List();
            list.add_elem(value: "f");
            list.add_elem(value: "o");
            list.add_elem(value: "h");
            var list1 = new ConsoleApp1.List();
            list1.add_elem(value: "f");
            list1.add_elem(value: "a");
            list1.add_elem(value: "h");
            var actual = list.Equal(list, list1);
            var expected = false;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var list = new ConsoleApp1.List();
            list.add_elem(value: "f");
            list.add_elem(value: "k");
            list.add_elem(value: "h");
            var actual = list.Amount("f");
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var list = new ConsoleApp1.List();
            list.add_elem(value: "f");
            list.add_elem(value: "fo");
            list.add_elem(value: "f");
            var actual = list.Amount("f");
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
    }
}