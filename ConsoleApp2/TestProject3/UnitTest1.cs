using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace TestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sofa sofa = new Sofa("leather", "brown", 1000);
            Sofa sofa1 = sofa.Clone() as Sofa;
            var actual = (sofa1.material, sofa1.color, sofa1.price);
            var expected = ("leather", "brown", 1000);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Table table = new Table( 4, "brown", 1000);
            Table table1 = table.Clone() as Table;
            var actual = (table1.places, table1.color, table1.price);
            var expected = (4, "brown", 1000);
            Assert.AreEqual(expected, actual);
        }
    }
}
