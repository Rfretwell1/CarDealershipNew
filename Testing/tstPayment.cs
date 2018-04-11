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
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = ""; 
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "0";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C1";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(49, '1');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(51, '1');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(50, '1');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(25, '1');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
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
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "";
            CarID = CarID.PadRight(500, '1');
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentNoMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            PaymentNo= PaymentNo.PadRight(49, '1');
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            PaymentNo = PaymentNo.PadRight(51, '1');
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PaymentNoMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            PaymentNo = PaymentNo.PadRight(50, '1');
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PaymentNoMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            PaymentNo = PaymentNo.PadRight(25, '1');
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PaymentNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            PaymentNo = PaymentNo.PadRight(500, '1');
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }



        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "B";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "BB";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'B');
            string Surname = "Stark";
            string CarID = "12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "";
            PaymentNo = PaymentNo.PadRight(50, 'B');
            string Surname = "Stark";
            string CarID = "12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'B');
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "C11344455";
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'B');
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'B');
            string Surname = "Stark";
            string CarID = "12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "S";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "St";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "";
            Surname = Surname.PadRight(49, 'S');
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "St";
            Surname = Surname.PadRight(50, 'S');
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "St";
            Surname = Surname.PadRight(51, 'S');
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "";
            Surname = Surname.PadRight(25, 'S');
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SurnameExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "1";
            string FirstName = "Ben";
            string Surname = "";
            Surname = Surname.PadRight(500, 'S');
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeIDMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "E";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");
            
        }

        [TestMethod]
        public void EmployeeIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "";
            EmployeeID = EmployeeID.PadRight(51, 'E');
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");
            
        }

        [TestMethod]
        public void EmployeeIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "";
            EmployeeID = EmployeeID.PadRight(49, 'E');
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeIDMaxBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "";
            EmployeeID = EmployeeID.PadRight(50, 'E');
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmployeeIDMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "";
            EmployeeID = EmployeeID.PadRight(25, 'E');
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void EmployeeIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "";
            EmployeeID = EmployeeID.PadRight(500, 'E');
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MO";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "M";
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "";
            Description = Description.PadRight(49, 'M');
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DescriptionMaxBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "";
            Description = Description.PadRight(50, 'M');
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "";
            Description = Description.PadRight(51, 'M');
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "";
            Description = Description.PadRight(25, 'M');
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "";
            Description = Description.PadRight(500, 'M');
            string DateTime = "21/08/2017";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateTimeMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateTimeMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "2";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateTimeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21";
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateTimeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "";
            DateTime = DateTime.PadRight(49, '1');
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateTimeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "";
            DateTime = DateTime.PadRight(50, '1');
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateTimeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "";
            DateTime = DateTime.PadRight(51, '1');
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateTimeMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "";
            DateTime = DateTime.PadRight(25, '1');
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateTimeExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "";
            DateTime = DateTime.PadRight(500, '1');
            string Cost = "50.00";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "";
            string FirstName = "";
            string Surname = "";
            string CarID = "";
            string EmployeeID = "";
            string Description = "";
            string DateTime = "";
            string Cost = "";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMinBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "5";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "50";
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "";
            Cost = Cost.PadRight(49, '5');
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMaxBoundary()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "";
            Cost = Cost.PadRight(50, '5');
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "";
            Cost = Cost.PadRight(51, '5');
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostMid()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "";
            Cost = Cost.PadRight(25, '5');
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CostExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment AnPayment = new clsPayment();
            //boolean variable to store the result of the validation 
            string Error = "";
            //create some test data to assign the property     
            string PaymentNo = "11344455";
            string FirstName = "Ben";
            string Surname = "Stark";
            string CarID = "C12321";
            string EmployeeID = "EM13243";
            string Description = "MOT";
            string DateTime = "21/08/2017";
            string Cost = "";
            Cost = Cost.PadRight(500, '5');
            //invoke the method
            Error = AnPayment.Valid(PaymentNo, FirstName, Surname, CarID, EmployeeID, Description, DateTime, Cost);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        
        
      
    }
}
