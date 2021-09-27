using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2; // Value for new Node
            var expected = 2; // Expected value we will retrieve from Head
            var sut = new MyLinkedList();

            sut.AddAtHead(input); // Add a Node with val 2 as new Head

            var actual = sut.Get(0); // Get value of Head
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtIndex_OneNumber_CanReturnNumber()
        {
            var input = 2; // Value for new Node
            var index = 0;
            var expected = 2; // Expected value we will retrieve from Index
            var sut = new MyLinkedList();

            sut.AddAtIndex(index, input); // Add a Node with val 2 as new Index

            var actual = sut.Get(0); // Get value of Index
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_OneNumber_CanReturnNumber()
        {
            var input = 2; // Value for new Node
            var expected = 2; // Expected value we will retrieve from Tail
            var sut = new MyLinkedList();

            sut.AddAtTail(input); // Add a Node with val 2 as new Tail

            var actual = sut.Get(1); // Get value of Tail
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_OneNumber_CanReturnNumber()
        {
            int[] list = new int[] {1, 4, 7, 9, 3};
            Helpers.LinkedListBuilder.CreateSinglyLinkedList(list);

            var index = 0;
            var expected = 2; // Expected value we will retrieve from Head
            var sut = new MyLinkedList();

            sut.DeleteAtIndex(index); // Add a Node with val 2 as new Head

            var actual = sut.Get(0); // Get value of Head
            Assert.AreEqual(expected, actual);
        }
    }
}
