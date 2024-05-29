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
            TestItem.EmailAddress = "P2731599@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "07437568598";
            TestItem.Signupdate = DateTime.Now;
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList; //Asign the data to the property
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        { //Create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the preporty
            Int32 SomeCount = 2;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        { //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //add an item to the list 
            //create the iteam of the test
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties 
            TestCustomer.Active = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.FullName = "alex";
            TestCustomer.EmailAddress = "P2731599@my365.dmu.ac.uk";
            TestCustomer.PhoneNumber = "07437568598";
            TestCustomer.Signupdate = DateTime.Now;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer; //Asign the data to the property
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void ListAndCountOK()
        {//create an instance of the class we want to create
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
            TestItem.EmailAddress = "P2731599@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "07437568598";
            TestItem.Signupdate = DateTime.Now;
            //add the items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList; //Asign the data to the property
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        { //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, 2);
        }
        [TestMethod]
        public void AddMethodOk()
        { //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //SET its properties
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.FullName = "alex";
            TestItem.EmailAddress = "P2731599@my365.dmu.ac.uk";
            TestItem.PhoneNumber = "07437568598";
            TestItem.Signupdate = DateTime.Now;
            //set thiscustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
    }
   

}
