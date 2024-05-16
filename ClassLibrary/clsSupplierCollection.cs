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
            Int32 Index = 0; //Variable for the index
            Int32 RecordCount = 0; //varable for record count 
            clsDataConnection DB = new clsDataConnection(); //onject for the data connect
            DB.Execute("sproc_tblSupplier_SelectAll"); //execute the stored procedure 
            RecordCount = DB.Count; //get the count of records
            while (Index < RecordCount) //while there are records to process
            {
                clsSupplier AnSupplier = new clsSupplier(); //blank supplier 
                //read in the fields for the current record 
                AnSupplier.SupplierActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierActive"]);
                AnSupplier.SupplierId = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierId"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.ContactPerson = Convert.ToString(DB.DataTable.Rows[Index]["ContactPerson"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.SupplierTelephone = Convert.ToString(DB.DataTable.Rows[Index]["SupplierTelephone"]);
                AnSupplier.InitialContractDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["InitialContractDate"]);
                mSupplierList.Add(AnSupplier); //Add records to private data member
                Index++; //point at the next record
            }

            
        }

        public clsSupplier ThisSupplier { get; set; }






    }
}