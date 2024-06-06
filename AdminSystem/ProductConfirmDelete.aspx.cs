using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 ComicID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the ComicID from the session
        ComicID = Convert.ToInt32(Session["ComicID"]); 
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //New instance of the class we want to create
        clsProductCollection Product = new clsProductCollection();
        //Find the record to delete
        Product.ThisProduct.Find(ComicID);
        //Delete record
        Product.Delete();
        //Redirect to the main page
        Response.Redirect("ProductList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //Redirect to the main page
        Response.Redirect("ProductList.aspx");
    }
}