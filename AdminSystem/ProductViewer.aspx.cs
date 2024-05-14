using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Create a new instance of a comic
        clsProduct AProduct = new clsProduct();
        //Get data from session object
        AProduct = (clsProduct)Session["AProduct"];
        //Display ID
        Response.Write(AProduct.ComicID + "\r" +
            AProduct.ComicName + "\r" +
            AProduct.ComicInitialReleaseDate + "\r" +
            AProduct.ComicArtist + "\r" +
            AProduct.ComicPrice + "\r" +
            AProduct.ComicGenre + "\r" +
            AProduct.IsComicInStock);
    }
}