using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstProductUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //Test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnUser.UserID = TestData;
            //Test to see that the two valuesare the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            string TestData = "Dawn";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            string TestData = "password123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the sam
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsProductUser AnUser = new clsProductUser();
            //create some test data to assign to the property
            string TestData = "Address Book";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //new instance of class
            clsProductUser AnUser = new clsProductUser();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //test data to use with the method
            string UserName = "Alex";
            string Password = "Alex";
            //
            Found = AnUser.FindUser(UserName, Password);
            
            Assert.IsTrue(Found); 
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //new instance of class
            clsProductUser AnUser = new clsProductUser();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true; 
            //test data to use with the method
            string UserName = "Alex";
            string Password = "Alex";
            //
            Found = AnUser.FindUser(UserName, Password); 
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see if it's true
            Assert.IsTrue(OK);
        }
    }
}
