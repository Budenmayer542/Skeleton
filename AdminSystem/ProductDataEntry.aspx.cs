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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsProduct AProduct = new clsProduct();
        string ComicID = txtComicID.Text;
        string ComicName = txtComicName.Text;
        string ComicInitialReleaseDate = txtComicInitialReleaseDate.Text;
        string ComicArtist = txtComicArtist.Text;
        string ComicPrice = txtComicPrice.Text;
        string ComicGenre = txtComicGenre.Text;
        string IsComicInStock = chkActive.Text;
        string Error = "";
        Error = AProduct.Valid(ComicName, ComicArtist, ComicInitialReleaseDate, ComicGenre);
        if (Error == "")
        {
            AProduct.ComicName = txtComicName.Text;
            AProduct.ComicInitialReleaseDate = Convert.ToDateTime(txtComicInitialReleaseDate.Text);
            AProduct.ComicArtist = txtComicArtist.Text;
            AProduct.ComicGenre = txtComicGenre.Text;
            Session["AProduct"] = AProduct;
            //Navigate to the view page
            Response.Redirect("ProductViewer.aspx");
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