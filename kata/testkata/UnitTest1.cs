using Microsoft.VisualStudio.TestTools.UnitTesting;
using isbn;

namespace testkata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] test_cases = {"979-8-5869-3897-8","1-4842-6671-4","978-1-4842-6671-7"};
            foreach (string item in test_cases)
            {
                bool res = item.isbnc();
                Assert.IsTrue(res, $"ISBN: {0} | RESULT: {1}", item, res);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] test_cases = {"979858693897-8","14842-66714","978-148426671-7"};
            foreach (string item in test_cases)
            {
                bool res = item.isbnc();
                Assert.IsFalse(res, $"ISBN: {0} | RESULT: {1}", item, res);
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] test_cases = {"9798586938978","1484266714","9781484266717"};
            foreach (string item in test_cases)
            {
                bool res = item.isbnc();
                Assert.IsFalse(res, $"ISBN: {0} | RESULT: {1}", item, res);
            }
        }
    }
}
