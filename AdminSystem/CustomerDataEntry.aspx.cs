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
        AnCustomer.Signupdate = Convert.ToDateTime(DateTime.Now);
        AnCustomer.Active = chkActive.Checked;
        AnCustomer.PhoneNumber = (txtPhoneNumber.Text);
        //st0re the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a variable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //found the record
        Found = AnCustomer.Find(CustomerId);
        //if found 
        if(Found == true)
        {
            //display the values of the properties in the form
            txtFullName.Text = AnCustomer.FullName;
            txtEmailAddress.Text = AnCustomer.EmailAddress;
            txtPhoneNumber.Text = AnCustomer.PhoneNumber;
            txtSignUp.Text = AnCustomer.Signupdate.ToString();
            chkActive.Checked = AnCustomer.Active;
           
        }
    }
}