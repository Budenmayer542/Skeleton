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
                mSupplierTelephone = value;
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

        //Find Method
        public bool Find(int SupplierId)
        {
            clsDataConnection DB = new clsDataConnection(); //creates an instance of the data connection 
            DB.AddParameter("@SupplierId", SupplierId); //add the param for the supplier ID to search for
            DB.Execute("sproc_tblSupplier_FilterBySupplierId"); //executes the stored procedure 
            if (DB.Count == 1) 
            {
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mContactPerson = Convert.ToString(DB.DataTable.Rows[0]["ContactPerson"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mSupplierTelephone = Convert.ToString(DB.DataTable.Rows[0]["SupplierTelephone"]);
                mInitialContractDate = Convert.ToDateTime(DB.DataTable.Rows[0]["InitialContractDate"]);
                mSupplierActive = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierActive"]);
                return true; //return that everything worked ok 
            }
            else //if no record was found 
            {
                return false; //then return false indicating there is a problem 
            } 
        }
    }
}