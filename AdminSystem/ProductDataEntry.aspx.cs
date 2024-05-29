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
        if (IsPostBack == false)
        {
            if (ComicID != -1)
            {
                DisplayComic();
            }
        }
    }

    void DisplayComic()
    {
        clsProductCollection Product = new clsProductCollection();
        Product.ThisProduct.Find(ComicID);
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
        clsProduct AProduct = new clsProduct();
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
            AProduct.ComicID = ComicID;
            AProduct.ComicName = ComicName;
            AProduct.ComicInitialReleaseDate = Convert.ToDateTime(ComicInitialReleaseDate);
            AProduct.ComicArtist = ComicArtist;
            AProduct.ComicGenre = ComicGenre;
            AProduct.ComicPrice = (double)Convert.ToDecimal(ComicPrice);
            AProduct.IsComicInStock = chkActive.Checked;
            //Navigate to the view page
            clsProductCollection ProductList = new clsProductCollection();
            if (ComicID == -1)
            {
                ProductList.ThisProduct = AProduct;
                ProductList.Add();
            }

            else
            {
                ProductList.ThisProduct.Find(ComicID);
                ProductList.ThisProduct = AProduct;
                ProductList.Update();
            }
            Response.Redirect("ProductList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }


        //Navigate to the view page
        //Response.Redirect("ProductViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        Int32 ComicID;
        Boolean Found = false;
        ComicID = Convert.ToInt32(txtComicID.Text);
        Found = AProduct.Find(ComicID);
        if (Found == true)
        {
            txtComicName.Text = AProduct.ComicName;
            txtComicInitialReleaseDate.Text = AProduct.ComicInitialReleaseDate.ToString();
            txtComicArtist.Text = AProduct.ComicArtist;
            txtComicPrice.Text = AProduct.ComicPrice.ToString();
            txtComicGenre.Text = AProduct.ComicGenre;
            chkActive.Checked = AProduct.IsComicInStock;
        }


    }
}