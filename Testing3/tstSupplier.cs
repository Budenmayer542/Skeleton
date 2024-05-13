using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplier
    {
        //Instance Of The Test Class 


        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier(); //create an instance of the class we want to create
            Assert.IsNotNull(AnSupplier); //test to see that it exists 
        }


        //Property Ok Tests


        [TestMethod]
        public void SupplierIdOk()
        {
            clsSupplier AnSupplier = new clsSupplier(); //create an instance of the class we want to create
            Int32 TestData = 1; //create some test data to assign to the property
            AnSupplier.SupplierId = TestData; //assign the data to the property
            Assert.AreEqual(AnSupplier.SupplierId, TestData); //test to see that the two values are the same
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
            string TestData = "07989618402";
            AnSupplier.SupplierTelephone = TestData;
            Assert.AreEqual(AnSupplier.SupplierTelephone, TestData);
        }

        [TestMethod]
        public void InitialContractDateOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.InitialContractDate = TestData;
            Assert.AreEqual(AnSupplier.InitialContractDate, TestData);
        }

        [TestMethod]
        public void SupplierActiveOk()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.SupplierActive = TestData;
            Assert.AreEqual(AnSupplier.SupplierActive, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsSupplier AnSupplier = new clsSupplier(); //create an instance of the class we want to create
            Boolean Found = false; //create a Boolean variable to store the results of the validation
            Int32 SupplierId = 4; //create some test data to use with the method
            Found = AnSupplier.Find(SupplierId); //invoke the method
            Assert.IsTrue(Found); //test to see if the result is true
        }


        //Find Method Tests


        [TestMethod]
        public void TestSupplierIdFound()
        {
            clsSupplier AnSupplier = new clsSupplier(); //create an instance of the class we want to create
            Boolean Found = false; //create a Boolean variable to store the result of the search
            Boolean Ok = true; //create a Boolean variable to record if the data is OK (assume it is)
            Int32 SupplierId = 4; //create some test data to use with the method
            Found = AnSupplier.Find(SupplierId); //invoke the method
            if (AnSupplier.SupplierId != 4) //check the Supplier id property
            {
                Ok = false;
            }
            Assert.IsTrue(Ok); //test to see that the result is correct
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierId = 4;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierName != "Geektastic Comic Suppliers")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestSupplierPersonFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierId = 4;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.ContactPerson != "Emily Foster")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierId = 4;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierEmail != "GeektasticComics@outlook.co.uk")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestSupplierTelephoneFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierId = 4;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierTelephone != "07989618402")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestInitialContractDateFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierId = 4;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.InitialContractDate != Convert.ToDateTime("08/05/2021"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestSupplierActiveFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 SupplierId = 4;
            Found = AnSupplier.Find(SupplierId);
            if (AnSupplier.SupplierActive != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }





    }

   
}
