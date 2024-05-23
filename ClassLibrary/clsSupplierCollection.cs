using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>(); //private data member for the list
        clsSupplier mThisSupplier = new clsSupplier(); //private data member for thisSupplier

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



        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier; //return the private data
            }
            set
            {
                mThisSupplier = value; //set the private data
            }
        }

        public clsSupplierCollection()
        {
            Int32 Index = 0; //Variable for the index
            Int32 RecordCount; //varable for record count 
            clsDataConnection DB = new clsDataConnection(); //onject for the data connect
            DB.Execute("sproc_tblSupplier_SelectAll"); //execute the stored procedure 
            RecordCount = DB.Count; //get the count of records
            while (Index < RecordCount) //while there are records to process
            {
                clsSupplier AnSupplier = new clsSupplier(); //blank supplier 
                //read in the fields for the current record 
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.ContactPerson = Convert.ToString(DB.DataTable.Rows[Index]["ContactPerson"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.SupplierTelephone = Convert.ToString(DB.DataTable.Rows[Index]["SupplierTelephone"]);
                AnSupplier.InitialContractDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["InitialContractDate"]);
                AnSupplier.SupplierActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierActive"]);
                mSupplierList.Add(AnSupplier); //Add records to private data member
                Index++; //point at the next record
            }


        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisSupplier
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactPerson", mThisSupplier.ContactPerson);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@SupplierTelephone", mThisSupplier.SupplierTelephone);
            DB.AddParameter("@InitialContractDate", mThisSupplier.InitialContractDate);
            DB.AddParameter("@SupplierActive", mThisSupplier.SupplierActive);

            return DB.Execute("sproc_tblSupplier_Insert"); //Execute the query returning the priamry key value 
        }


    }
}