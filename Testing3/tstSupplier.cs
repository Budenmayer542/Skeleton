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

        //Validation good test data

        string supplierName = "Geektastic Comic Suppliers";
        string contactPerson = "Emily Foster";
        string supplierEmail = "GeektasticComics@outlook.co.uk";
        string supplierTelephone = "07989618402";
        string initialContractDate = DateTime.Now.ToShortDateString();


        //***Supplier Name***\\
        [TestMethod]
        public void SupplierNameMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = ""; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameMin()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = "E"; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = "Em"; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = "1234565432123456543212345654321234565432123456543"; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = "12345654321234565432123456543212345654321234565432"; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = "123456543212345654321234565432123456543212345654321"; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = "1234565432123456543212345"; //test data to pass into method
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierName = ""; //test data to pass into method
            supplierName = supplierName.PadRight(1000, 'a'); //this should fail
            Error = AnSupplier.Valid(SupplierName, contactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        //***Initial contract date***\\

        [TestMethod]
        public void InitialContractDateExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class
            String Error = ""; //string to store error message
            DateTime TestDate; //variable to store test date
            TestDate = DateTime.Now.Date; //stores todays date
            TestDate = TestDate.AddYears(-100); // changes the date to whenever it was 100 years ago
            string InitialContractDate = TestDate.ToString(); //convert the date variable to a string variable
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, supplierTelephone, InitialContractDate); //invoke the method 
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void InitialContractDateMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class
            String Error = ""; //string to store error message
            DateTime TestDate; //variable to store test date
            TestDate = DateTime.Now.Date; //stores todays date
            TestDate = TestDate.AddDays(-1); // changes the date to whenever it was 1 day ago
            string InitialContractDate = TestDate.ToString(); //convert the date variable to a string variable
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, supplierTelephone, InitialContractDate); //invoke the method 
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void InitialContractDateMin()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class
            String Error = ""; //string to store error message
            DateTime TestDate; //variable to store test date
            TestDate = DateTime.Now.Date; //stores todays date
            string InitialContractDate = TestDate.ToString(); //convert the date variable to a string variable
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, supplierTelephone, InitialContractDate); //invoke the method 
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void InitialContractDateMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class
            String Error = ""; //string to store error message
            DateTime TestDate; //variable to store test date
            TestDate = DateTime.Now.Date; //stores todays date
            TestDate = TestDate.AddDays(1); // changes the date to whenever it is in 1 day
            string InitialContractDate = TestDate.ToString(); //convert the date variable to a string variable
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, supplierTelephone, InitialContractDate); //invoke the method 
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void InitialContractDateExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class
            String Error = ""; //string to store error message
            DateTime TestDate; //variable to store test date
            TestDate = DateTime.Now.Date; //stores todays date
            TestDate = TestDate.AddYears(100); // changes the date to whenever it is in 100 years
            string InitialContractDate = TestDate.ToString(); //convert the date variable to a string variable
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, supplierTelephone, InitialContractDate); //invoke the method 
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void InitialContractDateInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class
            String Error = ""; //string to store error message
            string InitialContractDate = "this is not a date!"; //Set the DateAdded to a non date value
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, supplierTelephone, InitialContractDate);
            Assert.AreNotEqual(Error, "");
        }

        //***Contact Person***\\

        [TestMethod]
        public void ContactPersonMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = ""; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonMin()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = "E"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = "Em"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = "1234565432123456543"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = "12345654321234565432"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = "123456543212345654321"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonMid()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = "1234565432"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void ContactPersonExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String ContactPerson = ""; //test data to pass into method
            ContactPerson = ContactPerson.PadRight(500, 'a'); //this should fail
            Error = AnSupplier.Valid(supplierName, ContactPerson, supplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        //***Supplier Email***\\

        [TestMethod]
        public void SupplierEmailMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = ""; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailMin()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = "E"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = "Em"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = "12345654321234565432123456543"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = "123456543212345654321234565432"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = "1234565432123456543212345654321"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailMid()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = "123456543212345"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierEmailExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierEmail = ""; //test data to pass into method
            SupplierEmail = SupplierEmail.PadRight(500, 'a'); //this should fail
            Error = AnSupplier.Valid(supplierName, contactPerson, SupplierEmail, supplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        //***Supplier Telephone***\\

        [TestMethod]
        public void SupplierTelephoneMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = ""; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneMin()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = "0"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = "01"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = "01234567890123"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = "012345678901232"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = "0123456789012321"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneMid()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = "0123456"; //test data to pass into method
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreEqual(Error, ""); //test to see if the result is correct 
        }

        [TestMethod]
        public void SupplierTelephoneExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier(); //Create a new instance of the class 
            String Error = ""; //string to store error message 
            String SupplierTelephone = ""; //test data to pass into method
            SupplierTelephone = SupplierTelephone.PadRight(250, 'a'); //this should fail
            Error = AnSupplier.Valid(supplierName, contactPerson, supplierEmail, SupplierTelephone, initialContractDate); //invoke the method
            Assert.AreNotEqual(Error, ""); //test to see if the result is correct 
        }

    }
}  
