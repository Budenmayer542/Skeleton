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
        //GOOD test data
        //create some test data to pass the method

        String FullName = "alex";
        String EmailAddress = "P2731599@my365.dmu.ac.uk";
        String PhoneNumber = "07437568598";
        String Signupdate = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void ValidMethodOK ()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //invoke method
            Error = AnCustomer.Valid(FullName,EmailAddress,PhoneNumber,Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne() 
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String FullName = ""; ///this should trigger or error
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMin()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String FullName = "a"; ///this should trigger or error
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPluseOne()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String FullName = "aa"; ///this should trigger or error
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String FullName = "aaaaa"; ///this should trigger or error
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
        //string the variable to store any error message
        String Error = "";
        //create some test data to pass the method
        String FullName = "aaaaaa"; ///this should trigger or error
        //invoke method
        Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {// create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
        //string the variable to store any error message
        String Error = "";
        //create some test data to pass the method
        String FullName = "aaa"; ///this should trigger or error
        //invoke method
        Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, ""); 
        }
        [TestMethod]
        public void FullNameMaxPluseOne()
        {// create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; ///this should trigger or error
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameExtremeMax()
        { // create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String FullName = "aaaaaaa"; ///this should trigger or error
            FullName = FullName.PadRight(500, 'a');
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignupdateExtremeMin()
        { //create AN INSTANCE of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable 
            String Signupdate = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignupdateExtremeMinLessOne()
        { //create AN INSTANCE of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable 
            String Signupdate = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignupdateMin()
        { //create AN INSTANCE of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string the variable to store any error message
            String Error = "";
            //create a variable to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            //convert the date variable to a string variable 
            String Signupdate = TestDate.ToString();
            //invoke method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SignupdateMinPlusOne()
        { // create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date date
            DateTime TestDate;
            //set the date todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convevrt the date variable to a string variable
            String Signupdate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see thaat the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignupdateExtremeMax()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convevrt the date variable to a string variable
            String Signupdate = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SignupdateInvalidData()
        { // create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the Signupdate to a non date value
            String Signupdate = "this is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is corret
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string EmailAddress = "";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailAddressMin()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud pass
            string EmailAddress = "a";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud pass
            string EmailAddress = "aa";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud pass
            string EmailAddress = "12345654321234565432123456543";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMax()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud pass
            string EmailAddress = "123456543212345654321234565432";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string EmailAddress = "123456789012345678901234567890123456789012345678901";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMid()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string EmailAddress = "123456543212345";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(49, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "a";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "aa";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        { //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "12345654";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "1234567890";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "12345678901";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMid()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "1234565432";
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberExtremeMax()
        {//create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this sholud fail
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(10, 'a');
            //invoke the method 
            Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
