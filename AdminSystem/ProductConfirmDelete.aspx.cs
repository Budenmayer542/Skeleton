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
        ComicID = Convert.ToInt32(Session["ComicID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsProductCollection Product = new clsProductCollection();
        Product.ThisProduct.Find(ComicID);
        Product.Delete();
        Response.Redirect("ProductList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductList.aspx");
    }
}