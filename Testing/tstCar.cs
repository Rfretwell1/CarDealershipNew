using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;


namespace CarTest
{
    [TestClass]
    public class tstCar
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //test to see if it exists
            Assert.IsNotNull(ACar);
        }
        [TestMethod]
        public void ActiveCaryOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACar.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Active, TestData);


        }
        [TestMethod]
        public void AgeOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            int TestData = 30;
            //assign the data to the property
            ACar.Age = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Age, TestData);


        }
        [TestMethod]
        public void BodyTypeOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Sedan";
            //assign the data to the property
            ACar.BodyType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.BodyType, TestData);


        }
        [TestMethod]
        public void CarMakeOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Audi";
            //assign the data to the property
            ACar.CarMake = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarMake, TestData);


        }
        [TestMethod]
        public void CarModelOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Camero";
            //assign the data to the property
            ACar.CarModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.CarModel, TestData);


        }

        [TestMethod]
        public void ColourOk()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assaign to the property
            String TestData = "Blue";
            //assign the data to the property
            ACar.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Colour, TestData);


        }
        [TestMethod]

        public void MileageOK()
        {
            //create an isntance of the class we want to create
            clsCar ACar = new clsCar();
            //create some test data to assign to the property
            Int32 TestData = 100000;
            //Assign the data to the property
            ACar.Mileage = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACar.Mileage, TestData);


        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCar ACar = new clsCar();
            //booleon variable to store teh result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string SomeCar = "T-Type";
            //invoke the method
            OK = ACar.Valid(SomeCar);
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void CarModelMinLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validatin
            Boolean OK = false;
            //create some data to assign to the property
            string SomeCarModel = "aaa";
            //invoke the method
            OK = ACar.Valid(SomeCarModel);
            //test to see if the result is correct
            Assert.IsTrue(OK);

        }

    }
}



  