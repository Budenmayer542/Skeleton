using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    public class TstCustomer
    {
        public void Instanceok()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exits
            Assert.IsNotNull(AnCustomer);
        }
        public void Activepropertyok()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        public void CustomerIdpropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the  property
            AnCustomer.CustomerId = TestData;
            //test to see that the two vlaues are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        public void SignUppropertyok()
        {
            //creat an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AnCustomer.SignUp = TestData;
            //test to see that the two values are the same
            Assert.IsNotNull(AnCustomer.SignUp, TestData);
        }
        public void FullNamepropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Smily";
            //assign the data to the property
            AnCustomer.FullName = TestData;
            //test to see that the two values are the same
            Assert.IsNotNull(AnCustomer.FullName, TestData);
        }
        public void EmailAddresspropertyok()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            String TestData = "smily74@gmail.com";
#pragma warning restore CS0219 // Variable is assigned but its value is never used
            //aasign the data to the property 
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.IsNotNull(AnCustomer.EmailAddress, TestData);
        }
        public void PhoneNumberproperty()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 0743684998;
            //assign the dat to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.IsNotNull(AnCustomer.PhoneNumber, TestData);
        }
    }
}
