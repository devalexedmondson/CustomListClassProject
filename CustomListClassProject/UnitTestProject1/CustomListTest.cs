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
        //[TestMethod]
        //public void TestObjectNoLongerInLastIndex()
        //{
        //    //Arrange
        //    MyList<string> list = new MyList<string>();
        //    list.Add("hi");
        //    list.Add("bye");
        //    list.Add("hello");
        //    //Act

        //    list.Remove("hello");

        //    //Assert
        //    Assert.AreEqual(list.objects[2], null);
        //}


        //[TestMethod]
        //public void TestRemoveFirstIndex()
        //{
        //    //Arrange
        //    MyList<string> list = new MyList<string>();
        //    list.Add("hi");
        //    list.Add("bye");
        //    list.Add("hello");
        //    //Act

        //    list.Remove("hi");

        //    //Assert
        //    Assert.AreEqual(list.size, 2);
        //}

        //TODO: make test to make sure that the value removed is no longer there


        //[TestMethod]
        //public void TestCount()
        //{
        //    //Arrange
        //    CustomList<T> overide = new CustomList<T>

        //    //Act
        //    overide.Override()

        //    //Assert
        //    Assert.AreEqual(,);
        //}
    }
}
