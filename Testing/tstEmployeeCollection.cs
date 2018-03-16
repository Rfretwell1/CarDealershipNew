using CarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstEmployeeCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //test to see if the class exists
            Assert.IsNotNull(AllEmployees);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 1;
            //assign the data to the property
            AllEmployees.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllEmployees.Count, SomeCount);
        }

        [TestMethod]
        public void AllCustomersOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection Customers = new clsEmployeeCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsEmployee> TestList = new List<clsEmployee>();
            //add an item to the list
            //create the item of test data
            clsEmployee TestItem = new clsEmployee();
            //set its properties
            TestItem.EmployeeNo = 4375;
            TestItem.FirstName = "John";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Customers.AllEmployees = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Customers.AllEmployees, TestList);
        }



    }
}
   

    

