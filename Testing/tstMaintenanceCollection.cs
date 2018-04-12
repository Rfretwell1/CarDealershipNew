using CarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace tstMaintenance
{

    [TestClass]
    public class tstMaintenanceCollection
    {
      [TestMethod] 
      public void TestMethod1()
      {
            //create an instance of the class we want to create 
            clsMaintenanceCollection AllMnt = new clsMaintenanceCollection();
            //test to see that it exists
            Assert.IsNotNull(AllMnt);
      }

        [TestMethod]
        public void MaintenanceListOk()
        {
            //create an isnatance of the class
            clsMaintenanceCollection AllMaintenance = new clsMaintenanceCollection();
            //create some test data
            List<clsMaintenance> TestList = new List<clsMaintenance>();
            //create the item
            clsMaintenance TestItem = new clsMaintenance();
            //set it properties
            TestItem.Active = true;
            TestItem.MaintenanceID = 1;
            TestItem.Cost = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Description = "something";
            TestItem.Repair = true;
            //add the item
            TestList.Add(TestItem);
            //assign the data
            AllMaintenance.MaintenanceList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllMaintenance.MaintenanceList, TestList);
        }

        [TestMethod]
        public void ThisMaintenanceProperyOK()
        {
            //create an isnatance of the class 
            clsMaintenanceCollection AllMaintenance = new clsMaintenanceCollection();
            //create the item
            clsMaintenance TestMaintenace = new clsMaintenance();
            //set it properties
            TestMaintenace.Active = true;
            TestMaintenace.MaintenanceID = 1;
            TestMaintenace.Cost = 1;
            TestMaintenace.Date = DateTime.Now.Date;
            TestMaintenace.Description = "something";
            TestMaintenace.Repair = true;
            //assign the data
            AllMaintenance.ThisMaintenance = TestMaintenace;
            //test to see that the two values are the same
            Assert.AreEqual(AllMaintenance.ThisMaintenance, TestMaintenace);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an isnatance of the class
            clsMaintenanceCollection AllMaintenance = new clsMaintenanceCollection();
            //create some test data
            List<clsMaintenance> TestList = new List<clsMaintenance>();
            //create the item
            clsMaintenance TestItem = new clsMaintenance();
            //set it properties
            TestItem.Active = true;
            TestItem.MaintenanceID = 1;
            TestItem.Cost = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Description = "something";
            TestItem.Repair = true;
            //add the item
            TestList.Add(TestItem);
            //assign the data
            AllMaintenance.MaintenanceList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllMaintenance.MaintenanceList, TestList.Count);
        }


        //[TestMethod]
        //public void CountProertyOK()
        //{
        //    //create an instance of the class we want to create 
        //    clsMaintenanceCollection AllMnt = new clsMaintenanceCollection();
        //    //Create some data to the propery 
        //    Int32 SomeCount = 2;
        //    //assign the data
        //    AllMnt.count = SomeCount;
        //    //test to see that the two value are the same
        //    Assert.AreEqual(AllMnt.count, SomeCount);
        //}

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an isntance of the class
            clsMaintenanceCollection AllMaintenance = new clsMaintenanceCollection();
            //test to see that two values are the same
            Assert.AreEqual(AllMaintenance.count, 2);

        }

        [TestMethod]
        public void ThisMaintenancePropertyOk()
        {
            //create an instance of the class we want to create
            clsCarCollection AllMaintenace = new clsCarCollection();
            //create some test data to assign to the property
            clsMaintenance TestMaitenance = new clsMaintenance();
            //set the properties of the test object
            TestMaitenance.Active = true;
            TestMaitenance.MaintenanceID = 1;
            TestMaitenance.Cost = 1;
            TestMaitenance.Date = DateTime.Now.Date;
            TestMaitenance.Description = "something";
            TestMaitenance.Repair = true;
            //assign the data to the property
            AllMaintenace.ThisMaitenance = TestMaitenance;
            //test to see that the two values are the same
            Assert.AreEqual(AllMaintenace.ThisMaitenance, TestMaitenance);

        }

        [TestMethod]
        public void UpdateMethodOk()
        {

            //create an instance of the class we want to create
            clsCarCollection AllMainteance = new clsCarCollection();
            //create the item of test data
            clsMaintenance TestItem = new clsMaintenance();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.MaintenanceID = 1;
            TestItem.Cost = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Description = "something";
            TestItem.Repair = true;
            //add the item
            //set ThisCar to the test data
            AllMainteance.ThisMaitenance = TestItem;
            //add record 
            PrimaryKey = AllMainteance.Add();
            //set the pirmary key
            TestItem.MaintenanceID = PrimaryKey;
            //modify the test data 
            TestItem.Active = true;
            TestItem.MaintenanceID = 1;
            TestItem.Cost = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Description = "something";
            TestItem.Repair = true;
            //set the reocrd 
            AllMainteance.ThisMaitenance = TestItem;
            //find the record
            AllMainteance.Update();
            //find the reocrd 
            AllMainteance.ThisMaitenance.Find(PrimaryKey);
            //test to see thismainatenace the test data
            Assert.AreEqual(AllMainteance.ThisMaitenance, TestItem);


        }

        [TestMethod]

        public void AddMethodOk()
        {

            //create an instance of the class we want to create
            clsCarCollection AllMainteance = new clsCarCollection();
            //create the item of test data
            clsMaintenance TestItem = new clsMaintenance();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.MaintenanceID = 1;
            TestItem.Cost = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Description = "something";
            TestItem.Repair = true;
            //add the item
            //set ThisCar to the test data
            AllMainteance.ThisMaitenance = TestItem;
            //add the record
            PrimaryKey = AllMainteance.Add();
            //set the primary key of the test data
            TestItem.MaintenanceID = PrimaryKey;
            //find the record
            AllMainteance.ThisCar.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllMainteance.ThisMaitenance, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOk()
        {

            //create an instance of the class we want to create
            clsCarCollection AllMainteance = new clsCarCollection();
            //create the item of test data
            clsMaintenance TestItem = new clsMaintenance();
            //var to store the primary key
            int PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.MaintenanceID = 1;
            TestItem.Cost = 1;
            TestItem.Date = DateTime.Now.Date;
            TestItem.Description = "something";
            TestItem.Repair = true;
            //add the item
            //set ThisCar to the test data
            AllMainteance.ThisMaitenance = TestItem;
            //add the record
            PrimaryKey = AllMainteance.Add();
            //set the primary key of the test data
            AllMainteance.ThisCar.Find(PrimaryKey);
            //Delete
            AllMainteance.Delete();
            //now find the record
            Boolean Found = AllMainteance.ThisMaitenance.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);

        }

        //[TestMethod]
        //public void FilterByDescriptionOk()
        //{
        //    //create an instance of the class
        //    clsMaintenanceCollection AlMnt = new clsMaintenanceCollection();
        //    //create an instance of the filter
        //    clsMaintenanceCollection FilteredMaintenace = new clsMaintenanceCollection();
        //    //apply the blank spring
        //    FilteredMaintenace.FilterByDescription("");
        //    //test to see if the two are the same 
        //    Assert.AreEqual(AlMnt.count, FilteredMaintenace.count);


        //}



        [TestMethod]
        public void AllMaintenance()
        {
            
        }




    }
}
