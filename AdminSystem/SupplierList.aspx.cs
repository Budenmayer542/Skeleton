using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) //if this is the first time the page is displayed
        {
            DisplaySuppliers(); //update the listbox
        }
    }

    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection(); //new instance of supplier collection
        lstSupplierList.DataSource = Suppliers.SupplierList; //set the data sourse to the list of addresses in the collection
        lstSupplierList.DataValueField = "SupplierId"; //set the name of the primary key
        lstSupplierList.DataTextField = "SupplierName"; //set the data field to display
        lstSupplierList.DataBind(); //bind the data to the list
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1; //store -1 into the session object to indicate this is a new record 
        Response.Redirect("SupplierDataEntry.aspx"); //redirect to data entry page
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierId; //variable to store primary key
        if (lstSupplierList.SelectedIndex != -1) //if the record has been selected from the list 
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue); //get the primary key value of the record to edit 
            Session["SupplierId"] = SupplierId; //store the data in the session object 
            Response.Redirect("SupplierDataEntry.aspx"); //redirect to the edit page 
        }
        else //if no record has been selected 
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierId; //variable to store primary key
        if (lstSupplierList.SelectedIndex != -1) //if the record has been selected from the list 
        {
            SupplierId = Convert.ToInt32(lstSupplierList.SelectedValue); //get the primary key value of the record to edit 
            Session["SupplierId"] = SupplierId; //store the data in the session object 
            Response.Redirect("SupplierConfirmDelete.aspx"); //redirect to the confirm delete page 
        }
        else //if no record has been selected 
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }



    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection AnSupplier = new clsSupplierCollection(); //new instance of supplier object
        AnSupplier.ReportBySupplierName(TxtSupplierNameInput.Text); //retrive the value of the supplier name from the presentation layer 
        lstSupplierList.DataSource = AnSupplier.SupplierList; //set the data sourse o the list of suppliers in the collection
        lstSupplierList.DataValueField = "SupplierId"; //set the name of the primary key
        lstSupplierList.DataTextField = "SupplierName"; //set the name of the field to display
        lstSupplierList.DataBind(); //bind the data to the list
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection AnSupplier = new clsSupplierCollection(); //new instance of supplier object
        AnSupplier.ReportBySupplierName(""); //set an empty string
        TxtSupplierNameInput.Text = ""; //clear any existing filter to tidy interface
        lstSupplierList.DataSource = AnSupplier.SupplierList; //set the data sourse o the list of suppliers in the collection
        lstSupplierList.DataValueField = "SupplierId"; //set the name of the primary key
        lstSupplierList.DataTextField = "SupplierName"; //set the name of the field to display
        lstSupplierList.DataBind(); //bind the data to the list
    }
}