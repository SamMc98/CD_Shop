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
        //display the house number for this entry
        Response.Write(aStaff.StaffFullName);
    }
}