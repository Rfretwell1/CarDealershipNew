using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;
using CarTest;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
             clsCarCollection AllCars  = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }
        [TestMethod]
        public void ThisCarPropertyOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllAddresses = new clsCarCollection();
            //create some test data to assign to the property
            clsCar TestCar = new clsCar();
            //set the properties of the test object
            TestCar.CarNo = 1;
            TestCar.Active = true;
            TestCar.CarMake = "Honda";
            TestCar.CarModel = "Civic";
            TestCar.Colour = "red";
            TestCar.Age = 5;
            TestCar.BodyType = "Sedan";
            TestCar.Mileage = 100000;
            //assign the data to the property
            AllAddresses.ThisCar = TestCar;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisCar, TestCar);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCar> TestList = new List<clsCar>();
            //add an item to the list
            //create the item of test data
            clsCar TestItem = new clsCar();
            //set its properties
            TestItem.CarNo = 1;
            TestItem.Active = true;
            TestItem.CarMake = "Honda";
            TestItem.CarModel = "Civic";
            TestItem.Colour = "red";
            TestItem.BodyType = "Sedan";
            TestItem.Mileage = 100000;
            TestItem.Age = 5;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCars.CarList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {

            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.CarNo = 1;
            TestItem.Active = true;
            TestItem.CarMake = "Honda";
            TestItem.CarModel = "Civic";
            TestItem.Colour = "red";
            TestItem.BodyType = "Sedan";
            TestItem.Mileage = 100000;
            TestItem.Age = 5;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarNo = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.ThisCar, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllCars = new clsCarCollection();
            //create the item of test data
            clsCar TestItem = new clsCar();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CarNo = 1;
            TestItem.Active = true;
            TestItem.CarMake = "Honda";
            TestItem.CarModel = "Civic";
            TestItem.Colour = "red";
            TestItem.BodyType = "Sedan";
            TestItem.Mileage = 100000;
            TestItem.Age = 5;
            //set ThisCar to the test data
            AllCars.ThisCar = TestItem;
            //add the record
            PrimaryKey = AllCars.Add();
            //set the primary key of the test data
            TestItem.CarNo = PrimaryKey;
            //find the record
            AllCars.ThisCar.Find(PrimaryKey);
            //delete the record
            AllCars.Delete();
            //now find the record   
            bool Found = AllCars.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }
    }
}
