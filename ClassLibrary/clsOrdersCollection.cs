using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        List<clsOrders> mOrdersList = new List<clsOrders>();

        //constructor for the class
        public clsOrdersCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrder = new clsOrders();
                //read in the fields for the current record
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.ItemCount = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemCount"]);
                AnOrder.DateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfOrder"]);
                AnOrder.SubTotal = Convert.ToDouble(DB.DataTable.Rows[Index]["SubTotal"]);
                AnOrder.Total = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderTotal"]);
                AnOrder.DeliveryNote = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryNote"]);
                //add the reocrd to the private data member
                mOrdersList.Add(AnOrder);
                //point at the next record
                Index++;
            }
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
        public clsOrders ThisOrders { get; set; }
    }
}