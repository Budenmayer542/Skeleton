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
        [TestMethod]
        public void UpdateMethod()
        {//create an instance of the class we want to create
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
            //modify the test record
            TestItem.Active = false;
            TestItem.CustomerId = 5;
            TestItem.FullName = "smily";
            TestItem.EmailAddress = "smily74@gmail.com";
            TestItem.PhoneNumber = "07436849998";
            TestItem.Signupdate = DateTime.Now;
            //set thiscustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if thisCustomer matches the testdata
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOk()
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
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //create an instance of the class we want to create
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a fullname that doesn't exsit
            FilteredCustomers.ReportByFullName("not a customer");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create an instance of the filtered data 
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply a fullname that doesn't exist
            FilteredCustomers.ReportByFullName("FullName");
            //check that the correct number of records are found 
            if (FilteredCustomers.Count == 2)
            {
                //check to see that the first record is 91
                if (FilteredCustomers.CustomerList[0].CustomerId != 91)
                {
                    OK = false;
                }
                // check to see that the first record is 92
                if (FilteredCustomers.CustomerList[1].CustomerId != 92)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
