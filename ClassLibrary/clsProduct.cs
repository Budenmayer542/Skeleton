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
        public string ComicName { get; set; }
        public string ComicArtist { get; set; }
        public double ComicPrice { get; set; }
        public string ComicGenre { get; set; }
        public bool IsComicInStock { get; set; }
    }
}