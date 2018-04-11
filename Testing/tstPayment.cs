using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace tstPayment
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
                //test to see that it exists 
                Assert.IsNotNull(AnPayment);

        }

        [TestMethod]
        public void PaymentNoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property 
            AnPayment.PaymentNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.PaymentNo, TestData);
        }

        [TestMethod]
         public void CarIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "C1332D";
            //assign the data to the property 
            AnPayment.CarID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.CarID, TestData); 
        }

        [TestMethod]
        public void CostPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            Double TestData = 3.00;
            //asign the data to the property 
            AnPayment.Cost = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Cost, TestData);
        }

        [TestMethod]
        public void DateTimePropertyOK() 
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            DateTime TestData = Convert.ToDateTime( "22/02/2016");
            //assign the data to the property 
            AnPayment.DateTime = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.DateTime, TestData);
        }

       
         [TestMethod]
        public void DescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Car MOT";
            //assign the data to the property 
            AnPayment.Description = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Description, TestData);
        }

        [TestMethod]
        public void EmployeeIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "E12334534";
            //assign the data to the property 
            AnPayment.EmployeeID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.EmployeeID, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "John";
            //assign the data to the property 
            AnPayment.FirstName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.FirstName, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Stanley";
            //assign the data to the property 
            AnPayment.Surname = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.Surname, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with method
            Int32 PaymentNo = 21;
            //invoke the mothod 
            Found = AnPayment.Find(PaymentNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void TestPaymentNoFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PaymentNo = 21;
            //string EmployeeID = "E12345";
            //invoke the method 
            Found = AnPayment.Find(PaymentNo);
            //check the address no 
            if (AnPayment.PaymentNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correctr 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarIDFound()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 PaymentNo = 21;
            //invoke the method 
            Found = AnPayment.Find(PaymentNo);
            //check the Property
            if (AnPayment.CarID != "Test CarID")
            {
                OK = false;
            }
            //test to see that the result is correctr 
            Assert.IsTrue(OK);
        }

       [TestMethod]
        public void CarIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = ""; 
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarIDMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "0";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CarIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "CC";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CarIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(49, 'a');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(51, 'a');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarIDMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(50, 'a');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarIDMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(25, 'a');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void CarIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentID = "P11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(500, 'a');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentID, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
    }
}
