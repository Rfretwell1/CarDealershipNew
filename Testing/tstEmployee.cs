using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace TestFrameWork
{
    [TestClass]
    public class tstEmployee // eileen 
    {

        //test data values
        string FirstName= "John";
        string LastName = "Jo";
        string Address = "65 Creford Lane";
        string PostCode = "LE1 5SP";
        string DateJoined = DateTime.Now.Date.ToString();
        string Jobtitle = " Mechanic";
        string EmailAddress = "JoJo@gmail.com";
        string PhoneNumber = "07951017996";
        
        

        [TestMethod]
        public void InstanceOK()
        {
            // create and instance of the class 
            clsEmployee AnEmployee = new clsEmployee();
            //test
            Assert.IsNotNull(AnEmployee);
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


     
        // starts oif the first name testing 

        [TestMethod]
        //used to test the property of the class
        public void FirstNameOK()
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

        [TestMethod]
        //test that the Employee validation throws an error when first name is blank
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

        [TestMethod]
        public void FirstNameMidOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOneOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "sdfgsdgvdsgdsgdvsvfsdvsdvfdsvdfghi";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMaxOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "";
            //pad the string with a charcaters
            FirstName = FirstName.PadRight(500, 'h');
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOneOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameBoundary()
        {

            //create an instance of the class
            clsEmployee AnEmployee = new clsEmployee();
            //create a variable to record the result of the validation test
            Boolean OK = false;
            //create some test data to asight to the property 
            string SomeFirstName = "";
            //invoke the method 
            OK = AnEmployee.Valid(SomeFirstName);
            // test to see that the result is correct 
            Assert.IsFalse(OK);
        }
      

        [TestMethod]
        public void FirstNameMaxBoundaryOK()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "a";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "aa";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //END OF FIRST NAME TESTING 

        // START ON LAST NAME TESTING 

        public void LastNameOK()
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


        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "";
            //pad the string with a charcaters
            LastName = LastName.PadRight(500, 'a');
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber, Jobtitle);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "a";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        /// <summary>
        //END OF LAST NAME TESTING 
        // ADDRESS TESTING 
        [TestMethod]
        public void AddressOk()
        {
            //create an instane of the new class 
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            string TestData = "23 Cough Road";
            //assign the data to the property
            AnEmployee.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.Address, TestData);
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "";
            //pad the string with a charcaters
            Address = Address.PadRight(500, 'a');
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "sdfsdfdsfsddsfsfabcde";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "a";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsEmployee AnEmployee = new clsEmployee();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "aa";
            //invoke the method
            Error = AnEmployee.Valid(FirstName, LastName, Address, PostCode, DateJoined, EmailAddress, PhoneNumber,Jobtitle);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        // END OF ADDRESS TESTING 
  


            // START OF MOBILE PROPERTY TETING 
        [TestMethod]
        public void PhoneNumberPropertyOk()
        {
            //create an instane of the new class 
            clsEmployee AnEmployee = new clsEmployee();
            // test data to assign to the property
            string TestData = "07941017889";
            //assign the data to the property
            AnEmployee.PhoneNumber = TestData;
            //test to see if the same 
            Assert.AreEqual(AnEmployee.PhoneNumber, TestData);
        }

     



        // END OF EMOBILE PROPERTY TESTING 

        public void DateJoinedOk()
        {
            //create an instane of the new class 
            clsEmployee AnEmployee = new clsEmployee();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnEmployee.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnEmployee.DateJoined, TestData);
        }




        public void ActiveEmployee()
        {
            //create an instane of the class we want to create 
            clsEmployee AnEmployee = new clsEmployee();
            //
            Boolean TestData = true;
            //
            AnEmployee.Active = TestData;
            //test
            Assert.AreEqual(AnEmployee.Active, TestData);
        }
    }

        }

