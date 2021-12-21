using inputReturner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace boolExp_tester
{
    [TestClass]
    public class UnitTest1
    {
        // Test Object
        boolExp boolExp = new boolExp();

        [TestMethod]
        public void TestMethod1()
        {
            boolExp.set("a & b | c");
            string temp = boolExp.RetIn();
            Assert.IsTrue(temp== "a | 0 0 0 0 1 1 1 1 \nb | 0 0 1 1 0 0 1 1 \nc | 0 1 0 1 0 1 0 1 \n");
        }
        [TestMethod]
        public void TestMethod2()
        {
            boolExp.set("a & b");
            string temp = boolExp.RetIn();
            Assert.IsTrue(temp == "a | 0 0 1 1 \nb | 0 1 0 1 \n");
        }
        [TestMethod]
        public void TestMethod3()
        {
            boolExp.set("a");
            string temp = boolExp.RetIn();
            Assert.IsTrue(temp == "a | 0 1 \n");
        }
        [TestMethod]
        public void TestMethod4()
        {
            boolExp.set("");
            Assert.IsTrue(boolExp.RetIn() == "");
        }
    }
}
