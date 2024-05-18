using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrdersListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the date needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an Item to the List
            //create the item of the test data
            clsOrders TestItem = new clsOrders();
            //se its properties
            TestItem.Dispatched = true;
            TestItem.OrderNo = 1;
            TestItem.ItemCount = 1;
            TestItem.DateOfOrder = DateTime.Now;
            TestItem.SubTotal = 1.50;
            TestItem.Total = 2.50;
            TestItem.DeliveryNote = "Go around to the back";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }

       

        [TestMethod]
        public void ThisOrdersPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrders = new clsOrders();
            //set the properties of the test object
            TestOrders.Dispatched = true;
            TestOrders.OrderNo = 1;
            TestOrders.ItemCount = 1;
            TestOrders.DateOfOrder = DateTime.Now;
            TestOrders.SubTotal = 1.50;
            TestOrders.Total = 2.50;
            TestOrders.DeliveryNote = "Go around to the back";
            //assign the data to the property
            AllOrders.ThisOrders = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrders, TestOrders);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //Add an Item to the List
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.Dispatched = true;
            TestItem.OrderNo = 1;
            TestItem.ItemCount = 1;
            TestItem.DateOfOrder = DateTime.Now;
            TestItem.SubTotal = 1.50;
            TestItem.Total = 2.50;
            TestItem.DeliveryNote = "Go around to the back";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrdersList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

       
    }
}
