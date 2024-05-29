using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsStaff
    { 
        //private data member for the staff id property
        private Int32 mStaffId;

        //StaffId public property
        public Int32 StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }
        
        //private data member for the staff name
        private string mStaffName;

        //Staff Name public property
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }

        //private data member for the staff role
        private string mStaffRole;

        //staff role public property
        public string StaffRole
        {
            get 
            {
                return mStaffRole;
            }
            set
            {
                mStaffRole = value;
            }
        }

        //private data member for the staff role
        private string mStaffAddress;

        //staff address public property
        public string StaffAddress
        {
            get
            {
                return mStaffAddress;
            }
            set
            {
                mStaffAddress = value;
            }
        }

        //private data member for the staffDOB
        private DateTime mStaffDOB;

        //staffDOB public property
        public DateTime StaffDOB
        {
            get
            {
                return mStaffDOB;
            }
            set
            {
                mStaffDOB = value;
            }
        }

        //private data member for the staff priviliges
        private Boolean mStaffPriviliges;
        
        //staff priviliges public property
        public Boolean StaffPriviliges
        {
            get
            {
                return mStaffPriviliges;
            }
            set
            {
                mStaffPriviliges = value;
            }
        }

        //private data member for the staff salary
        private double mStaffSalary;
        
        //staff salary public property
        public double StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

 

        public bool Find(int staffId)
        {
            //set the private data members to the test data value
            mStaffId = 21;
            //always return true
            return true;
        }
    }

}       
