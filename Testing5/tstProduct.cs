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

        [TestMethod]
        public void ActivePropertyOK()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            Boolean TestData = true;
            AProduct.Active = TestData;
            Assert.AreEqual(AProduct.Active, TestData);
        }

        [TestMethod]
        public void ComicInitialReleaseDatePropertyOK() 
        {
            clsProduct AProduct = new clsProduct();
            DateTime TestData = DateTime.Now.Date;
            AProduct.ComicInitialReleaseDate = TestData;
            Assert.AreEqual(AProduct.ComicInitialReleaseDate, TestData);
        }

        [TestMethod]
        public void ComicIdPropertyOK ()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ComicID = TestData;
            Assert.AreEqual(AProduct.ComicID, TestData);

        }
    }
}
