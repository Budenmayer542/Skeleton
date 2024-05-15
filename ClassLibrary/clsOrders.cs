using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the order number property
        private Int32 mOrderNo;
        //private data member for the date of order property
        private DateTime mDateOfOrder;
        //private data member for the item count property
        private Int32 mItemCount;
        //private data member for the dispatched property
        private Boolean mDispatched;
        //private data member for the subtotal property
        private Double mSubTotal;
        //private data member for the total property
        private Double mTotal;
        //private data member for the delivery note property
        private String mDeliveryNote;

        //DateOfOrder public property
        public DateTime DateOfOrder 
        {
            get
            {
                //this line of code sends data out of the property
                return mDateOfOrder;
            }
            set
            {
                //this line of code allows data into the property
                mDateOfOrder = value;
            }
        }
        //OrerNo public property
        public int OrderNo 
        { 
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }
        //ItemCount public property
        public int ItemCount 
        {
            get
            {
                //this line of code sends data out of the property
                return mItemCount;
            }
            set
            {
                //this line of code allows data into the property
                mItemCount = value;
            }
        }
        //Dispatched public property
        public bool Dispatched 
        {
            get
            {
                //this line of code sends data out of the property
                return mDispatched;
            }
            set
            {
                //this line of code allows data into the property
                mDispatched = value;
            }
        }
        //SubTotal public property
        public double SubTotal 
        {
            get
            {
                //this line of code sends data out of the property
                return mSubTotal;
            }
            set
            {
                //this line of code allows data into the property
                mSubTotal = value;
            }
        }
        //Total public property
        public double Total 
        {
            get
            {
                //this line of code sends data out of the property
                return mTotal;
            }
            set
            {
                //this line of code allows data into the property
                mTotal = value;
            }
        }
        //DeliveryNote public property
        public string DeliveryNote 
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryNote;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryNote = value;
            }
        }

        //find method
        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramete for the order number to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //if one record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mDateOfOrder = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfOrder"]);
                mItemCount = Convert.ToInt32(DB.DataTable.Rows[0]["ItemCount"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                mSubTotal = Convert.ToDouble(DB.DataTable.Rows[0]["SubTotal"]);
                mTotal = Convert.ToDouble(DB.DataTable.Rows[0]["OrderTotal"]);
                mDeliveryNote = Convert.ToString(DB.DataTable.Rows[0]["DeliveryNote"]);
                //return that everything wored OK
                return true;
            }
            //if no record was found
            else 
            { 
                //return false indicating there is a problem
                return false; 
            }
        }

        public string Valid(string itemCount, string dateOfOrder, string subTotal, string total, string deliveryNote)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the ItemCount is blank
            if (itemCount.Length == 0)
            {
                //record the error
                Error = Error + "The number of items may not be blank : ";
            }
            //if the item count is greater than 6 characters
            if (itemCount.Length>4)
            {
                //record the error
                Error = Error + "The number of items must be less than 6 characters : ";
            }
            //copy the dateOfOrder vale to the DateTemp variable
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //copy the DateOfOrder value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfOrder);

                if (DateTemp < DateComp) //compare dateOfOrder with Date
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greate than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //return any error messages
            return Error;
        }
    }
}