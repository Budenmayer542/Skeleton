using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Test its existance
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            Boolean TestData = true;
            AProduct.Active = TestData;
            Assert.AreEqual(AProduct.Active, TestData);
        }

        [TestMethod]
        public void ComicIdPropertyOK()
        {
            clsProduct AProduct = new clsProduct();
            Int32 TestData = 1;
            AProduct.ComicID = TestData;
            Assert.AreEqual(AProduct.ComicID, TestData);

        }
        [TestMethod]
        public void ComicNameProperty()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Mirai Nikki Volume 1";
            AProduct.ComicName = TestData;
            Assert.AreEqual(AProduct.ComicName, TestData);
        }

        [TestMethod]
        public void ComicInitialReleaseDatePropertyOK() 
        {
            clsProduct AProduct = new clsProduct();
            DateTime TestData = DateTime.Now.Date;
            AProduct.ComicInitialReleaseDate = TestData;
            Assert.AreEqual(AProduct.ComicInitialReleaseDate, TestData);
        }

        [TestMethod]
        public void ComicArtistProperty()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Sakae Esuno";
            AProduct.ComicArtist = TestData;
            Assert.AreEqual(AProduct.ComicArtist, TestData);
        }

        [TestMethod]
        public void ComicPriceProperty() 
        {
            clsProduct AProduct = new clsProduct();
            double TestData = 7.99;
            AProduct.ComicPrice = TestData;
            Assert.AreEqual(AProduct.ComicPrice, TestData);
        }

        [TestMethod]
        public void ComicGenreProperty() 
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Action";
            AProduct.ComicGenre = TestData;
            Assert.AreEqual(AProduct.ComicGenre, TestData);
        }

        [TestMethod]
        public void ComicIsComicInStock () 
        { 
            clsProduct AProduct = new clsProduct(); 
            Boolean TestData = true;
            AProduct.IsComicInStock =  TestData;
            Assert.AreEqual(AProduct.IsComicInStock, TestData);
        }

        [TestMethod]
        public void TestComicIDFound()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Boolean storing the validation result
            Boolean Found = false;
            Boolean OK = true;
            //Some test data
            Int32 ComicID = 1;
            Found = AProduct.Find(ComicID);
            //
            if (AProduct.ComicID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestComicNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComicID = 1;
            //invoke the method
            Found = AProduct.Find(ComicID);
            //check the post code property
            if (AProduct.ComicName != "Mirai Nikki")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestComicInitialReleaseDateFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComicID = 1;
            //invoke the method
            Found = AProduct.Find(ComicID);
            //check the post code property
            if (AProduct.ComicInitialReleaseDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestComicArtistFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComicID = 1;
            //invoke the method
            Found = AProduct.Find(ComicID);
            //check the post code property
            if (AProduct.ComicArtist != "AAA")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestComicPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComicID = 1;
            //invoke the method
            Found = AProduct.Find(ComicID);
            //check the post code property
            if (AProduct.ComicPrice != 7.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestComicGenreFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComicID = 1;
            //invoke the method
            Found = AProduct.Find(ComicID);
            //check the post code property
            if (AProduct.ComicGenre != "Action")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsComicInStockFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ComicID = 1;
            //invoke the method
            Found = AProduct.Find(ComicID);
            //check the post code property
            if (AProduct.IsComicInStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
}
