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
}