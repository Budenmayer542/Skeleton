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
        string SupplierName = txtSupplierName.Text; //capture Supplier name
        string ContactPerson = txtContactPerson.Text; //capture Contact person
        string SupplierEmail = txtSupplierEmail.Text; //capture Supplier email
        string SupplierTelephone = txtSupplierTelephone.Text; //capture Supplier telephone
        string InitialContractDate = txtInitialContactDate.Text; //capture Initial contact date
        string Error = "";
        Error = AnSupplier.Valid(SupplierName, ContactPerson, SupplierEmail, SupplierTelephone, InitialContractDate);
        if (Error == "")
        {
            AnSupplier.SupplierName = SupplierName; //capture Supplier name
            AnSupplier.ContactPerson = ContactPerson; //capture Contact person
            AnSupplier.SupplierEmail = SupplierEmail; //capture Supplier email
            AnSupplier.SupplierTelephone = SupplierTelephone; //capture Supplier telephone
            AnSupplier.InitialContractDate = Convert.ToDateTime(InitialContractDate); //capture Initial contact date
            AnSupplier.SupplierActive = chkActive.Checked; //capture Supplier active
            clsSupplierCollection SupplierList = new clsSupplierCollection(); //new instance of supplier collection
            SupplierList.ThisSupplier = AnSupplier;
            SupplierList.Add();
            Response.Redirect("SupplierList.aspx"); //navigate to view page
        }
        else
        {
            lblError.Text = Error; //Display the error message
        }
        
        
            
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier(); //Creates a new instance of supplier class
        Int32 SupplierId; //create a varable to store primary key
        Boolean Found = false; //Stores the result of the find operation
        SupplierId = Convert.ToInt32(txtSupplierId.Text); //get primary key entered by user 
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