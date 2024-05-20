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
        if (IsPostBack == false)
        {
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        clsProductCollection Products = new clsProductCollection();
        lstComicList.DataSource = Products.ProductList;
        lstComicList.DataValueField = "ComicID";
        lstComicList.DataTextField = "ComicName";
        lstComicList.DataBind();
    }
}