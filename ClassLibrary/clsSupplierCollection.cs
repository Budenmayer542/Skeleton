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
            clsDataConnection DB = new clsDataConnection(); //object for data connection
            DB.Execute("sproc_tblSupplier_SelectAll"); //execute the stored procedure
            PopulateArray(DB); //populate the array list with the data table
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

        public void Update()
        {
            //update an existing record based on the vales of ThisSupplier
            clsDataConnection DB = new clsDataConnection(); //Connect to the DB
            //set the parameters for the stored procedure 
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@ContactPerson", mThisSupplier.ContactPerson);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@SupplierTelephone", mThisSupplier.SupplierTelephone);
            DB.AddParameter("@InitialContractDate", mThisSupplier.InitialContractDate);
            DB.AddParameter("@SupplierActive", mThisSupplier.SupplierActive);
            DB.Execute("sproc_tblSupplier_Update"); //Execute the stored procedure 
        }

        public void Delete()
        {
            //deletes the record pointed to by thisSupplier
            clsDataConnection DB = new clsDataConnection(); //connect to DB
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId); //set param for stored procedure 
            DB.Execute("sproc_tblSupplier_Delete"); //execute the procedure 
        }

        public void ReportBySupplierName(string SupplierName)
        {
            //filters all records based on a full or partial supplier name
            clsDataConnection DB = new clsDataConnection(); //connect to DB
            DB.AddParameter("@SupplierName", SupplierName); //send the supplierName parameter to the DB
            DB.Execute("sproc_tblSupplier_FilterBySupplierName"); //execute the stored procedure
            PopulateArray(DB); //populate the array list within the data table
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array based on the data table in the parameter DB
            Int32 Index = 0; //variable for the index
            Int32 RecordCount; //variable for the record count
            RecordCount = DB.Count; //count of records 
            mSupplierList = new List<clsSupplier>(); //clear the private array list
            while (Index < RecordCount) //while there are records to preocess 
            {   
                clsSupplier AnSupplier = new clsSupplier(); //blank supplier object
                //read in the fields of the current record
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.ContactPerson = Convert.ToString(DB.DataTable.Rows[Index]["ContactPerson"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.SupplierTelephone = Convert.ToString(DB.DataTable.Rows[Index]["SupplierTelephone"]);
                AnSupplier.InitialContractDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["InitialContractDate"]);
                AnSupplier.SupplierActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierActive"]);
                mSupplierList.Add(AnSupplier); //adds the record to the priavte data member 
                Index++; //points to the next record
            } 
            
        }
    }
}