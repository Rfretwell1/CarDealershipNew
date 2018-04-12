using CarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomersOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection Customers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Ryan";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllCustomers = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.AllCustomers, TestList);
        }


        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class
            clsCustomerCollection AllCust = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCust);
        }
    
    [TestMethod]
    public void ListAndCountOK()
    {
        //create an instance of the class
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //create some test data
        List<clsCustomer> TestList = new List<clsCustomer>();
        //create the item
        clsCustomer TestItem = new clsCustomer();
        //set its properties
        TestItem.Active = true;
        TestItem.CustomerID = 1;
        TestItem.FirstName = "Ryan";
        TestItem.LastName = "Fretwell";
        TestItem.Address = "Somewhere";
        TestItem.PostCode = "LE30EB";
        TestItem.PhoneNumber = "07775734887";
        TestItem.EmailAddress = "ryan@ryan.com";
            TestItem.DateAdded = DateTime.Now.Date;
        //add the item
        TestList.Add(TestItem);
        //assign the data
        AllCustomers.CustomerList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllCustomers.CustomerList, TestList.Count);
    }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 21;
            TestItem.FirstName = "Ryan";
            TestItem.LastName = "Fretwell";
            TestItem.Address = "Somewhere";
            TestItem.PostCode = "LE30EB";
            TestItem.PhoneNumber = "07775734887";
            TestItem.EmailAddress = "ryan@ryan.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 21;
            TestItem.FirstName = "Ryan";
            TestItem.LastName = "Fretwell";
            TestItem.Address = "Somewhere";
            TestItem.PostCode = "LE30EB";
            TestItem.PhoneNumber = "07775734887";
            TestItem.EmailAddress = "ryan@ryan.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 21;
            TestItem.FirstName = "Ryan";
            TestItem.LastName = "Fretwell";
            TestItem.Address = "Somewhere";
            TestItem.PostCode = "LE30EB";
            TestItem.PhoneNumber = "07775734887";
            TestItem.EmailAddress = "ryan@ryan.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerID = 11;
            TestItem.FirstName = "Ryann";
            TestItem.LastName = "Fretwelll";
            TestItem.Address = "Somewheree";
            TestItem.PostCode = "LE20EB";
            TestItem.PhoneNumber = "07775734888";
            TestItem.EmailAddress = "ryan1@ryan.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }

}
////