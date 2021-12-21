using lexic8;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace tester
{
    [TestClass]
    public class UnitTest1
    {
        // Tester
        lexico test = new lexico();

        [TestMethod]
        public void TestMethod1()
        {
            string letras = "Hola Mundo\nHola";
            test.getFrom(letras);
            int counter = test.count();
            Assert.IsTrue(counter == 2);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "The String is Empty")]
        public void TestMethod2()
        {
            string letras = "";
            test.getFrom(letras);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string letras = "Ella iba caminando sola por la calle" +
                "\nPensando: ¡Dios, qué complicado es esto del amor!" +
                "\nSe preguntó a sí misma cuál habrá sido el detalle" +
                "\nQue seguro cupido malinterpretó";
            test.getFrom(letras);
            int counter = test.count();
            Assert.IsTrue(counter > 0);
        }
    }
}
