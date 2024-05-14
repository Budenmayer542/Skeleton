using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public clsProduct()
        {
            
        }

        public bool Active { get; set; }

        private Int32 mComicID;
        public Int32 ComicID
        {
            get
            { 
                return mComicID; 
            }
            set 
            { 
                mComicID = value; 
            }
        }

        private string mComicName;
        public string ComicName
        {
            get
            {
                
                return mComicName;
            }
            set
            {
                
                mComicName = value;
            }
        }

        private DateTime mComicInitialReleaseDate;
        //date added public property
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

        private string mComicArtist;
        //post code public property
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

        private Double mComicPrice;
        //date added public property
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

        private string mComicGenre;
        //town public property
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

        private Boolean mIsComicInStock;
        //active public property
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
            //Always returns true
            mComicID = 1;
            mComicName = "Mirai Nikki";
            mComicInitialReleaseDate = Convert.ToDateTime("23/12/2022");
            mComicArtist = "AAA";
            mComicPrice = 7.99;
            mComicGenre = "Action";
            mIsComicInStock = true;
            //Always returns true
            return true;
        }

    }
}