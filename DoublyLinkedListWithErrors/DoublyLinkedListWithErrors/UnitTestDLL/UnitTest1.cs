using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnitTestDLL
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DLLNode p = new DLLNode("Hello");
        }
    }
}
