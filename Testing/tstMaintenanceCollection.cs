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


        [TestMethod]
        public void CountProertyOK()
        {
            //create an instance of the class we want to create 
            clsMaintenanceCollection AllMnt = new clsMaintenanceCollection();
            //Create some data to the propery 
            Int32 SomeCount = 0;
            //assign the data
            AllMnt.count = SomeCount;
            //test to see that the two value are the same
            Assert.AreEqual(AllMnt.count, SomeCount);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an isntance of the class
            clsMaintenanceCollection AllMaintenance = new clsMaintenanceCollection();
            //test to see that two values are the same
            Assert.AreEqual(AllMaintenance.count, 2);

        }

        [TestMethod]
        public void AllMaintenanceOk()
        {
            
        }




    }
}
