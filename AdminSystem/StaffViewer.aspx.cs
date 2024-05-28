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
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //get the data from the session object
        AnStaff = (clsStaff)Session["AnStaff"];
        //display the staff entries for this entry
        Response.Write(AnStaff.StaffId);
        Response.Write(AnStaff.StaffName);
        Response.Write(AnStaff.StaffRole);
        Response.Write(AnStaff.StaffAddress);
        Response.Write(AnStaff.StaffDOB);
        Response.Write(AnStaff.StaffPriviliges);
        Response.Write(AnStaff.StaffSalary);
    }
}