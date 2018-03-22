using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarClassLibrary;

namespace Testing
{
    [TestClass]
    public class tstCarCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
             clsCarCollection AllCars  = new clsCarCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCars);
        }


    }
}
