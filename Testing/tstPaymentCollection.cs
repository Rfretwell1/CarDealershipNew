using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace Testing
{
    [TestClass]
    public class tstPaymentCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an istance of the class we want to create 
            
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an istance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();
        //test to see that is exists 
        Assert.IsNotNull(AllPayments);
        }
        
    }
}
