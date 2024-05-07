using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

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
        public void Activepropertyok()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the Customer
            bool TestData = true;
            //assign the data to the Customer
            AnCustomer.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        public void SignUppropertyok()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //Assign the data to the property
            AnCustomer.SignUp = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.SignUp, TestData);
        }
        public void CustomerIdpropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        public void FullNamepropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "smily";
            //assign the data to the property
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FullName, TestData);

        }
        public void EmailAddresspropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "smily74@gmail.com";
            //assignthe data to the property
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }
        public void PhoneNumberpropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            const long V = 07436849998;// Doesn't generate a warning.
            Int64 TestData = V;
            //assign the data to the property 
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }
        
    }

}


