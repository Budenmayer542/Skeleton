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
            //check the post code property
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
            //check the post code property
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
            //check the post code property
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

 

        [TestMethod]
        public void ValidMethodOK()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameMinLessOne()
            //Test method for Min -1
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ComicName = "";
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicName = "a"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicName = "aa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicNameExMax()
        // Test method for Max + 1

        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ComicName = "";
            ComicName = ComicName.PadRight(500, 'a');
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        ////
        ///
        ///



        /////
        ///
        [TestMethod]
        public void ComicArtistMinLessOne()
        //Test method for Min -1
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ComicArtist = "";
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicArtist = "a"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicArtist = "aa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicArtist = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void ComicGenreMinLessOne()
        //Test method for Min -1
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            string ComicGenre = "";
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicGenre = "a"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicGenre = "aa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            string ComicGenre = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
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
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ComicInitialReleaseDateExtremeMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
            Assert.AreEqual(Error, "");
        }
    }
}
