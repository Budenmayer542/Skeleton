using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();

        public List<clsSupplier> SupplierList
        {
            get 
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                //*** FOR LATER ***\\
            }
        }

        public clsSupplierCollection()
        {
            clsSupplier TestItem = new clsSupplier(); //create the items of test data
            //set the properties 
            TestItem.SupplierActive = true;
            TestItem.SupplierId = 1;
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "jeff";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            mSupplierList.Add(TestItem); //Add test item to the test list
            TestItem = new clsSupplier(); //re initialise for new data
            //set the properties
            TestItem.SupplierActive = true;
            TestItem.SupplierId = 2;
            TestItem.SupplierName = "Manga comics ltd";
            TestItem.ContactPerson = "adam";
            TestItem.SupplierEmail = "MangaComicsLtd@outlook.com";
            TestItem.SupplierTelephone = "07738062845";
            TestItem.InitialContractDate = DateTime.Now;
            mSupplierList.Add(TestItem);
        }


















        public clsSupplier ThisSupplier { get; set; }






    }
}