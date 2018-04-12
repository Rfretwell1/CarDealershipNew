using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace Testing
{




    [TestClass]
    public class tstCustomer
    {

        //test data values
        string FirstName = "fred";
        string LastName = "bloggs";
        string Address = "some street";
        string PostCode = "LE1 123";
        string DateAdded = DateTime.Now.Date.ToString();
        string EmailAddress = "bob@bob.com";
        string PhoneNumber = "0116 1234567";

        [TestMethod]
        public void InstanceOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //test
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActiveCustomerOk()
        {
            //create an instane of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //
            Boolean TestData = true;
            //
            AnCustomer.Active = TestData;
            //test
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21B";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Ryan";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Fretwell";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE3 0EB";
            //assign the data to the property
            AnCustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "p15238469@my365.dmu.ac.uk";
            //assign the data to the property
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOk()
        {
            //create an instane of the new class 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07123456789";
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "";
            //pad the string with a charcaters
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMisLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            FirstName = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            LastName = "";
            //pad the string with a charcaters
            LastName = LastName.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMisLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            EmailAddress = "";
            //pad the string with a charcaters
            EmailAddress = EmailAddress.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMisLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            Address = "";
            //pad the string with a charcaters
            Address = Address.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMidLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PostCode = "";
            //pad the string with a charcaters
            PostCode = PostCode.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMisLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is ok
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "abcdeafghijabcdefghijabcdefghijabcdefghijabcdefghi";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "abcdefghijabcdefghijabcde";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            string Error = "";
            //create some test data to assign the property
            PhoneNumber = "";
            //pad the string with a charcaters
            PhoneNumber = Address.PadRight(500, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DateAdded, EmailAddress, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use within the method
            Int32 CustomerID = 21;
            Found = AnCustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address number
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the address number
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


       [TestMethod]
        public void TestDateAddedFound()
        {
            {
                //create an instance of the class we want to create
                clsCustomer AnCustomer = new clsCustomer();
                //boolean variable to store the result of the search 
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 21;
                //invoke the method
                Found = AnCustomer.Find(CustomerID);
                //check the address number
                if (AnCustomer.DateAdded != Convert.ToDateTime("16/10/2017"))
                {
                    OK = false;
                }
                //        //test to see that the result is correct
                Assert.IsTrue(OK);
            }
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            {
                //create an instance of the class we want to create
                clsCustomer AnCustomer = new clsCustomer();
                //boolean variable to store the result of the search 
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 21;
                //invoke the method
                Found = AnCustomer.Find(CustomerID);
                //check the address number
                if (AnCustomer.FirstName != "ryan")
                {
                    OK = false;
                }
                //        //test to see that the result is correct
                Assert.IsTrue(OK);
            }
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            {
                //create an instance of the class we want to create
                clsCustomer AnCustomer = new clsCustomer();
                //boolean variable to store the result of the search 
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 21;
                //invoke the method
                Found = AnCustomer.Find(CustomerID);
                //check the address number
                if (AnCustomer.LastName != "Fretwell")
                {
                    OK = false;
                }
                //        //test to see that the result is correct
                Assert.IsTrue(OK);
            }

        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            {
                //create an instance of the class we want to create
                clsCustomer AnCustomer = new clsCustomer();
                //boolean variable to store the result of the search 
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 21;
                //invoke the method
                Found = AnCustomer.Find(CustomerID);
                //check the address number
                if (AnCustomer.PhoneNumber != "07775734887")
                {
                    OK = false;
                }
                //        //test to see that the result is correct
                Assert.IsTrue(OK);
            }
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            {
                //create an instance of the class we want to create
                clsCustomer AnCustomer = new clsCustomer();
                //boolean variable to store the result of the search 
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 CustomerID = 21;
                //invoke the method
                Found = AnCustomer.Find(CustomerID);
                //check the address number
                if (AnCustomer.EmailAddress != "ryan@ryan.com")
                {
                    OK = false;
                }
                //        //test to see that the result is correct
                Assert.IsTrue(OK);
            }
        }
    }
}