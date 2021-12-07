using Microsoft.VisualStudio.TestTools.UnitTesting;
using vector._3;

namespace TestVector
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vector vector1 = new Vector(1,2);
            Assert.IsNotNull(vector1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Vector vector1 = new Vector(1,2);
            Assert.IsNotNull(vector1.Magnitude());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Vector vector1 = new Vector(1,2);
            Vector vector2 = new Vector(3,4);
            Assert.IsNotNull(vector1.DotProduct(vector2));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Vector vector1 = new Vector(1,2);
            Vector vector2 = new Vector(3,4);
            Assert.IsNotNull(vector1.AngleBetween(vector2));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Vector vector1 = new Vector(1,2);
            Vector vector2 = new Vector(3,4);
            Assert.IsNull(vector1.AngleBetween(vector2));
            // Needs to return error
        }
    }
}
