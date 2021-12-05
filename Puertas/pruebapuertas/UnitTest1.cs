using Microsoft.VisualStudio.TestTools.UnitTesting;
using puertas;

namespace pruebapuertas
{
    [TestClass]
    public class UnitTest1
    {
        // Puerta universal
        Door testdoor = new Door();
        [TestMethod]
        public void TestMethod1()
        {
            testdoor.Close();
            Assert.IsTrue(testdoor.IsClosed());
        }
        [TestMethod]
        public void TestMethod2()
        {
            testdoor.Close();
            testdoor.Open();    // Open door
            Assert.IsTrue(testdoor.IsClosed());
            // False because it is open
        }
        [TestMethod]
        public void TestMethod3()
        {
            testdoor.CloseAndLock("llave1");
            Assert.IsTrue(testdoor.IsLocked());
        }
        [TestMethod]
        public void TestMethod4()
        {
            testdoor.CloseAndLock("llave1");
            testdoor.OpenAndUnlock("llave1");
            Assert.IsTrue(testdoor.IsUnlocked());
        }
        public void TestMethod5()
        {
            testdoor.Close();
            testdoor.Open();    // Open door
            Assert.IsTrue(testdoor.IsOpen());
            // False because it is open
        }
    }
}
