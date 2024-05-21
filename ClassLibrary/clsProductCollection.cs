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
            //Variable for the index
            Int32 Index = 0;
            //Variable to store the record count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("tblComic_SelectAll");
            //Get the count of records
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsProduct AProduct = new clsProduct();
                AProduct.ComicID = Convert.ToInt32(DB.DataTable.Rows[Index]["ComicID"]);
                AProduct.ComicName = Convert.ToString(DB.DataTable.Rows[Index]["ComicName"]);
                AProduct.ComicInitialReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ComicInitialReleaseDate"]);
                AProduct.ComicArtist = Convert.ToString(DB.DataTable.Rows[Index]["ComicArtist"]);
                AProduct.ComicPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["ComicPrice"]);
                AProduct.ComicGenre = Convert.ToString(DB.DataTable.Rows[Index]["ComicGenre"]);
                AProduct.IsComicInStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsComicInStock"]);
                mProductList.Add(AProduct);
                Index++;
            }

        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@ComicName",mThisProduct.ComicName);
            DB.AddParameter("@ComicInitialReleaseDate",mThisProduct.ComicInitialReleaseDate);
            DB.AddParameter("@ComicArtist",mThisProduct.ComicArtist);
            DB.AddParameter("@ComicPrice",mThisProduct.ComicPrice);
            DB.AddParameter("@ComicGenre",mThisProduct.ComicGenre);
            DB.AddParameter("@IsComicInStock",mThisProduct.IsComicInStock);

            return DB.Execute("sproc_tblComic_Insert");
        }
    }
}