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
        //Create a new instance of clsProductUser
        clsProductUser AnUser = new clsProductUser();
        //get data from the session object
        AnUser = (clsProductUser)Session["AnUser"];
        //Display the username
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayProducts()
    {
        //Create a new instance
        clsProductCollection Products = new clsProductCollection();
        //Set the data source
        lstComicList.DataSource = Products.ProductList;
        //Set the name of the primary key
        lstComicList.DataValueField = "ComicID";
        //Set the name of he comic name to display
        lstComicList.DataTextField = "ComicName";
        //Bind the data to the list
        lstComicList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 to indicate a new record
        Session["ComicID"] = -1;
        //Redirect to data entry page
        Response.Redirect("ProductDataEntry.aspx"); 
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable for the comic ID
        Int32 ComicID;
        //If a record has been selected
        if (lstComicList.SelectedIndex != -1)
        {
            //Get primary key value of the selected record
            ComicID = Convert.ToInt32(lstComicList.SelectedValue);
            //Store the data in the session object
            Session["ComicID"] = ComicID;
            //Redirect to the edit page
            Response.Redirect("ProductDataEntry.aspx");
        }
        //If no record has been selected
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Variable to store Comic ID
        Int32 ComicID;
        //If a record has been selected 
        if (lstComicList.SelectedIndex != -1)
        {
            //get the primary value of the record to be deleted
            ComicID = Convert.ToInt32(lstComicList.SelectedValue);
            //Store the data in the session object
            Session["ComicID"] = ComicID;
            //Redirect to confirm page
            Response.Redirect("ProductConfirmDelete.aspx");
        }
        //If no record has been selected
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //Create an instance if the address object
        clsProductCollection AProduct = new clsProductCollection();
        //Retrieve the value of comic name from the presentation layer
        AProduct.ReportByComicName(txtFilter.Text);
        //Set the data source to the list of comics in the collection
        lstComicList.DataSource = AProduct.ProductList;
        //Set the name of the primary key
        lstComicList.DataValueField = "ComicID";
        lstComicList.DataTextField = "ComicName";
        lstComicList.DataBind();


    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //Create a new instance of the object
        clsProductCollection AProduct = new clsProductCollection();
        //Set an empty string
        AProduct.ReportByComicName("");
        //Clear any text in the text field
        txtFilter.Text = "";
        //set the data source to the product list
        lstComicList.DataSource = AProduct.ProductList;
        //Set the primary key
        lstComicList.DataValueField = "ComicID";
        //Set the displayed name
        lstComicList.DataTextField = "ComicName";
        //Bnd the data to the list
        lstComicList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}