using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer1
    {
        [TestMethod]
        public void Instanceok()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it's exists
            Assert.IsNotNull(AnCustomer);
        }
    }
}
