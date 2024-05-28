using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.IO;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {

        //good test data
        //create some test data to pass the method
        string ItemCount = "11";
        string DateOfOrder = DateTime.Now.ToShortDateString();
        string SubTotal = "11.50";
        string Total = "12.00";
        string DeliveryNote = "leave outside";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            //create an instance of the calss we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test date to assign to the property
            Boolean TestData = true;
            //assign the date to the property
            AnOrder.Dispatched = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }

        [TestMethod]
        public void DateOfOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateOfOrder = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateOfOrder, TestData);
        }

        [TestMethod]
        public void OrderNoPorpertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void ItemCountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the data to the property
            AnOrder.ItemCount = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ItemCount, TestData);
        }

        [TestMethod]
        public void SubTotalPropertyOK()
        {  //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            double TestData = 5.15;
            //assign the data to the property
            AnOrder.SubTotal = TestData;
        }

        [TestMethod]
        public void OrderTotalPropertyOK()
        {  //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            double TestData = 5.15;
            //assign the data to the property
            AnOrder.Total = TestData; 
        }

        [TestMethod]
        public void DeliveryNotePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "Do not ring the doorbell.";
            //assign the data to the property
            AnOrder.DeliveryNote = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DeliveryNote, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order number
            if (AnOrder.OrderNo != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfOrderFound() 
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the DateOfOrder property
            if (AnOrder.DateOfOrder != Convert.ToDateTime("12/05/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemCountFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the DateOfOrder property
            if (AnOrder.ItemCount != 22)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the DateOfOrder property
            if (AnOrder.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSubTotalFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the DateOfOrder property
            if (AnOrder.SubTotal != 13.5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the DateOfOrder property
            if (AnOrder.Total != 16)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryNoteFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 6;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the DateOfOrder property
            if (AnOrder.DeliveryNote != "Leave by the door")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string ItemCount = ""; // this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "1";//this should be ok
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "2";//this should be ok
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "9998";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "9999";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "50";//this should be ok
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "10000";//this should be ok
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemCountExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ItemCount = "";
            ItemCount = ItemCount.PadRight(500, '1'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //change the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //change the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfOrder = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfOrderInvalidDate()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //set the DateOfOrder to a non date value
            string DateOfOrder = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SubTotalMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTotalMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "0.01";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTotalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "1.01";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTotalMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "9998";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTotalMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "9999";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SubTotalMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SubTotalMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string SubTotal = "99";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "0.01";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "1.01";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "9998";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "9999";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Total = "99";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "a";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "aa";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "";
            DeliveryNote = DeliveryNote.PadRight(499, 'a');
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "";
            DeliveryNote = DeliveryNote.PadRight(500, 'a');
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "";
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryNoteMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string DeliveryNote = "";
            DeliveryNote = DeliveryNote.PadRight(200, 'a');
            //invoke the method
            Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}


