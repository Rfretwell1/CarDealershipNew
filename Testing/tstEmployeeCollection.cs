using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;
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
        public void EmployeelistOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection Employees = new clsEmployeeCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsEmployee> TestList = new List<clsEmployee>();
            //add an item to the list
            //create the item of test data
            clsEmployee TestItem = new clsEmployee();
            //set its properties
            TestItem.Active = true;
            TestItem.EmployeeNo = 4375;
            TestItem.FirstName = "John";
            TestItem.LastName = "Make";
          
            TestItem.Address = " 11 donald Road";
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.PostCode = " KT6 8RJ";
            TestItem.EmailAddress = " JM@gmail.com";
            TestItem.PostCode = "07838774833";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            Employees.EmployeeList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Employees.EmployeeList, TestList);
        }
        //testing to see if it will work

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we wnat tot crate 
            clsEmployee AnEmployee = new clsEmployee();
            // boolean variable to store the validation 
            Boolean Found = false;
            // create some test datra to use with the mehtod 
            Int32 EmployeeNo = 1;
            // invoke the method
            Found = AnEmployee.Find(EmployeeNo);
            // test to see tyhay the result ius correct
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void ThisEmployeePropertyOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            // create some test data to asign toi the property
            clsEmployee TestEmployee = new clsEmployee();
            TestEmployee.Active = true;
            TestEmployee.EmployeeNo = 4375;
            TestEmployee.FirstName = "John";
            TestEmployee.LastName = "Make";
          
            TestEmployee.Address = " 11 donald Road";
            TestEmployee.DateJoined = DateTime.Now.Date;
            TestEmployee.PostCode = " KT6 8RJ";
            TestEmployee.EmailAddress = " JM@gmail.com";
            TestEmployee.PostCode = "07838774833";
            // asign data to this property 
            AllEmployees.ThisEmployee = TestEmployee;
            // test to see f the two value are the same 
            Assert.AreEqual(AllEmployees.ThisEmployee, TestEmployee);

        }


        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsEmployeeCollection Employees = new clsEmployeeCollection();
            //create some test data to assign to the property
            //in this case the data will be a list of objects
            List<clsEmployee> TestList = new List<clsEmployee>();
            //add an item to the list
            //create the item of test data
            clsEmployee TestEmployee = new clsEmployee();
            //set its properties
            TestEmployee.Active = true;
            TestEmployee.EmployeeNo = 4375;
            TestEmployee.FirstName = "John";
            TestEmployee.LastName = "Make";
        
            TestEmployee.Address = " 11 donald Road";
            TestEmployee.DateJoined = DateTime.Now.Date;
            TestEmployee.PostCode = " KT6 8RJ";
            TestEmployee.EmailAddress = " JM@gmail.com";
            TestEmployee.PostCode = "07838774833";
            //add the item to the test list
            TestList.Add(TestEmployee);
            //assign the data to the property
            Employees.EmployeeList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(Employees.EmployeeList, TestList);
        }





    [TestMethod]
    public void AddMethodOK()
    {
            clsEmployeeCollection AllEmployees = new clsEmployeeCollection();
            // create the item of test data
            clsEmployee TestEmployee = new clsEmployee();
            // var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its propertys
                 TestEmployee.Active = true;
            TestEmployee.EmployeeNo = 4375;
            TestEmployee.FirstName = "John";
            TestEmployee.LastName = "Make";
            
            TestEmployee.Address = " 11 donald Road";
            TestEmployee.DateJoined = DateTime.Now.Date;
            TestEmployee.PostCode = " KT6 8RJ";
            TestEmployee.EmailAddress = " JM@gmail.com";
            TestEmployee.PostCode = "07838774833";
            // set thius employee to test data 
            AllEmployees.ThisEmployee = TestEmployee;
            // add the record 
       //     PrimaryKey = AllEmployees.Add();


        }
    }


    }
