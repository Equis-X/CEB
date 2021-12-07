using Microsoft.VisualStudio.TestTools.UnitTesting;
using vector;

namespace vectest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vector asd = new Vector(1,2);
            Assert.IsNotNull(asd);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Vector asd = new Vector(1,2);
            double mag = asd.Magnitude();
            Assert.IsNotNull(mag);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Vector asd = new Vector(1,2);
            Vector dsa = new Vector(3,4);
            double dot = asd.DotProduct(dsa);
            Assert.IsNotNull(dot);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Vector asd = new Vector(1,2);
            Vector dsa = new Vector(3,4);
            double dot = asd.DotProduct(dsa);
            Assert.IsNull(dot);
        }
    }
}
