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
        
        string OrderNo = txtOrderNo.Text;
        string ItemCount = txtItemCount.Text;
        string DateOfOrder = txtDateOfOrder.Text; 
        string Dispatched = chkDispatched.Text; 
        string SubTotal = txtSubTotal.Text;
        string Total = txtTotal.Text;
        string DeliveryNote = txtDeliveryNote.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(ItemCount, DateOfOrder, SubTotal, Total, DeliveryNote);
        if (Error == "")
        {
            //capture data
            AnOrder.ItemCount = Convert.ToInt32(ItemCount);
            AnOrder.DateOfOrder = Convert.ToDateTime(DateOfOrder);
            AnOrder.SubTotal = Convert.ToDouble(SubTotal);
            AnOrder.Total = Convert.ToDouble(Total);
            AnOrder.DeliveryNote = DeliveryNote;
            AnOrder.Dispatched = chkDispatched.Checked;
            //create a new instance of the orders collection
            clsOrdersCollection OrdersList = new clsOrdersCollection();
            //set the ThisOrders property
            OrdersList.ThisOrders = AnOrder;
            //add the new record
            OrdersList.Add();
            //redirect back to the list page
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //diplay the error message
            lblError.Text = Error;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
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