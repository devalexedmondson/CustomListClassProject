using System;
using CustomListClassProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class CustomListClassProject
    {
        [TestMethod]
        public void TestAddOneObject()
        {
            //Arrange
            MyList<int> list = new MyList<int>();

            //Act
            list.Add(1);

            //Assert
            Assert.AreEqual(list.size, 1);
        }
        [TestMethod]
        public void TestAddMultipleObjects()
        {
            //Arrange
            MyList<string> list = new MyList<string>();

            //Act
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");

            //Assert
            Assert.AreEqual(list.size, 3);
        }
        [TestMethod]
        public void TestIndexOnArray()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            //Act
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");

            //Assert
            Assert.AreEqual( list.objects[1] , "bye");
        }
        [TestMethod]
        public void TestRemoveLastIndex()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");
            //Act

            list.Remove("hello");

            //Assert
            Assert.AreEqual(list.size, 2);
        }
        [TestMethod]
        public void TestRemoveFirstIndex()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            list.Add("hi");
            list.Add("bye");
            list.Add("hello");
            //Act
            list.Remove("hi");
            //Assert
            Assert.AreEqual(list.objects[0], "bye");
        }
        [TestMethod]
        public void TestLengthOfArrayEqualsSizeOfList()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            list.Add("Alex");
            list.Add("Quinn");
            list.Add("Olivia");
            //Act
            int result = list.Count();
            //Assert
            Assert.AreEqual(result , 3);
        }
        [TestMethod]
        public void TestOverloadingPlusOperator()
        {
            //Arrange
            MyList<string> list = new MyList<string>() {"hi", "hello"};
            MyList<string> otherList = new MyList<string> {"bye", "goodbye"};
           
            //Act
            string result = new MyList<string>(list + otherList);
            //Assert
            Assert.AreEqual(result, "hi, hello, bye, goodbye");
        }
        [TestMethod]
        public void TestToStringMethod()
        {
            //Arrange
            MyList<int> list = new MyList<int>();
            list.Add(34);
            //Act
            string result = list.ToString();
            //Assert
            Assert.AreEqual(result, "34");
        }
    }
}
