using System;
using System.IO;

namespace ClassLibrary
{
    public class clsSupplierUser
    {
        //private data members for the propertys
        private Int32  mUserID; 
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        public int UserID
        {
            get
            {
                return mUserID; //return private data 
            }
            set
            {
                mUserID = value; //set the provate data
            }
        }

        public string UserName
        {
            get
            {
                return mUserName; //return private data 
            }
            set
            {
                mUserName = value; //set the provate data
            }
        }

        public string Password
        {
            get
            {
                return mPassword; //return private data 
            }
            set
            {
                mPassword = value; //set the provate data
            }
        }

        public string Department
        {
            get
            {
                return mDepartment; //return private data 
            }
            set
            {
                mDepartment = value; //set the provate data
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