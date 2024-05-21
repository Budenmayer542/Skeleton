using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   
    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }



    protected void txtFullName_TextChanged(object sender, EventArgs e)
    {

    }

   

    protected void btnOk_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the fullname
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnCustomer.FullName = txtFullName.Text;
        AnCustomer.EmailAddress = txtEmailAddress.Text;
        AnCustomer.SignUp = Convert.ToDateTime(DateTime.Now);
        AnCustomer.Active = chkActive.Checked;
        AnCustomer.PhoneNumber = long.Parse(txtPhoneNumber.Text);
        //st0re the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}