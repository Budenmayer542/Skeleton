using System;
using System.IO;

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
        private String mEmailAddress;
        public string EmailAddress
        {
            get
            {//this line of code sends data out of the property
                return mEmailAddress;
            }
            set
            {//this line of code allows data out of the property
                mEmailAddress = value;
            }
        }
        private string mPhoneNumber;
        public string PhoneNumber { get
            {//this line of code sends data out of the property
                return mPhoneNumber;
            } set
            {//this line of code allows data out of the property
                mPhoneNumber = value;
            }
        }
        private DateTime mSignupdate;
        public DateTime Signupdate
        {
            get
            {//this line of code sends data out of the property
                return mSignupdate;
            }
            set
            { //this line of code allows data out of the property
                mSignupdate = value;
            }
        }
        private bool mActive;
        public bool Active
        {
            get
            {//this line of code sends data out of the property
                return mActive;
            }
            set
            {//this line of code allows data out of the property
                mActive = value;
            }
        }



        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramter for the customer id to search for
            DB.AddParameter("CustomerId", CustomerId);
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1) { //copy the data from the database to the private daat members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mSignupdate = Convert.ToDateTime(DB.DataTable.Rows[0]["Signupdate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked Ok
                return true;
            }
            //if on record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
           
        }

        public string Valid(string FullName, string EmailAddress, string PhoneNumber, string Signupdate)
        {
            //create a string variable to store the erro
            String Error = "";
            //create a temporary variable to store the date values
              DateTime DateTemp;
            //if fullname is blank
            if (FullName.Length == 0)
            {
                //RECORD the error
                Error = Error + "The FullName is may not be blank : ";

            }
            if (FullName.Length > 50)
            { //record the error
                Error = Error + "The fullname no must be less than 50 characters : ";
            }
            //create an instance of datetime to compare with datetemp
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            { //copy the signupdate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Signupdate);
                //check to see if the date is less than todays date
                if (DateTemp < DateComp)
                {
                    Error = Error + "The signupdate cannot be in the past : ";
                }
                //check  to see if the date is greater than todays date
                if (DateTemp > DateComp)
                { //record the error
                    Error = Error + "The signupdate cannot be in the future :";
                }
                }
            catch {//record the error
                Error = Error + "The date was not a valid date : ";
            }
            if (EmailAddress.Length == 0) //if email is blank
            {
                Error = Error + "The  email may not be blank : "; //record the error
            }

            if (EmailAddress.Length > 50) //if  email is grater than 50
            {
                Error = Error + "The  email must be less than 50 characters : "; //record the error
            }
            if(PhoneNumber.Length == 0) //if   PHONenumber is blank
            {
                Error = Error + "The phoneNuMBer may not be blank : "; //record the error
            }

            if (PhoneNumber.Length > 11) //if the PhoneNumber is grater than 11
            {
                Error = Error + "The phonenumber must be less than 11 characters : "; //record the error
            }
            return Error;
        }
    }
}