using Microsoft.VisualStudio.TestTools.UnitTesting;
using isbn;

namespace testkata
{
    [TestClass]
    public class UnitTest1
    {
        // "979-8-5869-3897-8","1-4842-6671-4","978-1-4842-6671-7"
        [TestMethod]
        public void TestMethod1()
        {
            string testcase = "9798586938978";
            Assert.IsTrue(testcase.isbnc());
        }
        [TestMethod]
        public void TestMethod2()
        {
            string testcase = "1-4842-6671-4";
            Assert.IsFalse(testcase.isbnc());
        }
        [TestMethod]
        public void TestMethod3()
        {
            string testcase = "1-4842-6671";
            Assert.IsFalse(testcase.isbnc());
        }
    }
}
