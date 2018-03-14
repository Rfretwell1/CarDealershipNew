using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;


namespace CarTest
{
    [TestClass]
    public class tstCar
    {
        string CarModel = "T-Type";
        string CarMake = "Jaguar";
        string Colour = "red";
        string Milage = "1000";
        string BodyType = "coupe";
        string Age = "10";

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


        //}
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
            string Error = "";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
 JackWalsh
        [TestMethod]
        public void CarModelMinLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "aa";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMinBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "aaaaa";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMaxLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "jkjkjkjkjkjj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMaxBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "jkjkjkjkjkjjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "jkjkjkjkjkjjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMinLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMinBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMinPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMaxLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMaxBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMaxPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ColourMinLessOne()
        {
           //create an instance of the class we want 
           clsCar ACar = new clsCar();
           //booleon variable to store the result of the validation
           string Error = "";
           //create some data to assign to the property
           string Colour = "jk";
           //invoke the method
           Error = ACar.Valid(CarModel, CarMake, Colour, Milage, BodyType, Age);
           //test to see if the result is correct
           Assert.AreNotEqual(Error, "");
    
        }



 master

    }
}



  