using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]); //get the SupplierId from session

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection(); //new instance of class
        Suppliers.ThisSupplier.Find(SupplierId); //find the record to delete 
        Suppliers.Delete(); //delete the record 
        Response.Redirect("SupplierList.aspx"); //redirect back to the main page 
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx"); //redirect back to the main page
    }
}