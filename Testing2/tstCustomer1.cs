using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            AnCustomer.SignUp = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.SignUp, TestData);
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

            Int64 TestData = 07436849998;


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

            String TestData ="smily74@gmail.com";

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
    }
}
