using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace tstMaintenance
{
    [TestClass]
    public class tstMaintenance
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance
            clsMaintenance AMaintenance = new clsMaintenance();
            //test to see that exists
            Assert.IsNotNull(AMaintenance);
        }
        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property 
            AnMaintenance.Active = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Active, testData);
        }

        [TestMethod]
        public void MaintenanceIDPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property 
            AnMaintenance.Active = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Active, testData);
        }

        [TestMethod]
        public void RepairIDPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Boolean testData = true;
            //assign the data to the property 
            AnMaintenance.Active = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Active, testData);
        }

//Descption Test

        [TestMethod]
        public void DescriptionPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            String testData = "a car";
            //assign the data to the property
            AnMaintenance.Description = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Description, testData);
        }

        [TestMethod]
        public void DescriptionLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            //create some test data to assign to the property 
            string TestDescription = "";
            TestDescription = TestDescription.PadRight('a');
            string TestCost="1.00";
            string TestDate=DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription,TestCost,TestDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error,"");
        }

        [TestMethod]
        public void DescriptionMinBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "";
            TestDescription = TestDescription.PadRight(1, 'a');
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void DescriptionPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "";
            TestDescription = TestDescription.PadRight(2, 'a');
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription="";
            TestDescription = TestDescription.PadRight(49, 'a');
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void DescriptionMaxBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "";
            TestDescription = TestDescription.PadRight(50, 'a');
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "";
            TestDescription = TestDescription.PadRight(51, 'a');
            string TestCost = "1.00";
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error,"");
        }


//Cost Test


        [TestMethod]
        public void CostPropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            Int32 testData = 1;
            //assign the data to the property
            AnMaintenance.Cost = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Cost, testData);
        }



        [TestMethod]
        public void CostLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            //create some test data to assign to the property 
            string TestDescription = "a";
            string TestCost = "";
            TestCost = TestCost.PadRight('a');
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error,"");
        }

        [TestMethod]
        public void CostMinBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            TestCost = TestCost.PadRight(1, 'a');
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void CostPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            TestCost = TestCost.PadRight(2, 'a');
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void CostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            TestCost = TestCost.PadRight(49, 'a');
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void CostMaxBoundary()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            TestCost = TestCost.PadRight(50, 'a');
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            TestCost = TestCost.PadRight(51, 'a');
            string TestDate = DateTime.Now.Date.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, TestDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error,"");
        }


        //Date Test 

        [TestMethod]
        public void DatePropertyOk()
        {
            //create an instance of the class we want to create
            clsMaintenance AnMaintenance = new clsMaintenance();
            //create some test data to assign to the property
            DateTime testData = DateTime.Now.Date;
            //assign the data to the property
            AnMaintenance.Date = testData;
            //test to see that that two values are the same 
            Assert.AreEqual(AnMaintenance.Date, testData);
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            //create the variable
            DateTime TestDate;
            //set the date today
            TestDate = DateTime.Now.Date;
            //change the to less than 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert the date varialbe to string varibale
            string Date = TestDate.ToString(); 
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            //create the variable
            DateTime TestDate;
            //set the date today
            TestDate = DateTime.Now.Date;
            //change the to less than 100 years ago
            TestDate = TestDate.AddDays(-1);
            //convert the date varialbe to string varibale
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            //create the variable
            DateTime TestDate;
            //set the date today
            TestDate = DateTime.Now.Date;
            //convert the date varialbe to string varibale
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            //create the variable
            DateTime TestDate;
            //set the date today
            TestDate = DateTime.Now.Date;
            //change the to less than 100 years ago
            TestDate = TestDate.AddDays(1);
            //convert the date varialbe to string varibale
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            //create the variable
            DateTime TestDate;
            //set the date today
            TestDate = DateTime.Now.Date;
            //change the to less than 100 years ago
            TestDate = TestDate.AddYears(100);
            //convert the date varialbe to string varibale
            string Date = TestDate.ToString();
            //invoke the method 
            Error = AMaitenance.Valid(TestDescription, TestCost, Date);
            //test to see that the result iss correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateInvalidDate()
        {
            //create an instance of the class we want to create
            clsMaintenance AMaitenance = new clsMaintenance();
            //boolean variable to store the results of the vaildation 
            string Error = "";
            string TestDescription = "a";
            string TestCost = "";
            //create the variable
            string Date = "this is not date";
            //invoke the method
            Error = AMaitenance.Valid(TestDescription, TestCost, Date);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        //find method

        [TestMethod]
        public void FindMethodOK()
        {
            //create an insatnce of nthe class we want to create
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean variable to store the seslut of the vaildation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 MaintenanceNo = 21;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestMaintenanceIDFound()
        {
            //create an instance of the class 
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean varialbe to store the result 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with method
            Int32 MaintenanceID = 12;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceID);
            //check the maintenance
            if (anMaintenance.MaintenanceID != 12)
                {
                Ok = false;
               }
            //test to see that the resuts is correct 
            Assert.IsTrue(Ok);
          
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class 
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean varialbe to store the result 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with method
            Int32 MaintenanceID = 12;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceID);
            //check the maintenance
            if (anMaintenance.Active != true)
            {
                Ok = false;
            }
            //test to see that the resuts is correct 
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestCostFound()
        {
            //create an instance of the class 
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean varialbe to store the result 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with method
            Int32 MaintenanceID = 12;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceID);
            //check the maintenance
            if (anMaintenance.Cost != 1)
            {
                Ok = false;
            }
            //test to see that the resuts is correct 
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class 
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean varialbe to store the result 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with method
            Int32 MaintenanceID = 12;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceID);
            //check the maintenance
            if (anMaintenance.Date != Convert.ToDateTime("16/09/2017"))
            {
                Ok = false;
            }
            //test to see that the resuts is correct 
            Assert.IsTrue(Ok);

        }

        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class 
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean varialbe to store the result 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with method
            Int32 MaintenanceID = 12;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceID);
            //check the maintenance
            if (anMaintenance.Description != "test description")
            {
                Ok = false;
            }
            //test to see that the resuts is correct 
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void TestRepairFound()
        {
            //create an instance of the class 
            clsMaintenance anMaintenance = new clsMaintenance();
            //boolean varialbe to store the result 
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean Ok = true;
            //create some test data to use with method
            Int32 MaintenanceID = 12;
            //invoke the method
            Found = anMaintenance.Find(MaintenanceID);
            //check the maintenance
            if (anMaintenance.Repair != true)
            {
                Ok = false;
            }
            //test to see that the resuts is correct 
            Assert.IsTrue(Ok);

        }

    }
}
