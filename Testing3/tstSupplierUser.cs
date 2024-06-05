using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            Assert.IsNotNull(AnUser); //test to see that it exists
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            Int32 TestData = 1; //some test data to assign to the property
            AnUser.UserID = TestData; //Assign the data to the property
            Assert.AreEqual(AnUser.UserID, TestData); //test to see if the two values are the same
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            string TestData = "carlin"; //some test data to assign to the property
            AnUser.UserName = TestData; //Assign the data to the property
            Assert.AreEqual(AnUser.UserName, TestData); //test to see if the two values are the same
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            string TestData = "Password123"; //some test data to assign to the property
            AnUser.Password = TestData; //Assign the data to the property
            Assert.AreEqual(AnUser.Password, TestData); //test to see if the two values are the same
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            string TestData = "supplier"; //some test data to assign to the property
            AnUser.Department = TestData; //Assign the data to the property
            Assert.AreEqual(AnUser.Department, TestData); //test to see if the two values are the same
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            Boolean Found = false; //boolean variable to store the results of validation
            //test data to use with the method
            string UserName = "carlin";
            string Password = "Password";
            Found = AnUser.FindUser(UserName, Password); //involke the method
            Assert.IsTrue(Found); //test to see if the results are true
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsSupplierUser AnUser = new clsSupplierUser(); //new instance of class
            Boolean Found = false; //boolean variable to store the results of the search
            Boolean OK = true; //boolean variable to record if the data is OK
            //test data to use with the method
            string UserName = "carlin";
            string Password = "Password";
            Found = AnUser.FindUser(UserName, Password); //involke the method
            if (AnUser.UserName != UserName && AnUser.Password != Password) //check the user id property
            {
                OK = false;
            }
            Assert.IsTrue(OK); //test to see that the result is correct
        }   

    }
}
