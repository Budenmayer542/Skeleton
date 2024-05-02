using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrders = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrders);
        }
    }
}
