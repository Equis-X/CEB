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
        }
    }
}
