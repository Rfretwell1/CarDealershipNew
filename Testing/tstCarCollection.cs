using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;
using CarTest;

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

    }
}
