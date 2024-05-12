using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    public class TstCustomer
    {
        public void Instanceok()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exits
            Assert.IsNotNull(AnCustomer);
        }
    }
}
