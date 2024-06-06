using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public bool Active { get; set; }

        //Private Comic ID property
        private Int32 mComicID;
        //Public Comic ID property
        public Int32 ComicID // Public ComicID
        {
            get
            {
                //this line of code sends data out of the property
                return mComicID;
            }
            set 
            {
                //this line of code allows data into the property
                mComicID = value; 
            }
        }

        //Private Comic Name property
        private string mComicName;
        //Public Comic Name property
        public string ComicName
        {
            get
            {
                //this line of code sends data out of the property   
                return mComicName;
            }
            set
            {
                //this line of code allows data into the property
                mComicName = value;
            }
        }

        //Private Comic Initial Release Date property
        private DateTime mComicInitialReleaseDate;
        //Public Comic Initial Release Date property
        public DateTime ComicInitialReleaseDate
        {
            get
            {
                //this line of code sends data out of the property
                return mComicInitialReleaseDate;
            }
            set
            {
                //this line of code allows data into the property
                mComicInitialReleaseDate = value;
            }
        }
        // Private Comic Artist property
        private string mComicArtist;
        // Public Comic Artist property
        public string ComicArtist
        {
            get
            {
                //this line of code sends data out of the property
                return mComicArtist;
            }
            set
            {
                //this line of code allows data into the property
                mComicArtist = value;
            }
        }
        
        //Private Comic Price property
        private Double mComicPrice;
        //Public Comic Price property
        public Double ComicPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mComicPrice;
            }
            set
            {
                //this line of code allows data into the property
                mComicPrice = value;
            }
        }
        
        //Private Comic Genre property
        private string mComicGenre;
        //Public Comic Genre property
        public string ComicGenre
        {
            get
            {
                //this line of code sends data out of the property
                return mComicGenre;
            }
            set
            {
                //this line of code allows data into the property
                mComicGenre = value;
            }
        }

        //Private is comic in stock property
        private Boolean mIsComicInStock;
        //Public is comic in stock property
        public bool IsComicInStock
        {
            get
            {
                //this line of code sends data out of the property
                return mIsComicInStock;
            }
            set
            {
                //this line of code allows data into the property
                mIsComicInStock = value;
            }
        }

        public bool Find(int ComicID)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the ComicID parameter
            DB.AddParameter("@ComicID", ComicID);
            //Execute the stored procedure
            DB.Execute("sproc_tblComic_FilterByComicID");
            //Ececutes procedre if the database is not empty
            if (DB.Count == 1)
            {
                mComicID = Convert.ToInt32(DB.DataTable.Rows[0]["ComicID"]);
                mComicName = Convert.ToString(DB.DataTable.Rows[0]["ComicName"]);
                mComicInitialReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ComicInitialReleaseDate"]);
                mComicArtist = Convert.ToString(DB.DataTable.Rows[0]["ComicArtist"]);
                mComicPrice = Convert.ToDouble(DB.DataTable.Rows[0]["ComicPrice"]);
                mComicGenre = Convert.ToString(DB.DataTable.Rows[0]["ComicGenre"]);
                mIsComicInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["IsComicInStock"]);
                // Return true to indicate no issues
                return true;
            }
            // else if no record is found
            else
            {
                //Return flase to indicate an error
                return false;
            }
        }

        public string Valid(string comicName, string comicArtist, string comicInitialReleaseDate, string comicGenre, string comicPrice)
        {
            String Error = "";
            DateTime DateTemp;
            if(comicName.Length == 0)
            {
                Error = Error + "The comic name may not be blank: ";
            }

            if(comicName.Length > 50)
            {
                Error = Error + "The comic name must be 50 characters or less";
            }

            if (comicArtist.Length == 0)
            {
                Error = Error + "The comic artist may not be blank: ";
            }

            if (comicArtist.Length > 50)
            {
                Error = Error + "The comic artist must be 50 characters or less";
            }

            if (comicGenre.Length == 0)
            {
                Error = Error + "The comic genre may not be blank: ";
            }

            if (comicGenre.Length > 50)
            {
                Error = Error + "The comic genre must be 50 characters or less";
            }
            DateTime DateComp = DateTime.Now;
            try
            {
                DateTemp = Convert.ToDateTime(comicInitialReleaseDate);
                if (DateTemp > DateComp)
                { 
                    Error = Error + "The date cannor be in the future : ";
                }
                
            }
            catch
            {
                Error = Error + "The date was not a valid date or date format";
            }

            try
            {
                if (Convert.ToDouble(comicPrice) > 999999999999999999.99)
                {
                    Error = Error + "The price cannot be higher than 18 digits";
                }

                if (Convert.ToDouble(comicPrice) < 0)
                {
                    Error = Error + "The price cannot be in the negatives";
                }
            }
            catch
            {
                Error = Error + "The price is not in the correct format";
            }

            return Error;
        }
    }
}