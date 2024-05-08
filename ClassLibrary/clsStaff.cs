using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {

        }

        public bool Active { get; set; }
        public string StaffRole { get; set; }
        public int StaffNumber { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public DateTime DateAdded { get; set; }
        public double StaffSalary { get; set; }
    }
}