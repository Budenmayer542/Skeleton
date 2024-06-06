using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing5
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Test its existance
            Assert.IsNotNull(AllProducts);
        }

        [TestMethod]
        public void ProductListOK() 
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create som test data to assign to the property
            //It needs to be a list for this case
            List<clsProduct> TestList = new List<clsProduct>();
            //Add an item to the test data
            //Create the item of the test data
            clsProduct TestItem = new clsProduct();
            //Set its properties
            TestItem.ComicID = 1;
            TestItem.ComicName = "Test";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "OneArtist";
            TestItem.ComicPrice = 12.34;
            TestItem.ComicGenre = "Action";
            TestItem.IsComicInStock = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllProducts.ProductList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);

        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create som test data to assign to the property
            clsProduct TestProduct = new clsProduct();
            //Set its properties
            TestProduct.ComicID = 1;
            TestProduct.ComicName = "Test";
            TestProduct.ComicInitialReleaseDate = DateTime.Now;
            TestProduct.ComicArtist = "OneArtist";
            TestProduct.ComicPrice = 12.34;
            TestProduct.ComicGenre = "Action";
            TestProduct.IsComicInStock = true;
            //Assign the data to the property
            AllProducts.ThisProduct = TestProduct;
            //Test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestProduct);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create som test data to assign to the property
            //It needs to be a list for this case
            List<clsProduct> TestList = new List<clsProduct>();
            //Add an item to the test data
            //Create the item of the test data
            clsProduct TestItem = new clsProduct();
            //Set its properties
            TestItem.ComicID = 1;
            TestItem.ComicName = "Test";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "OneArtist";
            TestItem.ComicPrice = 12.34;
            TestItem.ComicGenre = "Action";
            TestItem.IsComicInStock = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllProducts.ProductList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create som test data to assign to the property
            clsProduct TestItem = new clsProduct();
            //Set its properties
            Int32 PrimaryKey = 0;
            TestItem.ComicID = 1;
            TestItem.ComicName = "A Comic";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "Artista";
            TestItem.ComicPrice = 7.99;
            TestItem.ComicGenre = "Action";
            TestItem.IsComicInStock = true;
            AllProducts.ThisProduct = TestItem;
            //add the item to the test list
            PrimaryKey = AllProducts.Add();
            AllProducts.ThisProduct.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create som test data to assign to the property
            clsProduct TestItem = new clsProduct();
            //Set its properties
            Int32 PrimaryKey = 0;
            TestItem.ComicName = "A Comic";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "Artista";
            TestItem.ComicPrice = 7.99;
            TestItem.ComicGenre = "Action";
            TestItem.IsComicInStock = true;
            AllProducts.ThisProduct = TestItem;
            //add the item to the test list
            PrimaryKey = AllProducts.Add();
            //create the new test data
            TestItem.ComicID = PrimaryKey;
            TestItem.ComicName = "fffffc";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "Artiffffsta";
            TestItem.ComicPrice = 777.99;
            TestItem.ComicGenre = "Adventure";
            TestItem.IsComicInStock = false;
            //set the record based on the new test data 
            AllProducts.Update();
            //find the record 
            AllProducts.ThisProduct.Find(PrimaryKey);
            //Test to see that the two values are the same`
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create som test data to assign to the property
            clsProduct TestItem = new clsProduct();
            //Set its properties
            Int32 PrimaryKey = 0;
            TestItem.ComicID = 1;
            TestItem.ComicName = "A Comic";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "Artista";
            TestItem.ComicPrice = 7.99;
            TestItem.ComicGenre = "Action";
            TestItem.IsComicInStock = true;
            AllProducts.ThisProduct = TestItem;
            //add the item to the test list
            PrimaryKey = AllProducts.Add();
            TestItem.ComicID = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);
            AllProducts.Delete();
            //find the record
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see if the record was not found
            Assert.IsFalse(Found); 
        }

        [TestMethod]
        public void ReportByComicNameMethodOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Create a filtered instance of the class we want to create
            clsProductCollection FilteredProducts = new clsProductCollection();
            //Fitler with an empty filter
            FilteredProducts.ReportByComicName("");
            //Check if al records have been returned
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByComicNameNoneFound()
        {
            //Create an instance of the class we want to create
            clsProductCollection FilteredProducts = new clsProductCollection();
            //Apply a filter that will have 0 matches
            FilteredProducts.ReportByComicName("xyx xyx");
            //check no record has been returned
            Assert.AreEqual(0, FilteredProducts.Count);
        }

        [TestMethod]
        public void ReportByComicNameTestDataFound()
        {
            //Create an instance of the filtered data
            clsProductCollection FilteredProduct = new clsProductCollection();
            //Variables to store the outcome
            Boolean OK = true;
            //Apply a comic that doesn't exist
            FilteredProduct.ReportByComicName("yyyyyyyyyyyy");
            //Check that the correct number of records are found
            if (FilteredProduct.Count > 2)
            {
                if (FilteredProduct.ProductList[0].ComicID != 25) 
                {
                    OK = false;
                }
                if (FilteredProduct.ProductList[1].ComicID != 26)
                {
                    OK = false;
                }
            else
                {
                    OK  = false;
                }
            //ckeck is he records are present
            Assert.IsTrue(OK);
            }
        }
    }
}
