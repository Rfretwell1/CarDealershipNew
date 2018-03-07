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
        public void SurnameNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment AnPayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "Stanley";
            //assign the data to the property 
            AnPayment.SurnameName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnPayment.SurnameName, TestData);
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
        public void TestEmployeeNoFound()
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


    }
}
