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
        public int ComicID { get; set; }
    }
}