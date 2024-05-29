using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {//CREATE an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that is exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        { //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection(); 
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the iteam of the test
            clsCustomer TestItem = new clsCustomer(); 
            //set its properties 
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.FullName = "alex";
            TestItem. EmailAddress= "P2731599@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "07437568598";
            TestItem.Signupdate = DateTime.Now;
            //add the items to the test list
            TestList.Add(TestItem); 
            //assign the data to the property
            AllCustomers.CustomerList = TestList; //Asign the data to the property
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
    }
}
