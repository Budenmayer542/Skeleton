using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();
        //private member data for thisOrders
        clsOrders mThisOrders = new clsOrders();

        //constructor for the class
        public clsOrdersCollection()
        {
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            PopulateArray(DB);
        }

        //public property for the orders list
        public List<clsOrders> OrdersList {
            get
            {
                //return the private data
                return mOrdersList;
            }
            set
            {
                //set the private data
                mOrdersList = value;
            }
        }
        //public property for count
        public int Count { 
            get
            {
                //return the count of the list
                return mOrdersList.Count;
            }
            set
            {
                
            }
                }
        public clsOrders ThisOrders
        {
            get
            {
                return mThisOrders;
            }
            set
            {
                mThisOrders = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemCount", mThisOrders.ItemCount);
            DB.AddParameter("@DateOfOrder", mThisOrders.DateOfOrder);
            DB.AddParameter("@Dispatched", mThisOrders.Dispatched);
            DB.AddParameter("@SubTotal", mThisOrders.SubTotal);
            DB.AddParameter("@OrderTotal", mThisOrders.Total);
            DB.AddParameter("@DeliveryNote", mThisOrders.DeliveryNote);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrders.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void ReportByItemCount(string ItemCount)
        {
            //filters the records based on an item count
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the ItemCount parmeter to the database
            DB.AddParameter("@ItemCount", ItemCount);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByItemCount");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void Update()
        {
            //update an existing record based on the values of thisOrders
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@OrderNo", mThisOrders.OrderNo);
            DB.AddParameter("@ItemCount", mThisOrders.ItemCount);
            DB.AddParameter("@DateOfOrder", mThisOrders.DateOfOrder);
            DB.AddParameter("@Dispatched", mThisOrders.Dispatched);
            DB.AddParameter("@SubTotal", mThisOrders.SubTotal);
            DB.AddParameter("@OrderTotal", mThisOrders.Total);
            DB.AddParameter("@DeliveryNote", mThisOrders.DeliveryNote);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_Update");
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable to store the record count
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrdersList = new List<clsOrders>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order object
                clsOrders AnOrder = new clsOrders();
                //read in he fields from the current record
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.ItemCount = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemCount"]);
                AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);
                AnOrder.SubTotal = Convert.ToDouble(DB.DataTable.Rows[Index]["SubTotal"]);
                AnOrder.Total = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderTotal"]);
                AnOrder.DeliveryNote = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryNote"]);
                //add the record to the private data member
                mOrdersList.Add(AnOrder);
                //point at the net record
                Index++;
            }
        }
    }
}