using System;
using CustomListClassProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomListClassProject
    {
        [TestMethod]
        public void TestListNoObjects()
        {// check length is 0
            //Arrange
            MyList<int> add = new MyList<int>();

            //Act
            add.Add(0);

            //Assert
            Assert.AreEqual(add.objects.Length, 0);
        }
        [TestMethod]
        public void TestListLengthIncreasedByOne()
        {//increase length of the array by one
            //Arrange
            MyList<int> add = new MyList<int>();

            //Act
            add.Add(1);

            //Assert
            Assert.AreEqual(add.objects.Length, 1);
        }
        //[TestMethod]
        //public void TestAddToSpotOnArray()
        //{//increase length of the array
        //    //Arrange
        //    MyList<int> add = new MyList<int>();
        //    //Act
        //    add.Add[0](1);

        //    //Assert
        //    Assert.AreEqual(add.objects.IndexOf(objects, 0), 2);
        //}
        
        //[TestMethod]
        //public void TestRemove()
        //{
        //    //Arrange
        //    CustomList<T> remove = new CustomList<T>

        //    //Act
        //    remove.Remove()

        //    //Assert
        //    Assert.AreEqual(,);
        //}
        //[TestMethod]
        //public void TestOverride()
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
