using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier(); //new instance
        AnSupplier.SupplierName = txtSupplierName.Text; //capture name
        AnSupplier.ContactPerson = txtContactPerson.Text;
        AnSupplier.SupplierEmail = txtSupplierEmail.Text;
        AnSupplier.SupplierTelephone = txtSupplierTelephone.Text;
        AnSupplier.InitialContractDate = Convert.ToDateTime(DateTime.Now);
        AnSupplier.SupplierActive = chkActive.Checked;
        
        


        Session["AnSupplier"] = AnSupplier; // store name in session object
        Response.Redirect("SupplierViewer.aspx"); //navigate to view page
    }
}