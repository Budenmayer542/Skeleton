using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        
        public int CustomerId;
        public string FullName;
        public string EmailAddress;
        public object PhoneNumber;

        public bool Active { get; set; }
        public DateTime SignUp { get; set; }
    }
}