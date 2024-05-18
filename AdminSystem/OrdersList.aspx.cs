using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the Orders Collection
        clsOrdersCollection orders = new clsOrdersCollection();
        //set the data source to list of orders in the collection
        lstOrdersList.DataSource = orders.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the data field to display
        lstOrdersList.DataTextField = "Total";
        //bind the dat to the list
        lstOrdersList.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}