using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void Instanceok()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it's exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]

        public void Activepropertyok()
        {//create an instance of tne classwe want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to aasign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]

        public void SignUppropertyok()
        {//create an instance of tne classwe want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to aasign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AnCustomer.Signupdate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Signupdate, TestData);
        }

        [TestMethod]

        public void FullNamepropertyok()
        {//create an instance of tne classwe want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to aasign to the property

            String TestData = "Smily";


            //assign the data to the property
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FullName, TestData);
        }

        [TestMethod]

        public void PhoneNumberpropertyok()
        {//create an instance of tne classwe want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to aasign to the property

           String TestData = "07436849998";


            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }

        [TestMethod]

        public void EmailAddresspropertyok()
        {//create an instance of tne classwe want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to aasign to the property

            String TestData = "smily74@gmail.com";

            //assign the data to the property
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }

        [TestMethod]

        public void CustomerIdpropertyok()
        {//create an instance of tne classwe want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to aasign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FindMethodok()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the results of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //check the Customer id
            if (AnCustomer.CustomerId != 1)
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullNameFound()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //ccheck the customer id
            if (AnCustomer.FullName != "alex")
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSignUpFound()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //ccheck the customer id
            if (AnCustomer.Signupdate != Convert.ToDateTime("30/04/2024"))
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //ccheck the customer id
            if (AnCustomer.Active != true)
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //ccheck the customer id
            if (AnCustomer.EmailAddress != "P2731599@my365.dmu.ac.uk")
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //ccheck the customer id
            if (AnCustomer.PhoneNumber != "07437568598")
            { OK = false; }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
