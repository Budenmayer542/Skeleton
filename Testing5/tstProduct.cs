using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing5
{
    [TestClass]
    public class tstProduct
    {
        string ComicName = "Comic";
        string ComicArtist = "Person";
        string ComicInitialReleaseDate = DateTime.Now.ToShortDateString();
        string ComicGenre = "Action";
        string ComicPrice = "1.99";

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
            //Assign the data to the property
            AProduct.Active = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.Active, TestData);
        }

        [TestMethod]
        public void ComicIdPropertyOK()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            Int32 TestData = 1;
            //Assign the data to the property
            AProduct.ComicID = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.ComicID, TestData);

        }
        [TestMethod]
        public void ComicNameProperty()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            string TestData = "Mirai Nikki Volume 1";
            //Assign the data to the property
            AProduct.ComicName = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.ComicName, TestData);
        }

        [TestMethod]
        public void ComicInitialReleaseDatePropertyOK() 
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AProduct.ComicInitialReleaseDate = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.ComicInitialReleaseDate, TestData);
        }

        [TestMethod]
        public void ComicArtistProperty()
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            string TestData = "Sakae Esuno";
            //Assign the data to the property
            AProduct.ComicArtist = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.ComicArtist, TestData);
        }

        [TestMethod]
        public void ComicPriceProperty() 
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            double TestData = 7.99;
            //Assign the data to the property
            AProduct.ComicPrice = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.ComicPrice, TestData);
        }

        [TestMethod]
        public void ComicGenreProperty() 
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            string TestData = "Action";
            AProduct.ComicGenre = TestData;
            //Test to see if the values are the same
            Assert.AreEqual(AProduct.ComicGenre, TestData);
        }

        [TestMethod]
        public void ComicIsComicInStock () 
        {
            //Create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //Create test data
            Boolean TestData = true;
            //Assign the data to the property
            AProduct.IsComicInStock =  TestData;
            //Test to see if the values are the same
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
            //Check the comic ID property
            if (AProduct.ComicID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
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
            //check the comic name property
            if (AProduct.ComicName != "Akame Ga Kill!")
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
            //check the comic initial release date property
            if (AProduct.ComicInitialReleaseDate != Convert.ToDateTime("20/04/2010"))
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
            //check the comic artist property
            if (AProduct.ComicArtist != "Takahiro")
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
            //check the comic price property
            if (AProduct.ComicPrice != 11.99)
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
            //check the comic genre property
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
            //check the is comic in stock property
            if (AProduct.IsComicInStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        // ** VALIDATION ** //

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMinLessOne()
            //Test method for Min -1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMin()
            //Test method for Min
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "a";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMinPlusOne()
            // Test method for Min + 1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "aa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMaxLessOne()
            // Test method for Max - 1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMax()
            // Test method for Max

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMid()
            // Test method for Mid
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMaxPlusOne()
        // Test method for Max + 1

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameExMax()
        // Test method for Extreme Max

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "";
            ComicName = ComicName.PadRight(500, 'a');
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMinLessOne()
        //Test method for Min -1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMin()
        //Test method for Min
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "a";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMinPlusOne()
        // Test method for Min + 1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "aa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMaxLessOne()
        // Test method for Max - 1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMax()
        // Test method for Max

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMid()
        // Test method for Mid
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistMaxPlusOne()
        // Test method for Max + 1

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicArtistExMax()
        // Test method for Max + 1

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicArtist = "";
            ComicArtist = ComicArtist.PadRight(500, 'a');
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenreMinLessOne()
        //Test method for Min -1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenreMin()
        //Test method for Min
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "a";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenretMinPlusOne()
        // Test method for Min + 1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "aa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenreMaxLessOne()
        // Test method for Max - 1
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenretMax()
        // Test method for Max

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenreMid()
        // Test method for Mid
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenreMaxPlusOne()
        // Test method for Max + 1

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicGenreExMax()
        // Test method for Max + 1

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicGenre = "";
            ComicGenre = ComicGenre.PadRight(500, 'a');
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateExtrememMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateInvalid()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicInitialReleaseDate = "Not a date :)";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMinLessOne()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "-0.01";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMin()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "0.00";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMinPlusOne()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "0.01";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMaxLessOne()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "999999999999999999.98";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMax()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "999999999999999999.99";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMaxPlusOne()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "1000000000000000000";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicPriceMid()
        {  //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicPrice = "499999999999999999.99";
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
