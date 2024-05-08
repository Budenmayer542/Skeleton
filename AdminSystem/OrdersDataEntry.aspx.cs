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
        //capture the Order no
        AnOrder.OrderNo = txtOrderNo.Text;
        //store the Order in the session object
        Session["AnOrders"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }
}