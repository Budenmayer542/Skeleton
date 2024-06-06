using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ComicID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ComicID = Convert.ToInt32(Session["ComicID"]);
        // Check if it's the first time the page is loaded
        if (IsPostBack == false)
        {
            //If it's not a new record
            if (ComicID != -1)
            {
                //Display the current data from the record
                DisplayComic();
            }
        }
    }

    void DisplayComic()
    {
        //Create a new instance of the class
        clsProductCollection Product = new clsProductCollection();
        //Find the record to update
        Product.ThisProduct.Find(ComicID);
        //Output the data to the textboxes
        txtComicID.Text = Product.ThisProduct.ComicID.ToString();
        txtComicName.Text = Product.ThisProduct.ComicName.ToString();
        txtComicInitialReleaseDate.Text = Product.ThisProduct.ComicInitialReleaseDate.ToString();
        txtComicArtist.Text = Product.ThisProduct.ComicArtist.ToString();
        txtComicGenre.Text = Product.ThisProduct.ComicGenre.ToString();
        txtComicPrice.Text = Product.ThisProduct.ComicPrice.ToString();
        chkActive.Checked = Product.ThisProduct.Active;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of the class
        clsProduct AProduct = new clsProduct();
        //Capture entered details
        string ComicName = txtComicName.Text;
        string ComicInitialReleaseDate = txtComicInitialReleaseDate.Text;
        string ComicArtist = txtComicArtist.Text;
        string ComicPrice = txtComicPrice.Text;
        string ComicGenre = txtComicGenre.Text;
        string IsComicInStock = chkActive.Text;
        string Error = "";
        Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre, ComicPrice);
        if (Error == "")
        {
           //Assign the caputred data to the variables
            AProduct.ComicID = ComicID;
            AProduct.ComicName = ComicName;
            AProduct.ComicInitialReleaseDate = Convert.ToDateTime(ComicInitialReleaseDate);
            AProduct.ComicArtist = ComicArtist;
            AProduct.ComicGenre = ComicGenre;
            AProduct.ComicPrice = (double)Convert.ToDecimal(ComicPrice);
            AProduct.IsComicInStock = chkActive.Checked;
            //Create a new instance of the class we want to create
            clsProductCollection ProductList = new clsProductCollection();
            //If this is a new record then add the data
            if (ComicID == -1)
            {
                //Set the product property
                ProductList.ThisProduct = AProduct;
                //Add the new record
                ProductList.Add();
            }
            //Else it's an update
            else
            {
                //Find the record to update
                ProductList.ThisProduct.Find(ComicID);
                //Set the record
                ProductList.ThisProduct = AProduct;
                //pdate the record
                ProductList.Update();
            }
            Response.Redirect("ProductList.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


        //Navigate to the view page
        //Response.Redirect("ProductViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create a new instance
        clsProduct AProduct = new clsProduct();
        //Create a variable for the ComicID
        Int32 ComicID;
        //Store the result of the Find method
        Boolean Found = false;
        //Get primary key entered by user
        ComicID = Convert.ToInt32(txtComicID.Text);
        //Find the record
        Found = AProduct.Find(ComicID);
        if (Found == true)
        {
            //Display the values of the properties in the form
            txtComicName.Text = AProduct.ComicName;
            txtComicInitialReleaseDate.Text = AProduct.ComicInitialReleaseDate.ToString();
            txtComicArtist.Text = AProduct.ComicArtist;
            txtComicPrice.Text = AProduct.ComicPrice.ToString();
            txtComicGenre.Text = AProduct.ComicGenre;
            chkActive.Checked = AProduct.IsComicInStock;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}