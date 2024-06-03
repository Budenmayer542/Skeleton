using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //PRIVATE member data for thiscustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> CustomerList
        {
            get
            { //return the private data
                return mCustomerList;
            }
            set
            {//set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            { //return the count of the list
                return mCustomerList.Count;
            }
            set
            { 
                //we shall worry about this later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            { //return property for this customer
                return mThisCustomer;
            }
            set
            {//SET the private data
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);   
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisSupplier
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Signupdate", mThisCustomer.Signupdate);
            DB.AddParameter("@Active", mThisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert"); //Execute the query returning the priamry key value 
        }

        public void Update()
        {
            //update an existing record based on the values of thiscustomer
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@FullName", mThisCustomer.FullName);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@Signupdate", mThisCustomer.Signupdate);
            DB.AddParameter("@Active", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByFullName(string FullName)
        {
            //filters the records based on full or partial fullname
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the fullname parameter to the database
            DB.AddParameter("@FullName", FullName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByFullName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //Populatearray the array list based on the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //count of records
            RecordCount = DB.Count;
            //Clear the praviate array list
            mCustomerList = new List<clsCustomer>();
            //while there are recrods to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current record
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnCustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnCustomer.Signupdate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Signupdate"]);
                //add the record to the privata data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;

            }

        }
    }

}



