using ClassLibrary;
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
        public void AddMethodOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //new instance of cls supplier collection
            clsSupplier TestItem = new clsSupplier(); //Create the item of test data
            Int32 PrimaryKey = 0; //variable to store the primary key
            //Set its properties
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "jeff";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            TestItem.SupplierActive = true;
            AllSuppliers.ThisSupplier = TestItem; //set ThisSupplier to the test data
            PrimaryKey = AllSuppliers.Add(); //add the record 
            TestItem.SupplierId = PrimaryKey; //set the primary key of the test data
            AllSuppliers.ThisSupplier.Find(PrimaryKey); //find the record 
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem); //test to see if the two values are the same
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //instance of class
            clsSupplier TestItem = new clsSupplier();//item of test data
            Int32 PrimaryKey = 0; //variable to store primary key
            //set its properties
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "jeff";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            TestItem.SupplierActive = true;
            AllSuppliers.ThisSupplier = TestItem; //set thisSupplier to the test data
            PrimaryKey = AllSuppliers.Add(); //add the record 
            TestItem.SupplierId = PrimaryKey; //set the primary key of the test data 
            //modify the test record 
            TestItem.SupplierName = "MangaMania Suppliers";
            TestItem.ContactPerson = "Liam Thompson";
            TestItem.SupplierEmail = "MangaMania@outlook.co.uk";
            TestItem.SupplierTelephone = "07738528367";
            TestItem.InitialContractDate = DateTime.Now;
            TestItem.SupplierActive = false;
            AllSuppliers.ThisSupplier = TestItem; //set the record based on the new test data 
            AllSuppliers.Update(); //Update the record 
            AllSuppliers.ThisSupplier.Find(PrimaryKey); //Find the record 
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem); //test to see if ThisSupplier is the same as the test data
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //instance of class
            clsSupplier TestItem = new clsSupplier();//item of test data
            Int32 PrimaryKey = 0; //variable to store primary key
            //set its properties
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "jeff";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            TestItem.SupplierActive = true;
            AllSuppliers.ThisSupplier = TestItem; //set thisSupplier to the test data
            PrimaryKey = AllSuppliers.Add(); //add the record 
            TestItem.SupplierId = PrimaryKey; //set the primary key of the test data
            AllSuppliers.ThisSupplier.Find(PrimaryKey); //find the record
            AllSuppliers.Delete(); //delete the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey); //Find the record
            Assert.IsFalse(Found); //test to see if the record was not found
        }

        [TestMethod]
        public void ReportBySupplierNameOk()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection(); //instance of class of unfiltered data
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection(); //instance of class of filtered data
            FilteredSuppliers.ReportBySupplierName(""); //apply a blank string(should return all records 
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count); //check to see both values are the same
        }

        [TestMethod]
        public void ReportBySupplierNameNotFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection(); //instance of class 
            FilteredSuppliers.ReportBySupplierName("Not a supplier"); //apply a supplier name that doesnt exist
            Assert.AreEqual(0, FilteredSuppliers.Count); //test to see that there are no records
        }

        [TestMethod]
        public void ReportBySupplierNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection(); //instance of filtered data
            Boolean Ok = true; //variable to store the outcome 
            FilteredSuppliers.ReportBySupplierName("TestComicName"); //apply a supplier name that doesnt exist
            if (FilteredSuppliers.Count == 2) //check to see if the correct number of records are found
            {
                if (FilteredSuppliers.SupplierList[0].SupplierId != 31) //check to see if the first record is 25
                {
                    Ok = false;
                }

                if (FilteredSuppliers.SupplierList[1].SupplierId != 34) //check to see if the first record is 26
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
            
        }
    }
}
