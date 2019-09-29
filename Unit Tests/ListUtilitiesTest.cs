using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeneralUtilities;
using System.Collections.Generic;

namespace Unit_Tests
{
    [TestClass]
    public class ListUtilitiesTest
    {
        [TestMethod]
        public void GetObjSize()
        {
            Assert.AreEqual(2, ListUtilities.GetObjSize(new string[] { "Hello", "test" }), "Correct object size of string[] did not work");
            Assert.AreEqual(-1, ListUtilities.GetObjSize("Hello"), "Correct object size of string did not work");
            Assert.AreEqual(4, ListUtilities.GetObjSize(new object[] { 2, "Hello", new string[][] { new string[] { "Hello" } }, new List<string> { "Test" } }), "Correct object size of object[] did not work");
            Assert.AreNotEqual(5, ListUtilities.GetObjSize("Hello"), "Incorrect object size of string did not work");
        }

        [TestMethod]
        public void ContentEquals()
        {
            string string1 = "Hello";
            string string2 = "Test";
            string string3 = "Hello";
            string[] list1 = { "Hello", "Test" };
            string[] list2 = { "Hello", "Test" };
            List<string> properList1 = new List<string>() { "Hello", "Test" };
            string[][] list3 = { list1, new string[] { "Goodbye", "Testing" } };
            string[][] list4 = { list1, new string[] { "Goodbye", "Testing" } };
            int[,] list5 = { { 3, 5, 6 }, { 4, 5, 3 } };
            int[,] list6 = { { 3, 5, 6 }, { 4, 5, 3 } };
            object[] list7 = { list3, list1, list5, 3, "Tester" };
            object[] list8 = { list3, list1, list5, 3, "Tester" };
            string[] list9 = list4[0];
            string[] list10 = list4[1];

            Assert.IsFalse(string1.ContentEquals(string2), "List Equality between two different strings did not pass as false");
            Assert.IsTrue(string1.ContentEquals(string3), "List Equality between two strings did not pass as true");
            Assert.IsTrue(list1.ContentEquals(list2), "List Equality between two string[]'s did not pass as true");
            Assert.IsFalse(list2.ContentEquals(properList1), "List Equality between a string[] and List<string> did not pass as false");
            Assert.IsTrue(list3.ContentEquals(list4), "List Equality between two string[][]'s did not pass as true");
            Assert.IsTrue(list5.ContentEquals(list6), "List Equality between two int[,]'s did not pass as true");
            Assert.IsTrue(list7.ContentEquals(list8), "List Equality between two object[]'s did not pass as true");
            Assert.IsFalse(list9.ContentEquals(list10), "List Equality between two different string[]'s did not pass as false");
        }

        [TestMethod]
        public void Reverse()
        {
            string[] expected = { "Item 3", "Item 2", "Item" };
            string[] array = { "Item", "Item 2", "Item 3" };
            array.Reverse();
            Assert.IsTrue(array.ContentEquals(expected), DebugUtilities.FailedAssertMessage("Reverse()", 1, expected.ToReadableString(), array.ToReadableString()));
        }

        [TestMethod]
        public void SwapValues()
        {
            string[] expected = { "Item 1", "Item 4", "Item 3", "Item 2" };
            string[] array = { "Item 1", "Item 2", "Item 3", "Item 4" };

            array.SwapValues(1, 3);
            Assert.IsTrue(array.ContentEquals(expected), DebugUtilities.FailedAssertMessage("SwapValues()", 1, expected.ToReadableString(), array.ToReadableString()));
        }

        [TestMethod]
        public void ToReadableString()
        {
            Assert.AreEqual("[\"Hello\", 3]", new object[] { "Hello", 3 }.ToReadableString(), "ToReadableString() between object array did not work correctly");
            Assert.AreEqual("[\"Hello\", \"3\"]", new string[] { "Hello", "3" }.ToReadableString(), "ToReadableString() between string array did not work correctly");
            Assert.AreEqual("[\"Hello\", [\"Test\", \"Int\"], [['c', 'd'], [[4, 5], [233, 54453]]]]", new object[] { "Hello", new List<string> { "Test", "Int" }, new object[] { new char[] { 'c', 'd' }, new int[][] { new int[] { 4, 5 }, new int[] { 233, 54453 } } } }.ToReadableString(), "ToReadableString() between unusual object array did not work correctly");
        }

        [TestMethod]
        public void MoveItem()
        {
            string[] expected1 = { "Item 1", "Item 3", "Item 2", "Item 4" };
            string[] array1 = { "Item 1", "Item 2", "Item 3", "Item 4" };
            List<string> expected2 = new List<string>() { "Item 1", "Item 3", "Item 4", "Item 5", "Item 6", "Item 2" };
            List<string> list2 = new List<string>() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6" };
            int[][] expected3 = { new int[] { 1, 2 }, new int[] { 5, 6 }, new int[] { 3, 4 } };
            int[][] array3 = { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } };

            array1.MoveItem(1, 2);
            Assert.IsTrue(array1.ContentEquals(expected1), DebugUtilities.FailedAssertMessage("MoveItem()", 1, expected1.ToReadableString(), array1.ToReadableString()));

            list2.MoveItem(1, 5);
            Assert.IsTrue(list2.ContentEquals(expected2), DebugUtilities.FailedAssertMessage("MoveItem()", 2, expected2.ToReadableString(), list2.ToReadableString()));

            array3.MoveItem(1, 2);
            Assert.IsTrue(array3.ContentEquals(expected3), DebugUtilities.FailedAssertMessage("MoveItem()", 3, expected3.ToReadableString(), array3.ToReadableString()));
        }

        [TestMethod]
        public void ContainsAny()
        {
            string[] containedItems = { "Item 1", "Item 2", "Item 3" };
            string[] incorrectArray = { "Item 0", "Item 4" };
            string[] correctArray = { "Item 0", "Item 2", "Item 4", "Item 5" };
            List<string> correctList = new List<string>() { "Item 0", "Item 2", "Item 4", "Item 5" };

            Assert.IsFalse(incorrectArray.ContainsAny(containedItems), DebugUtilities.FailedAssertMessage("ContainsAny()", 1, false, true));
            Assert.IsTrue(correctArray.ContainsAny(containedItems), DebugUtilities.FailedAssertMessage("ContainsAny()", 2, true, false));
        }
    }
}
