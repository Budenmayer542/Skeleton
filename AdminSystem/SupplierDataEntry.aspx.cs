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
        AnSupplier.SupplierId = Convert.ToInt32(txtSupplierID.Text); //capture ID
        AnSupplier.SupplierName = txtSupplierName.Text; 
        AnSupplier.ContactPerson = txtContactPerson.Text;
        AnSupplier.SupplierEmail = txtSupplierEmail.Text;
        AnSupplier.SupplierTelephone = txtSupplierTelephone.Text;
        AnSupplier.InitialContractDate = Convert.ToDateTime(DateTime.Now);
        AnSupplier.SupplierActive = chkActive.Checked;
        Session["AnSupplier"] = AnSupplier; // store name in session object
        Response.Redirect("SupplierViewer.aspx"); //navigate to view page
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier(); //Creates a new instance of supplier class
        Int32 SupplierId; //create a varable to store primary key
        Boolean Found = false; //Stores the result of the find operation
        SupplierId = Convert.ToInt32(txtSupplierID.Text); //get primary key entered by user 
        Found = AnSupplier.Find(SupplierId); //find the record 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtContactPerson.Text = AnSupplier.ContactPerson;
            txtSupplierEmail.Text = AnSupplier.SupplierEmail;
            txtSupplierTelephone.Text = AnSupplier.SupplierTelephone;
            txtInitialContactDate.Text = AnSupplier.InitialContractDate.ToString();
            chkActive.Checked = AnSupplier.SupplierActive;
        }
    }
}