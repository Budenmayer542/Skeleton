using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new istance of clsOrders
        clsOrders AnOrder = new clsOrders();
        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //display the data for this entry
        Response.Write(AnOrder.OrderNo);
        Response.Write(AnOrder.ItemCount);  
        Response.Write(AnOrder.DateOfOrder);
        Response.Write(AnOrder.Dispatched);
        Response.Write(AnOrder.SubTotal);
        Response.Write(AnOrder.Total);  
        Response.Write(AnOrder.DeliveryNote);   
    }
}