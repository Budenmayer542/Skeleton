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
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the data
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.ItemCount = Convert.ToInt32(txtItemCount.Text);
        AnOrder.DateOfOrder = Convert.ToDateTime(DateTime.Now); 
        AnOrder.Dispatched = chkDispatched.Checked; 
        AnOrder.SubTotal = Convert.ToDouble(txtSubTotal.Text);
        AnOrder.Total = Convert.ToDouble(txtTotal.Text);
        AnOrder.DeliveryNote = txtDeliveryNote.Text;    



        //store the Order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the orders class
        clsOrders AnOrder = new clsOrders();
        //create a variable to store the primary key
        Int32 OrderNo;
        //create a variable to store the result of the find operation
        Boolean Found =false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtOrderNo.Text = AnOrder.OrderNo.ToString();
            txtItemCount.Text = AnOrder.ItemCount.ToString();
            txtDateOfOrder.Text = AnOrder.DateOfOrder.ToString();  
            txtSubTotal.Text = AnOrder.SubTotal.ToString();
            txtTotal.Text = AnOrder.Total.ToString();
            txtDeliveryNote.Text = AnOrder.DeliveryNote;
            chkDispatched.Checked = AnOrder.Dispatched;
        }
    }
}