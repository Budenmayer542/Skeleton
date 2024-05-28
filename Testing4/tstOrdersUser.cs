﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrdersUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class wwe want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK() 
        {
            //create an instance of the class we want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //create some test data to assign to the property
            string TestData = "Rami";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //create some test data to assign to the property
            string TestData = "OrderPass";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //create some test data to assign to the property
            string TestData = "Orders";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class we want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Rami";
            string Password = "OrderPass";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an isntance of the class we want to create
            clsOrdersUser AnUser = new clsOrdersUser();
            //create a Boolea variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Rami";
            string Password = "Orderpass";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
