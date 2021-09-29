using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    // Not as many tests as I hoped to make because I got stuck on this a lot longer than I expected.
    // I started using LeetCode to show me where I was going wrong and using tests to copy their tests so I could debug.
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

            var actual = sut.Get(index); // Get value of Index
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_OneNumber_CanReturnNumber()
        {
            var input = 2; // Value for new Node
            var expected = 2; // Expected value we will retrieve from Tail
            var sut = new MyLinkedList();

            sut.AddAtTail(input); // Add a Node with val 2 as new Tail

            var actual = sut.Get(0); // Get value of Tail
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_OneNumber_CanReturnNumber()
        {
            var index = 1;
            var expected = 3; // Expected value we will retrieve from Head
            var sut = new MyLinkedList();

            sut.AddAtHead(1); // Makes a list with indices to delete
            sut.AddAtTail(3);
            sut.AddAtIndex(1, 2);
            sut.DeleteAtIndex(index); // Add a Node with val 2 as new Head
            var actual = sut.Get(1); // Get value of Head

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllMethods_LeetCodeInput1_ShouldPass()
        {
            var sut = new MyLinkedList();

            sut.AddAtHead(7);
            sut.AddAtHead(2);
            sut.AddAtHead(1);
            sut.AddAtIndex(3, 0);
            sut.DeleteAtIndex(2);
            sut.AddAtHead(6);
            sut.AddAtTail(4);
            var actual = sut.Get(4);
            var expected = 4;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllMethods_LeetCodeInput2_ShouldPass()
        {
            var sut = new MyLinkedList();

            sut.AddAtHead(38);
            sut.AddAtTail(66);
            sut.AddAtTail(61);
            sut.AddAtTail(76);
            sut.AddAtTail(26);
            sut.AddAtTail(37);
            sut.AddAtTail(8);
            sut.DeleteAtIndex(5);
            sut.AddAtHead(4);
            sut.AddAtHead(45);
            var actual = sut.Get(61);
            sut.AddAtTail(85);
            sut.AddAtHead(37);
            sut.Get(5);
            sut.AddAtTail(93);
            sut.AddAtIndex(10, 23);
            sut.AddAtTail(21);
            sut.AddAtHead(52);
            sut.AddAtHead(15);
            sut.AddAtHead(47);
            sut.Get(12);
            sut.AddAtIndex(6, 24);
            sut.AddAtHead(64);
            sut.Get(4);
            sut.AddAtHead(31);
            sut.DeleteAtIndex(6);
            sut.AddAtHead(40);
            sut.AddAtTail(17);
            sut.AddAtTail(15);
            sut.AddAtIndex(19, 2);
            sut.AddAtTail(11);
            sut.AddAtHead(86);
            sut.Get(17);
            sut.AddAtTail(55);
            sut.DeleteAtIndex(15);
            sut.AddAtIndex(14, 95);
            sut.DeleteAtIndex(22);
            sut.AddAtHead(66);
            sut.AddAtTail(95);
            sut.AddAtHead(8);
            sut.AddAtHead(47);
            sut.AddAtTail(23);
            sut.AddAtTail(39);
            sut.Get(30);
            sut.Get(27);
            sut.AddAtHead(0);
            sut.AddAtTail(99);
            sut.AddAtTail(45);
            sut.AddAtTail(4);
            sut.AddAtIndex(9, 11);
            sut.Get(6);
            sut.AddAtHead(81);
            sut.AddAtIndex(18, 32);
            sut.AddAtHead(20);
            sut.AddAtTail(13);
            sut.AddAtTail(42);
            sut.AddAtIndex(37, 91);
            sut.DeleteAtIndex(36);
            sut.AddAtIndex(10, 37);
            sut.AddAtHead(96);
            sut.AddAtHead(57);
            sut.DeleteAtIndex(20);
            sut.AddAtTail(89);
            sut.DeleteAtIndex(18);
            sut.AddAtIndex(41, 5);
            sut.AddAtTail(23);
            sut.AddAtHead(75);
            sut.Get(7);
            sut.AddAtIndex(25, 51);
            sut.AddAtTail(48);
            sut.AddAtHead(46);
            sut.AddAtHead(29);
            sut.AddAtHead(85);
            sut.AddAtHead(82);
            sut.AddAtHead(6);
            sut.AddAtHead(38);
            sut.DeleteAtIndex(14);
            sut.Get(1);
            sut.Get(12);
            sut.AddAtHead(42);
            sut.Get(42);
            sut.AddAtTail(83);
            sut.AddAtTail(13);
            sut.AddAtIndex(14, 20);
            sut.AddAtIndex(17, 34);
            sut.AddAtHead(36);
            sut.AddAtTail(58);
            sut.AddAtTail(2);
            sut.Get(38);
            sut.AddAtIndex(33, 59);
            sut.AddAtHead(37);
            sut.DeleteAtIndex(15);
            sut.AddAtTail(64);
            sut.Get(56);
            sut.AddAtHead(0);
            sut.Get(40);
            sut.AddAtHead(92);
            sut.DeleteAtIndex(63);
            sut.Get(35);
            sut.AddAtTail(62);
            sut.AddAtTail(32);
            var expected = 26;

            Assert.AreEqual(expected, actual);
        }
    }
}
