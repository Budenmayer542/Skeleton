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

}