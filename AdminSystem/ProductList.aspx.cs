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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ComicID"] = -1;
        Response.Redirect("ProductDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ComicID;
        if (lstComicList.SelectedIndex != -1)
        {
            ComicID = Convert.ToInt32(lstComicList.SelectedValue);
            Session["ComicID"] = ComicID;
            Response.Redirect("ProductDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ComicID;
        if (lstComicList.SelectedIndex != -1)
        {
            ComicID = Convert.ToInt32(lstComicList.SelectedValue);
            Session["ComicID"] = ComicID;
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}