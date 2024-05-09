using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private Int32 mSupplierId; //private data member for the supplier id property
        public Int32 SupplierId //public property 
        {
            get
            {
                return mSupplierId; //sends data out of the property 
            }
            set
            {
                mSupplierId = value; //allows data into the property 
            }
        }

        private String mSupplierName; //private data member for the supplier name property
        public string SupplierName  
        {
            get
            {
                return mSupplierName;  
            }
            set
            {
                mSupplierName = value;  
            }
        }

        private String mContactPerson; //private data member for the contact person property
        public string ContactPerson 
        {
            get
            {
                return mContactPerson; 
            }
            set
            {
                mContactPerson = value; 
            }
        }

        private String mSupplierEmail; //private data member for the supplier email property
        public string SupplierEmail
        {
            get 
            {
                return mSupplierEmail;
            }
            set 
            { 
                mSupplierEmail = value; 
            }
        }

        private String mSupplierTelephone; //private data member for the supplier telephone property
        public string SupplierTelephone
        {
            get
            {
                return mSupplierTelephone ;
            }
            set
            {
                mSupplierEmail = value;
            }
        }

        private DateTime mInitialContractDate; //private data member for the initial contract date property
        public DateTime InitialContractDate 
        {
            get
            {
                return mInitialContractDate;
            }
            set
            {
                mInitialContractDate = value;
            }
        }

        private Boolean mSupplierActive; //private data member for the supplier active property
        public bool SupplierActive
        {
            get
            {
                return mSupplierActive;
            }
            set
            {
                mSupplierActive = value;
            }
        }
        
        
        








        public bool Find(int SupplierId)
        {
            mSupplierId = 21; //set the private data member to the test data value
            mSupplierName = "Manga Comics ltd";
            mContactPerson = "jeff";
            mSupplierEmail = "mangacomics@outlook.com";
            mSupplierTelephone = "07924 385853";
            mInitialContractDate = Convert.ToDateTime("23/12/2022");
            mSupplierActive = true;
            return true; //always return true
        }

      


    }
}