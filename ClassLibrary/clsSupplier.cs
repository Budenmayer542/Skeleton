using System;
using System.Reflection;

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

     

        public string Valid(string supplierName, string contactPerson, string supplierEmail, string supplierTelephone, string initialContractDate)
        {
            String Error = ""; //stores the error
            DateTime DateTemp; //temporary variable to store the date value

            if(supplierName.Length == 0) //if supplier name is blank
            {
                Error += "The supplier name may not be blank : "; //record the error
            }

            if(supplierName.Length > 50) //if the supplier name is grater than 50
            {
                Error += "The supplier name must be less than 50 characters"; //record the error
            }

            if (contactPerson.Length == 0) //if Contact person is blank
            {
                Error += "The contact person may not be blank : "; //record the error
            }

            if (contactPerson.Length > 20) //if the Contact person is grater than 50
            {
                Error += "The contact person must be less than 20 characters"; //record the error
            }

            if (supplierEmail.Length == 0) //if supplier email is blank
            {
                Error += "The supplier email may not be blank : "; //record the error
            }

            if (supplierEmail.Length > 30) //if the supplier email is grater than 30
            {
                Error += "The supplier email must be less than 30 characters"; //record the error
            }

            if (supplierTelephone.Length == 0) //if supplier telephone is blank
            {
                Error += "The supplier telephone may not be blank : "; //record the error
            }

            if (supplierTelephone.Length > 15) //if the supplier telephone is grater than 15
            {
                Error += "The supplier telephone must be less than 15 characters"; //record the error
            }

            DateTime DateComp = DateTime.Now.Date; //instance of datetime to compare with datetemp (in the if statements)

            try
            {
                DateTemp = Convert.ToDateTime(initialContractDate); //copied the initial contract date to the datetemp variable

                if (DateTemp < DateComp) //Compare initialContractDate with date
                {
                    Error += "The Date Cannot be in the past : "; //Record the error
                }

                if (DateTemp > DateComp) //check to see if the date is greater than todays date
                {
                    Error += "The date cannot be in the future : "; //record the error
                }
            }
            catch
            {
                Error += "The date was not a valid date : ";
            }

            return Error; //return error message 
        }


    }
}