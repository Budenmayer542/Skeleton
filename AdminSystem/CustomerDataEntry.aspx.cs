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
        string FullName = txtFullName.Text;
        //capture the emailaddress
        string EmailAddress = txtEmailAddress.Text;
        //capture the phonenumber
        string PhoneNumber = txtPhoneNumber.Text;
        //capture the signupdate
        string Signupdate = txtPhoneNumber.Text;
        //capture the Active
        string Active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(FullName, EmailAddress, PhoneNumber, Signupdate);
        if (Error == "")
        { 
            //capture the customerid
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            //capture the fullname
        AnCustomer.FullName = txtFullName.Text;
            //capture the emailaddress
        AnCustomer.EmailAddress = txtEmailAddress.Text;
            //capture the signupdate
        AnCustomer.Signupdate = Convert.ToDateTime(DateTime.Now);
            //capture the active
        AnCustomer.Active = chkActive.Checked;
            //capture the phonenumber
        AnCustomer.PhoneNumber = txtPhoneNumber.Text;
        //st0re the address in the session object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
        else
        { //display the error message
            lblError.Text = Error;
        }
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