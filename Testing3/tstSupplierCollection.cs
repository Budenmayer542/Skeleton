﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing3
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //Instance of the class we want to create
            Assert.IsNotNull(AllSuppliers); //test to see that it exists
        }

        [TestMethod]
        public void SupplierListOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //create a new instance of the class
            List<clsSupplier> TestList = new List<clsSupplier>(); //test data to assign to the property (test data is a list of objects)
            clsSupplier TestItem = new clsSupplier(); //add an item to the list and created the item of test data 
            //set its properties 
            TestItem.SupplierActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "jeff";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            TestList.Add(TestItem); //Add the items to the test list
            AllSuppliers.SupplierList = TestList; //Asign the data to the property
            Assert.AreEqual(AllSuppliers.SupplierList, TestList); //test to see if the two values are the same 
        }

        [TestMethod]
        public void CountPropertyOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //new instance of the class
            Int32 SomeCount = 2; //test data to assign to the property
            AllSuppliers.Count = SomeCount; //assign the data to the property 
            Assert.AreEqual(AllSuppliers.Count, SomeCount); //test to see if the two values are the same 
        }

        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //new instance of the class
            clsSupplier TestSupplier = new clsSupplier(); //create test data to assing to the property
            //set the properties of the test objects
            TestSupplier.SupplierActive = true;
            TestSupplier.SupplierId = 1;
            TestSupplier.SupplierName = "Manga comics ltd";
            TestSupplier.ContactPerson = "jeff";
            TestSupplier.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestSupplier.SupplierTelephone = "07738062845";
            TestSupplier.InitialContractDate = DateTime.Now;
            AllSuppliers.ThisSupplier = TestSupplier; //Asign data to the property
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //create a new instance of the class
            List<clsSupplier> TestList = new List<clsSupplier>(); //test data to assign to the property (test data is a list of objects)
            clsSupplier TestItem = new clsSupplier(); //add an item to the list and created the item of test data 
            //set its properties 
            TestItem.SupplierActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "jeff";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            TestList.Add(TestItem); //Add the items to the test list
            AllSuppliers.SupplierList = TestList; //Asign the data to the property
            Assert.AreEqual(AllSuppliers.Count, TestList.Count); //test to see if the two values are the same
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //new instance of class
            Assert.AreEqual(AllSuppliers.Count, 2);
        }

      


    }
}
