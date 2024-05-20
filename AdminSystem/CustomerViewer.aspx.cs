using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //st0re the address in the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //navigate to the view page
        Response.Write(AnCustomer.CustomerId);
        Response.Write(AnCustomer.FullName);
        Response.Write(AnCustomer.EmailAddress);
        Response.Write(AnCustomer.SignUp);
        Response.Write(AnCustomer.Active);

    }
}