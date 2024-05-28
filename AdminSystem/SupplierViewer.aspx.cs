using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier(); //new instance of class
        AnSupplier = (clsSupplier)Session["AnSupplier"]; //get the details of suppliers from the session
        Response.Write(AnSupplier.SupplierName + "\r" + AnSupplier.ContactPerson + "\r" + AnSupplier.SupplierEmail + "\r" + AnSupplier.SupplierTelephone + "\r" + AnSupplier.InitialContractDate + "\r" + AnSupplier.SupplierActive);
    }
}