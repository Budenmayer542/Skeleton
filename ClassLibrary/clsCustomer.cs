using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime SignUp { get; set; }
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }
    }
}