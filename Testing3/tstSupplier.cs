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
        public void SupplierIdOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 1;
            AnSupplier.SupplierId = TestData;
            Assert.AreEqual(AnSupplier.SupplierId, TestData);
        }

        [TestMethod]
        public void SupplierNameOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "Manga Limited";
            AnSupplier.SupplierName = TestData;
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }

        [TestMethod]
        public void ContactPersonOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "jhon mayer";
            AnSupplier.ContactPerson = TestData;
            Assert.AreEqual(AnSupplier.ContactPerson, TestData);
        }

        [TestMethod]
        public void SupplierEmailOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "MangaLimited@outlook.com";
            AnSupplier.SupplierEmail = TestData;
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
        }

        [TestMethod]
        public void SupplierTelephoneOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            string TestData = "07748492017";
            AnSupplier.SupplierTelephone = TestData;
            Assert.AreEqual(AnSupplier.SupplierTelephone, TestData);
        }

        [TestMethod]
        public void InitialContractDateOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.DateAdded = TestData;
            Assert.AreEqual(AnSupplier.DateAdded, TestData);
        }

        [TestMethod]
        public void SupplierActiveOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.Active = TestData;
            Assert.AreEqual(AnSupplier.Active, TestData);
        }

 

        
    }

   
}
