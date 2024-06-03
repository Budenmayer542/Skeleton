using System;
using System.IO;


namespace ClassLibrary
{
    public class clsCustomerUser
    {
        // Private dat member for the user id property
        private Int32 mUserID;
        //private data member for the user name property
        private string mUserName;
        //private data memeber for the password property
        private string mPassword;
        //private data member for the department property
        private string mDepartment;
        public int UserID 
        { 
            get 
            {
                //return the private data
                return mUserID;
            } set 
            {
                //set the private data
                mUserID = value;
            } 
        }
        public string UserName
        {
            get
            {
                //return the private data
                return mUserName;
            }
            set
            {
                //set the private data
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            clsDataConnection DB = new clsDataConnection(); //new instance of data connection
            //parameters for the user username and password to search for 
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            DB.Execute("sproc_tblUsers_FindUserNamePW"); //execute stored procedure
            if (DB.Count == 1)
            {
                //copy the data from the database to private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true; //return true to confirm everything worked
            }
            else
            {
                return false;
            }
        }
    }
}