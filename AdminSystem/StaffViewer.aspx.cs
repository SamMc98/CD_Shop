using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        // get the data from the session object
        aStaff = (clsStaff)Session["aStaff"];
        //display the staff details for this entry
        Response.Write(aStaff.StaffID);
        Response.Write(aStaff.StaffFullName);
        Response.Write(aStaff.StaffDateOfBirth);
        Response.Write(aStaff.StaffYearlySalary);
      
    }
}