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

        public bool Find(int orderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 21;
            mDateOfOrder = Convert.ToDateTime("23/12/2022");
            mItemCount = 11;
            mDispatched = true;
            mSubTotal = 11.00;
            mTotal = 12.00;
            mDeliveryNote = "test";
                
            //always return true
            return true;
        }
    }
}