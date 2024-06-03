using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsCustomerUser AnUser = new clsCustomerUser(); //instance of Supplier user class
        //variables to store username and password
        string UserName = TxtUserName.Text;
        string Password = TxtPassword.Text;
        Boolean Found = false; //variable to store the result of the find user operation
        UserName = Convert.ToString(TxtUserName.Text); //get the username entered by the user
        Password = Convert.ToString(TxtPassword.Text); //get the password entered by the user
        Found = AnUser.FindUser(UserName, Password); //find the record
        Session["AnUser"] = AnUser; //add a session to capture the username 
        if (TxtUserName.Text == "")
        {
            lblError.Text = "Enter a UserName "; //record the error
        }
        else if (TxtPassword.Text == "")
        {
            lblError.Text = "Enter a Password"; //record the error
        }
        else if (Found == true) //if found
        {
            Response.Redirect("CustomerList.aspx"); //redirect to list page
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again "; //record the error
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
