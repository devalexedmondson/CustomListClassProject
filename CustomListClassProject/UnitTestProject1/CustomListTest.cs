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
            int result = list.Count;

            //Assert
            Assert.AreEqual(result , 3);
        }
        [TestMethod]
        public void TestOverloadingPlusOperator()
        {
            //Arrange
            MyList<string> list = new MyList<string>();
            MyList<string> actualResult = new MyList<string>() { "hi", "hello", "bye", "goodbye" };
            list.Add("hi");
            list.Add("hello");
            MyList<string> secondList = new MyList<string>();
            secondList.Add("bye");
            secondList.Add("goodbye");

            bool compare = true;
            for (int i = 0; i < list.size; i++)
            {
                if(list.objects[i] != actualResult.objects[i])
                {
                    compare = false;
                }
            }

            //Act
            MyList<string> result = (list + secondList);

            //Assert
            Assert.IsTrue(compare);
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
        [TestMethod]
        public void TestZipMethod()
        {
            //Arrange
            MyList<string> list = new MyList<string>() { "hi", "hello" };
            MyList<string> secondList = new MyList<string>() { "bye", "goodbye" };
            MyList<string> actualResult = new MyList<string>() { "hi", "bye","hello","goodbye" };
           
            //Act

            MyList<string> result = list.Zip(list, secondList);
            bool compare = true;
            for (int i = 0; i < list.size; i++)
            {
                if (result.objects[i] != actualResult.objects[i])
                {
                    compare = false;
                }
            }
            //Assert
            Assert.IsTrue(compare);
        }
        //[TestMethod]
        //public void TestOverloadingSubtractionOperator()
        //{
        //    //Arrange
        //    MyList<string> list = new MyList<string>() { "hi", "hello" };
        //    MyList<string> secondList = new MyList<string>() { "bye", "goodbye" };
        //    MyList<string> actualResult = new MyList<string>() { "hi", "hello" };
        //    MyList<string> combinedList = (list + secondList);
        //    bool compare = true;
        //    for (int i = 0; i < list.size; i++)
        //    {
        //        if (list.objects[i] != actualResult.objects[i])
        //        {
        //            compare = false;
        //        }
        //    }
        //    //Act

        //    MyList<string> result = (combinedList - secondList);

        //    //Assert
        //    Assert.IsTrue(compare);
        //}
    }
}
