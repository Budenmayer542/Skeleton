using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void SupplierActiveOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.Active = TestData;
            Assert.AreEqual(AnSupplier.Active, TestData);
        }

        [TestMethod]
        public void SupplierDateAddedOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DateAdded = TestData;
            Assert.AreEqual(AnSupplier.DateAdded, TestData);
        }
    }

   
}
