using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq.Expressions;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);           
           
        }

        [TestMethod]
        public void StaffNumber() 
        {
            //create an instanmce of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]

        public void StaffRole() 
        {
            //create an instanmce of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Manager";
            //assign the data to the property
            AnStaff.StaffRole = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffRole, TestData);
        }

        [TestMethod]
        public void StaffName()
        { 
            //create an instanmce of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Kelvin";
            //assign the data to the property
            AnStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);
        }

        [TestMethod]
        public void StaffAddress()
        {
            //create an instanmce of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnStaff.StaffAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffAddress, TestData);
        }

        [TestMethod]
        public void StaffDOB()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.StaffDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffDOB, TestData);
        }

        [TestMethod]
        public void StaffPriviliges() 
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.StaffPriviliges = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffPriviliges, TestData);
        }

        [TestMethod]
        public void StaffSalary()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            double TestData = 20000;
            //assign the data to the property
            AnStaff.StaffSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffSalary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean cariable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 21) 
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
