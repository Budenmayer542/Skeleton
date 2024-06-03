using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if the is the not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
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
        AnCustomer.CustomerId = CustomerId;// dont miss this bit !!!
            //capture the fullname
        AnCustomer.FullName = FullName;
            //capture the emailaddress
        AnCustomer.EmailAddress = EmailAddress;
            //capture the signupdate
        AnCustomer.Signupdate = Convert.ToDateTime(Signupdate);
            //capture the active
        AnCustomer.Active = chkActive.Checked;
            //capture the phonenumber
        AnCustomer.PhoneNumber = PhoneNumber;
            //create an instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            
            //if this is a new record i.e customer id = -1 then add the data
            if (CustomerId == -1)
            {
                //set the thiscustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //Add the new record
                CustomerList.Add();
            }
            //OTHER wise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the thisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record
                CustomerList.Update();
            }
         //redirect back to the list page
        Response.Redirect("CustomerList.aspx");
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

    void DisplayCustomer()
    {
        //create an instance of the address book
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to update
        Customer.ThisCustomer.Find(CustomerId);
        //display the values of the properties in the form
        txtCustomerId.Text = Customer.ThisCustomer.CustomerId.ToString();
        txtFullName.Text = Customer.ThisCustomer.FullName.ToString();
        txtEmailAddress.Text = Customer.ThisCustomer.EmailAddress.ToString();
        txtPhoneNumber.Text = Customer.ThisCustomer.PhoneNumber.ToString();
        txtSignUp.Text = Customer.ThisCustomer.Signupdate.ToString();
        chkActive.Checked = Customer.ThisCustomer.Active;

    }

    protected void txtCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}