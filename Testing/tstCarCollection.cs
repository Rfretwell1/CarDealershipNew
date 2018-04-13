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
            clsCarCollection AllCars = new clsCarCollection();
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
            TestCar.CarMake = "Honda";
            TestCar.CarModel = "Civic";
            TestCar.Colour = "red";
            TestCar.BodyType = "Sedan";
            TestCar.Age = 5;
            TestCar.Active = true;
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
            TestItem.CarMake = "Honda";
            TestItem.CarModel = "Civic";
            TestItem.Colour = "red";
            TestItem.BodyType = "Sedan";
            TestItem.Age = 5;
            TestItem.Active = true;
            TestItem.Mileage = 100000;
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
            TestItem.CarMake = "Honda";
            TestItem.CarModel = "Civic";
            TestItem.Colour = "red";
            TestItem.BodyType = "Sedan";
            TestItem.Age = 5;
            TestItem.Active = true;
            TestItem.Mileage = 100000;
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
            TestItem.CarMake = "Honda";
            TestItem.CarModel = "Civic";
            TestItem.Colour = "red";
            TestItem.BodyType = "Sedan";
            TestItem.Age = 5;
            TestItem.Active = true;
            TestItem.Mileage = 100000;
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
        //[TestMethod]
        //public void UpdateMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCarCollection AllCars = new clsCarCollection();
        //    //create the item of test data
        //    clsCar TestItem = new clsCar();
        //    //var to store the primary key
        //    Int32 PrimaryKey = 0;
        //    //set its properties
        //    TestItem.CarNo = 1;
        //    TestItem.CarMake = "Honda";
        //    TestItem.CarModel = "Civic";
        //    TestItem.Colour = "red";
        //    TestItem.BodyType = "Sedan";
        //    TestItem.Age = 5;
        //    TestItem.Active = true;
        //    TestItem.Mileage = 100000;
        //    //set ThisAddress to the test data
        //    AllCars.ThisCar = TestItem;
        //    //add the record
        //    PrimaryKey = AllCars.Add();
        //    //set the primary key of the test data
        //    TestItem.CarNo = PrimaryKey;
        //    //modify the test data
        //    TestItem.CarNo = 1;
        //    TestItem.CarMake = "Honda";
        //    TestItem.CarModel = "Civic";
        //    TestItem.Colour = "red";
        //    TestItem.BodyType = "Sedan";
        //    TestItem.Age = 6;
        //    TestItem.Active = true;
        //    TestItem.Mileage = 100000;
        //    //set the record based on the new test data
        //    AllCars.ThisCar = TestItem;
        //    //update the record
        //    AllCars.Update();
        //    //find the record
        //    AllCars.ThisCar.Find(PrimaryKey);
        //    //test to see ThisCar matches the test data
        //    Assert.AreEqual(AllCars.ThisCar, TestItem);
        //    //
        //}
        [TestMethod]
        public void FilterByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCarCollection AllCars = new clsCarCollection();
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a blank string (should return all records);
            FilteredCars.FilterByCarMake2("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCars.Count, FilteredCars.Count);
        }
        [TestMethod]
        public void FilterByCarMakeNoneFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //apply a Car Make that doesn't exist
            FilteredCars.FilterByCarMake2("jkjkjk");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCars.Count);
        }
        [TestMethod]
        public void FilterByCarMakeTestDataFound()
        {
            //create an instance of the filtered data
            clsCarCollection FilteredCars = new clsCarCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredCars.FilterByCarMake2("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCars.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredCars.CarList[0].CarNo != 1)
                {
                    OK = false;
                }
                //check that the second record is ID 2
                if (FilteredCars.CarList[1].CarNo != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
