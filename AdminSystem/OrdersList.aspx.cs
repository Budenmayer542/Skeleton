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
        //if this is the first time the page the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create the data source to list of the orders in the collection
        clsOrdersCollection Orders = new clsOrdersCollection();
        //set the date source to list of orders in the collection
        lstOrdersList.DataSource = Orders.OrdersList;
        //set the name of the pimary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the date field to display
        lstOrdersList.DataTextField = "Total";
        //bind the date to the list
        lstOrdersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the list
        Int32 OrderNo;
        //if a record has been selected from the list
        if(lstOrdersList.SelectedIndex !=-1) 
        {
            //get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void lstOrdersList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to sore the primary key value of the record to be deleted
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrdersList.SelectedIndex !=-1) 
        {
            //get the primary key value of the record delete
            OrderNo = Convert.ToInt32(lstOrdersList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the orders object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //retreive the value of item count from the presentation layer
        AnOrder.ReportByItemCount(txtItemCountFilter.Text);
        //set the data source to the list of orders in the collection
        lstOrdersList.DataSource = AnOrder.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the name of the field to dsplay
        lstOrdersList.DataTextField = "ItemCount";
        //bind the data to the list
        lstOrdersList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the orders object
        clsOrdersCollection AnOrder = new clsOrdersCollection();
        //set an empty string
        AnOrder.ReportByItemCount("");
        //clear any existing filter to tidy up the interface
        txtItemCountFilter.Text = "";
        //set the data souce to the list of orders in the collection
        lstOrdersList.DataSource = AnOrder.OrdersList;
        //set the name of the primary key
        lstOrdersList.DataValueField = "OrderNo";
        //set the name of the field to display
        lstOrdersList.DataTextField = "ItemCount";
        //bind the data to the list
        lstOrdersList.DataBind();

    }
}