using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public clsProduct()
        {
            
        }

        public bool Active { get; set; }

        public DateTime ComicInitialReleaseDate { get; set; }
        public string ComicName { get; set; }
        public string ComicArtist { get; set; }
        public double ComicPrice { get; set; }
        public string ComicGenre { get; set; }
        public bool IsComicInStock { get; set; }

        private Int32 mComicID;

        public Int32 ComicID
        {
            
                get
                        { return mComicID; }
            
            set { mComicID = value; }
        }
        public bool Find(int ComicID)
        {
            //Always returns true
            mComicID = 1;
            return true;
        }

    }
}