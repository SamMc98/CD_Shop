using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // var to store the PK with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staffID to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            // if this is not a new record
            if(StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        // create an instance of the address  book
        clsStaffCollection allStaff = new clsStaffCollection();

        //find the record to update
        allStaff.ThisStaff.Find(StaffID);

        //display the data for this record
        txtStaffID.Text = allStaff.ThisStaff.StaffID.ToString();
        txtFullName.Text = allStaff.ThisStaff.StaffFullName;
        txtDOB.Text = allStaff.ThisStaff.StaffDateOfBirth.ToString();
        txtSalary.Text = allStaff.ThisStaff.StaffYearlySalary.ToString();
        chkManager.Checked = allStaff.ThisStaff.Manager;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStaff
        clsStaff aStaff = new clsStaff();


        string StaffFullName = txtFullName.Text;
        //string StaffID = txtStaffID.Text;
        string StaffYearlySalary = txtSalary.Text;
        string StaffDateOfBirth = txtDOB.Text;

        string Error = "";

        Error = aStaff.Valid(StaffFullName, StaffYearlySalary, StaffDateOfBirth);

        if (Error == "")
        {
            //capture the Staff details
            aStaff.StaffFullName = StaffFullName;

            aStaff.StaffID = int.Parse(txtStaffID.Text);

            aStaff.StaffYearlySalary = double.Parse(txtSalary.Text);

            aStaff.StaffDateOfBirth = DateTime.Parse(txtDOB.Text);

            aStaff.Manager = chkManager.Checked;

            // create a new instance of the address collection
            clsStaffCollection allStaff = new clsStaffCollection();
            if (StaffID == -1)
            {
                // set the ThisStaff property
                allStaff.ThisStaff = aStaff;

                // add the new record
                allStaff.Add();
            }
            else
            {
                // find the record to update
                allStaff.ThisStaff.Find(StaffID);

                // set the ThisStaff property
                allStaff.ThisStaff = aStaff;

                // update the record
                allStaff.Update();
            }
                // redirect back to thelistpage
                Response.Redirect("StaffList.aspx");
            
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }







    protected void btnFind_Click(object sender, EventArgs e)
    {   
        // create an instance of the staff class
        clsStaff aStaff = new clsStaff();

        // variable to store the primary key
        Int32 StaffID;

        // variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);

        // find the record
        Found = aStaff.Find(StaffID);

        //if found
        if(Found == true)
        {
            // display the values of the properties in the form
            txtDOB.Text = aStaff.StaffDateOfBirth.ToString();
            txtStaffID.Text = aStaff.StaffID.ToString();
            txtSalary.Text = aStaff.StaffYearlySalary.ToString();
            txtFullName.Text = aStaff.StaffFullName.ToString();

        }
    }
}