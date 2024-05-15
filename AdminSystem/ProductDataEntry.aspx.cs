﻿using System;
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
        AProduct.ComicID = Convert.ToInt32(txtComicID.Text);
        AProduct.ComicName = txtComicName.Text;
        AProduct.ComicInitialReleaseDate = Convert.ToDateTime(txtComicInitialReleaseDate.Text);
        AProduct.ComicArtist = txtComicArtist.Text;
        AProduct.ComicPrice = Convert.ToDouble(txtComicPrice.Text);
        AProduct.ComicGenre = txtComicGenre.Text;
        AProduct.IsComicInStock = chkActive.Checked;
        Session["AProduct"] = AProduct;
        //Navigate to the view page
        Response.Redirect("ProductViewer.aspx");
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