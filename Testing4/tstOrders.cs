using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;

namespace Testing4
{
    [TestClass]
    public class tstOrders
    {
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
            Assert.AreEqual(AnOrder, TestData);
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
            Assert.AreEqual(AnOrder, TestData);
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
        public void TotalPropertyOK()
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
            Assert.AreEqual(AnOrder, TestData);
        }
    }
}
