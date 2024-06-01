using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //updete the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of the customer in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the data field to display
        lstCustomerList.DataTextField = "FullName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to edited
        Int32 CustomerId;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object 
            Session["CustomerId"] = CustomerId;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            //if no record has been selected
            lblError.Text = "please select a record from the list to edit";        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be delete
        Int32 CustomerId;
        //if a record has been selected from list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to the delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else//if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        // create an  instance of the customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //retrieve the value of the fullname from the presentation layer
        AnCustomer.ReportByFullName(TextFullNameinput.Text);
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "FullNmae";
        //bind the data to the list
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // create an  instance of the customer object
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        //set an empty string
        AnCustomer.ReportByFullName("");
        //clear any existing filter to tidy up the interface
        TextFullNameinput.Text = "";
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerId";
        //set the name of the field to display
        lstCustomerList.DataTextField = "FullNmae";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}