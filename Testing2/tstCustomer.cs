using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        private object TestData;

        [TestMethod]
        public void Instanceok()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
    }
}
