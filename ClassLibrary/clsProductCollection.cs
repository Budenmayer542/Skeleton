using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ClassLibrary
{
    public class clsProductCollection
    {
        // Private data member for the list
        public List<clsProduct> mProductList = new List<clsProduct>();

        clsProduct mThisProduct = new clsProduct();


        public List<clsProduct>  ProductList {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }
        public int Count 
        {
            get 
            {  
                return mProductList.Count;
            }
            set 
            { 
                // Later
            }
        }
        public clsProduct ThisProduct 
        { 
            get
            {
                return mThisProduct;
            }

            set
            {
                mThisProduct = value;
            }
        }

        public clsProductCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("tblComic_SelectAll");
            //Populate thhe array list with the data table
            PopulateArray(DB);

        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ComicName", mThisProduct.ComicName);
            DB.AddParameter("@ComicInitialReleaseDate", mThisProduct.ComicInitialReleaseDate);
            DB.AddParameter("@ComicArtist", mThisProduct.ComicArtist);
            DB.AddParameter("@ComicPrice", mThisProduct.ComicPrice);
            DB.AddParameter("@ComicGenre", mThisProduct.ComicGenre);
            DB.AddParameter("@IsComicInStock", mThisProduct.IsComicInStock);

            return DB.Execute("sproc_tblComic_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ComicID", mThisProduct.ComicID);
            DB.AddParameter("@ComicName", mThisProduct.ComicName);
            DB.AddParameter("@ComicInitialReleaseDate", mThisProduct.ComicInitialReleaseDate);
            DB.AddParameter("@ComicArtist", mThisProduct.ComicArtist);
            DB.AddParameter("@ComicPrice", mThisProduct.ComicPrice);
            DB.AddParameter("@ComicGenre", mThisProduct.ComicGenre);
            DB.AddParameter("@IsComicInStock", mThisProduct.IsComicInStock);

            DB.Execute("sproc_tblComic_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ComicID", mThisProduct.ComicID);
            DB.Execute("sproc_tblComic_Delete");
        }

        public void ReportByComicName(string ComicName)
        {
            //filters the records based on a full or parial comic names
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the ComicName parameter to the database
            DB.AddParameter("@ComicName", ComicName);
            //Execute the stored procedure
            DB.Execute("sproc_tblComic_FilterByComicName");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //Variable for the index
            Int32 Index = 0;
            //Variable to store the record count
            Int32 RecordCount;
            //Get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mProductList = new List<clsProduct>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank address object
                clsProduct AProduct = new clsProduct();
                //Read in the fields from the current rcord
                AProduct.ComicID = Convert.ToInt32(DB.DataTable.Rows[Index]["ComicID"]);
                AProduct.ComicName = Convert.ToString(DB.DataTable.Rows[Index]["ComicName"]);
                AProduct.ComicInitialReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ComicInitialReleaseDate"]);
                AProduct.ComicArtist = Convert.ToString(DB.DataTable.Rows[Index]["ComicArtist"]);
                AProduct.ComicPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ComicPrice"]);
                AProduct.ComicGenre = Convert.ToString(DB.DataTable.Rows[Index]["ComicGenre"]);
                AProduct.IsComicInStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsComicInStock"]);
                //Add the record to the private data member
                mProductList.Add(AProduct);
                //Point at the next record
                Index++;
            }
        }
    }
}