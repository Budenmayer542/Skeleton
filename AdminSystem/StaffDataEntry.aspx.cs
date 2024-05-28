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

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
       clsStaff AnStaff = new clsStaff();
        //capture the staff id
        AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        AnStaff.StaffSalary = Convert.ToInt32(txtStaffSalary.Text);
        AnStaff.StaffName = Convert.ToString(txtStaffName.Text);
        AnStaff.StaffRole = Convert.ToString(txtStaffRole.Text);
        AnStaff.StaffAddress = Convert.ToString(txtStaffAddress.Text);
        AnStaff.StaffDOB = Convert.ToDateTime(DateTime.Now);
        AnStaff.StaffPriviliges = Convert.ToBoolean(chkStaffPriviliges.Checked);
        //store the staff in the session object
        Session["AnStaff"] = AnStaff;   
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }




}