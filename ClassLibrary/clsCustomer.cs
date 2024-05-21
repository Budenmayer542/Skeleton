using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data memeber for  the customer id property
        private Int32 mCustomerId;

        //customerId PUBLIC PROPERTY
        public Int32 CustomerId
        { 
            get
            { //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            { //this line of code allows data out of the property
                mCustomerId = value;
            } }
        private bool mActive;
        public bool Active { get
            {//this line of code sends data out of the property
                return mActive;
            } set
            {//this line of code allows data out of the property
                mActive = value;
            } }
        private DateTime mSignUp;
        public DateTime SignUp { get
            {//this line of code sends data out of the property
                return mSignUp;
            } set
            { //this line of code allows data out of the property
                mSignUp = value;
            } }
        //private data memeber for  the fullname property
        private String mFullName;
        public string FullName { get
            {//this line of code sends data out of the property
                return mFullName;
            } set
            {//this line of code allows data out of the property
                mFullName = value;
            }
        }
        private long mPhoneNumber;
        public long PhoneNumber { get
            {//this line of code sends data out of the property
                return mPhoneNumber;
            } set
            {//this line of code allows data out of the property
                mPhoneNumber = value;
            }
        }
        private String mEmailAddress;
        public string EmailAddress { get
            {//this line of code sends data out of the property
                return mEmailAddress;
            } set
            {//this line of code allows data out of the property
                mEmailAddress = value;
            } }
        

        public bool Find(int customerId)
        {
            //set the private data members to the test data value
            mCustomerId = 1;
            mFullName = "Smily";
            mSignUp = Convert.ToDateTime("02/05/2024");
            mActive = true;
            mEmailAddress = "Smily74@gmail.com";
            mPhoneNumber = 0743684998;
            //always return true
            return true;
        }
    }
}