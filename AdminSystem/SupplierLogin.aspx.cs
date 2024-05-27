using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SupplierLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsSupplierUser AnUser = new clsSupplierUser(); //instance of Supplier user class
        //variables to store username and password
        string UserName = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false; //variable to store the result of the find user operation
        UserName = Convert.ToString(txtUsername.Text); //get the username entered by the user
        Password = Convert.ToString(txtPassword.Text); //get the password entered by the user
        Found = AnUser.FindUser(UserName, Password); //find the record
        if (txtUsername.Text == "")
        {
            lblError.Text = "Enter a Username "; //record the error
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password"; //record the error
        }
        else if (Found == true) //if found
        {
            Response.Redirect("SupplierList.aspx"); //redirect to list page
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again "; //record the error
        }
    }
}