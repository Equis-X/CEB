using Microsoft.VisualStudio.TestTools.UnitTesting;
using isbn;

namespace testkata
{
    //{"979-8-5869-3897-8","1-4842-6671-4","978-1-4842-6671-7"}
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tests = "148426671";
            bool test = tests.isbnc();
            Assert.IsTrue(test,$"ISBN: {tests} | RESPONSE: {test}");
        }
        [TestMethod]
        public void TestMethod2()
        {
            string tests = "978-1-4842-6671";
            bool test = tests.isbnc();
            Assert.IsFalse(test,$"ISBN: {tests} | RESPONSE: {test}");
        }
        [TestMethod]
        public void TestMethod3()
        {
            string tests = "978-1-4842-6671-7";
            bool test = tests.isbnc();
            Assert.IsFalse(test,$"ISBN: {tests} | RESPONSE: {test}");
        }
    }
}
