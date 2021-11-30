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
            Assert.IsTrue((testdoor.Close() == "OK"),"Cierra");
        }
        [TestMethod]
        public void TestMethod2()
        {
            testdoor.Close();
            Assert.IsTrue((testdoor.Open() == "OK"), "Abre");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue((testdoor.CloseAndLock("llave1") == "OK"), "Cierra y bloquea");
        }
        [TestMethod]
        public void TestMethod4()
        {
            testdoor.CloseAndLock("llave1");
            Assert.IsTrue((testdoor.OpenAndUnlock("llave1") == "OK"), "Abre y desbloquea");
        }
    }
}
