using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public string EmailAddress;
        public int CustomerId;
        public int PhoneNumber;

        public bool Active { get; set; }
        public DateTime SignUp { get; set; }
        public string FullName { get; set; }
    }
}