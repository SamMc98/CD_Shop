using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // var to store the PK value of the record to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number value of the StaffID to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create an instance of the Staff List
        clsStaffCollection allStaff = new clsStaffCollection();

        // find the record to delete
        allStaff.ThisStaff.Find(StaffID);

        // delete the reocrd
        allStaff.Delete();

        // redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnYes_Click1(object sender, EventArgs e)
    {
        // create an instance of the Staff List
        clsStaffCollection allStaff = new clsStaffCollection();

        // find the record to delete
        allStaff.ThisStaff.Find(StaffID);

        // delete the reocrd
        allStaff.Delete();

        // redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }
}