using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace UnittestDLLList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DLLNode p = new DLLNode("Hello");
            DLLList dll = new DLLList();
            dll.addToHead(p);
            Assert.AreEqual(true, (dll.head == dll.tail));
            
        }
    }
}
