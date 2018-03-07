using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstEmployee // eileen 
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create and instance of the class 
            clsEmployee ACounty = new clsEmployee();
        }

        [TestMethod]
        //used to test the County property of the class
        public void FirstName()
        {

            //create an instance of the class
            clsEmployee AnEmployee = new clsEmployee();
            //create a variable to store the name of a county
            string SomeEmployee;
            //assign a county to the variable
            SomeEmployee = "John";
            //try to send some data to the Employee property
            AnEmployee.Employee = SomeEmployee;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnEmployee.Employee, SomeEmployee);

        }


        public void LastName()
        {

            //create an instance of the class
            clsEmployee AnEmployee = new clsEmployee();
            //create a variable to store the name of a county
            string SomeEmployee;
            //assign a county to the variable
            SomeEmployee = "Micheal";
            //try to send some data to the Employee property
            AnEmployee.Employee = SomeEmployee;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnEmployee.Employee, SomeEmployee);

        }

        [TestMethod]
        //used to test the EmployeeNo property of the class
        public void EmployeeNo()
        {
            //create an instance of the class
            clsEmployee AnEmployee = new clsEmployee();
            //create a variable to store the Id of a Employee
            Int32 EmployeeNo;
            //assign a value to the variable
            EmployeeNo = 123;
            //try to send some data to the EmployeeNo property
            AnEmployee.EmployeeNo = EmployeeNo;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AnEmployee.EmployeeNo, EmployeeNo);
        }


        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class
            clsEmployee AnEmployee = new clsEmployee();
            //test to see if the valid method exists
            AnEmployee.Valid("Mark");
        }


        [TestMethod]
        //test that the county validation throws an error when first name is blank
        public void FisrtNameMinLessOne()
        {
            //create an instance of the class
            clsEmployee AFirstName = new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a blank string
            OK = AFirstName.Valid("");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNamePlusOne()
        {
            //create an instance of the class
            clsEmployee AFirstName = new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "gfherhyrhydfhdfyfrghsdtseryscfhdhjugftjgfju";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(21);
            //test the valid method with a two character string
            OK = AFirstName.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }


        public void LastNameMinLessOne()
        {
            //create an instance of the class
            clsEmployee ALastName = new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK;
            //test the valid method with a blank string
            OK = ALastName.Valid("");
            //assert that the outcome should be false
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void LastNamePlusOne()
        {
            //create an instance of the class
            clsEmployee ALastName= new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK;
            //create a variable to store the test data
            string SomeText = "gfherhyrhydfhdfyfrghsdtseryscfhdhjugftjgfju";
            //pad the data to the required number of characters
            SomeText = SomeText.PadLeft(21);
            //test the valid method with a two character string
            OK = ALastName.Valid(SomeText);
            //assert that the outcome should be true
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNameBoundary()
        {

            //create an instance of the class
            clsEmployee AFirstName = new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK = false;
            //create some test data to asight to the property 
            string SomeFirstName = "";
            //invoke the method 
            OK = AFirstName.Valid(SomeFirstName);
            // test to see that the result is correct 
            Assert.IsFalse(OK);
        }

        public void LastNameBoundary()
        {

            //create an instance of the class
            clsEmployee ALastName = new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK = false;
            //create some test data to asight to the property 
            string SomeLastName = "";
            //invoke the method 
            OK = ALastName.Valid(SomeLastName);
            // test to see that the result is correct 
            Assert.IsFalse(OK);
        }
    }

        }

