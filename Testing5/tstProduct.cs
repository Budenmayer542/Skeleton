using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Test its existance
            Assert.IsNotNull(AProduct);
        }
    }
}
