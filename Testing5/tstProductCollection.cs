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
        public void CountPropertyOK()
        {
            //Create some test data to assign to the property
            clsProductCollection AllProducts = new clsProductCollection();
            //Create some test data to the property
            Int32 SomeCount = 2;
            //Assign the data to the property
            AllProducts.Count = SomeCount;
            //Test to see if the two values are the same
            Assert.AreEqual(AllProducts.Count, SomeCount);
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
        public void TwoRecordsPresent()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProducts = new clsProductCollection();
            //Test to se that the two values are the same
            Assert.AreEqual(AllProducts.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsProductCollection AllProducts = new clsProductCollection();
            clsProduct TestItem = new clsProduct();
            TestItem.ComicID = 1;
            TestItem.ComicName = "A Comic";
            TestItem.ComicInitialReleaseDate = DateTime.Now;
            TestItem.ComicArtist = "Artista";
            TestItem.ComicPrice = 7.99;
            TestItem.ComicGenre = "Action";
            TestItem.IsComicInStock = true;
            AllProducts.ThisProduct = TestItem;
            AllProduct.ThisProduct.Find(ComicID);
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
    }
}
