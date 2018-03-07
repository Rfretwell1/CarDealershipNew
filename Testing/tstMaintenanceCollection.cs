using CarClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tstMaintenance
{
    [TestClass]
    class tstMaintenanceCollection
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
        public void CountProertyOK()
        {
            //create an instance of the class we want to create 
            clsMaintenanceCollection AllMnt = new clsMaintenanceCollection();
            //Create some data to the propery 
            Int32 SomeCount = 1;
            //assign the data
            AllMnt.count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllMnt.count, SomeCount);
        }

        [TestMethod]
        public void AllMaintenanceOk()
        {
            
        }




    }
}
