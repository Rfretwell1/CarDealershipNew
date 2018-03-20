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
        string Mileage = "1000";
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
            string Error = "";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }

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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarModelMid()
        {

            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "jkjkjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");



        }
        [TestMethod]
        public void CarModelExtremeMax()
        {

            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarModel = "";
            //pad the string with characters
            CarModel = CarModel.PadRight(50, 'a');
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            string CarMake = "jkjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            string CarMake = "jkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeMid()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "jkjkjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CarMakeExtremeMax()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string CarMake = "";
            //pad the data
            CarMake = CarMake.PadRight(500, 'a');
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

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
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ColourMinBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourMaxBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourMid()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Colour = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void MileageMinlessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void MileageMinBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "1";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MileageMinPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "2";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MileageMaxLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "299999";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MileageMaxBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "300000";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MileageMaxPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "3000011";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void MileageMid()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "150000";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MileageExtremeMax()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Mileage = "";
            //pad the data 
            Mileage = Mileage.PadRight(10, '1');
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeMinLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void BodyTypeMinBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeMinPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jkjj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeMaxLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jkjkjkjkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeMaxBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jkjkjkjkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeMaxPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jkjkjkjkjkjkjk";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeMid()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "jkjkjkj";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BodyTypeExtremeMax()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string BodyType = "";
            //pad the data 
            BodyType = BodyType.PadRight(50, 'j');
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
            
        }
        [TestMethod]
        public void AgeMinlessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AgeMinBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "1";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AgeMinPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "2";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AgeMaxLessOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "98";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AgeMaxBoundry()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "99";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AgeMaxPlusOne()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "100";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AgeMid()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "50";
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AgeExtremeMax()
        {
            //create an instance of the class we want 
            clsCar ACar = new clsCar();
            //booleon variable to store the result of the validation
            string Error = "";
            //create some data to assign to the property
            string Age = "";
            //pad the data 
            Mileage = Mileage.PadRight(10, '1');
            //invoke the method
            Error = ACar.Valid(CarModel, CarMake, Colour, Mileage, BodyType, Age);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");

        }

    }
}




  