using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Create an instance of the Product User class
        clsProductUser AnUser = new clsProductUser();
        //Create the variables to store the username and password
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //Create a variable to store the result of the find user operation
        Boolean Found = false;
        //Get the username input
        UserName = Convert.ToString(txtUserName.Text);
        //Get te password input
        Password = Convert.ToString(txtPassword.Text);
        //Find the record
        Found = AnUser.FindUser(UserName, Password);
        //If a field is empty
        if (txtUserName.Text == "")
        {
            //Record the error
            lblError.Text = "Enter a Username ";
        }
        else if (txtPassword.Text == "")
        {
            //Record the error
            lblError.Text = "Enter a Password";
        }
        //If found
        else if (Found == true)
        {
            //Redirect to the Product List page
            Response.Redirect("ProductList.aspx");
        }
        else if (Found == false)
        {
            //Record the error
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }
}