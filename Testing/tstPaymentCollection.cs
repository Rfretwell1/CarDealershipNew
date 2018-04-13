using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;
using System.Collections.Generic;


namespace Testing
{
    [TestClass]
    public class tstPaymentCollection
    {
        public object TestPayment { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
            //create an istance of the class we want to create 

        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that is exists 
            Assert.IsNotNull(AllPayments);
        }

        [TestMethod]
        public void PaymentListOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list 
            //create the item of test data 
            clsPayment TestItem = new clsPayment();
            //set its properties
            TestItem.Active = true;
            TestItem.PaymentNo = 111344455;
            TestItem.FirstName = "Ben";
            TestItem.Surname = "Stark";
            TestItem.CarID = "C12321";
            TestItem.EmployeeID = "EM13243";
            TestItem.Description = "MOT";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 50.00;
            //add the item to the test List
            TestList.Add(TestItem);
            //assign the data to the property 
            AllPayments.PaymentList = TestList;
            //test the see that the two values are the same 
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 2;
            //assinn the data to the property 
            AllPayments.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllPayments.Count, SomeCount);

        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we wnat tot crate 
            clsEmployee AnPayment = new clsEmployee();
            // boolean variable to store the validation 
            Boolean Found = false;
            // create some test datra to use with the mehtod 
            Int32 PaymentNo = 1;
            // invoke the method
            Found = AnPayment.Find(PaymentNo);
            // test to see tyhay the result ius correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property
            //create the item of test data 
            clsPayment TestItem = new clsPayment();
            //set its properties of the object
           
            TestItem.PaymentNo = 11344455;
            TestItem.FirstName = "Ben";
            TestItem.Surname = "Stark";
            TestItem.CarID = "C12321";
            TestItem.EmployeeID = "EM13243";
            TestItem.Description = "MOT";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 50.00;
            //assign the data to the property 
            AllPayments.ThisPayment = TestPayment;
            //test the see that the two values are the same 
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            List<clsPayment> TestList = new List<clsPayment>();
            //add an item to the list 
            //create the item of the test data 
            clsPayment TestItem = new clsPayment();
            //set its properties 

            TestItem.PaymentNo = 11344455;
            TestItem.FirstName = "Ben";
            TestItem.Surname = "Stark";
            TestItem.CarID = "C12321";
            TestItem.EmployeeID = "EM13243";
            TestItem.Description = "MOT";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 50.00;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data ton the property
            AllPayments.PaymentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);

        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //test to see that the two class we want to create 
            Assert.AreEqual(AllPayments.Count, 2);


        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
            //create the item of the test data 
            clsPayment TestItem = new clsPayment();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.PaymentNo = 11344455;
            TestItem.FirstName = "Ben";
            TestItem.Surname = "Stark";
            TestItem.CarID = "C12321";
            TestItem.EmployeeID = "EM13243";
            TestItem.Description = "MOT";
            TestItem.DateTime = DateTime.Now.Date;
            TestItem.Cost = 50.00;
            //set the primary key of the test data 
            TestItem.PaymentNo = PrimaryKey;
            //find the record 
            AllPayments.ThisPayment.Find(PrimaryKey);
            //test to see that two values are the same 
            Assert.AreEqual(AllPayments.ThisPayment, TestItem);




        }
    }
}
