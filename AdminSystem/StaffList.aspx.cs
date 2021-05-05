using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    // this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
      // if this is the first time the page is displayed
      if(IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }

    }
    void DisplayStaff()
    {
        // create an instace of the staff collection
        clsStaffCollection allStaff = new clsStaffCollection();
     

        // set the data source to the list of staff in the collection
        lstStaffList.DataSource = allStaff.StaffList;

        // set the name of the primary key
        lstStaffList.DataValueField = "StaffID";

        // set the data field to display
        lstStaffList.DataTextField = "StaffFullName";

        // bind the data to the list
        lstStaffList.DataBind();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        // redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the PK value of the record to be deleted
        Int32 StaffID;

        // if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            // get the PK value of the reocrd to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);

            // store the data in the session object
            Session["StaffID"] = StaffID;

            // redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store the PK value of the record to be edited
        Int32 StaffID;

        //if a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            // get the PK value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            // redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // create an instance of the staff collection
        clsStaffCollection allStaff = new clsStaffCollection();

        allStaff.ReportByName(filterBox.Text);

        lstStaffList.DataSource = allStaff.StaffList;

        // set the name of the PK
        lstStaffList.DataValueField = "StaffID";
        // set the name of the field to display
        lstStaffList.DataTextField = "StaffFullName";

        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // create an instance of the staff collection
        clsStaffCollection allStaff = new clsStaffCollection();
        allStaff.ReportByName("");
        //clear any existing filter to tidy up the interface
        filterBox.Text = "";

        lstStaffList.DataSource = allStaff.StaffList;

        // set the primary key name
        lstStaffList.DataValueField = "StaffID";

        // set the name of the field to display
        lstStaffList.DataTextField = "StaffFullName";

        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}