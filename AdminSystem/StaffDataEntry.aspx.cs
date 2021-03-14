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
        //create an instance of clsStaff
        clsStaff aStaff = new clsStaff();


        string StaffFullName = txtFullName.Text;
        string StaffID = txtStaffID.Text;
        string StaffYearlySalary = txtSalary.Text;
        string StaffDateOfBirth = txtDOB.Text;

        string Error = "";

        Error = aStaff.Valid(StaffFullName, StaffYearlySalary, StaffDateOfBirth);

        if (Error == "")
        {
            //capture the Staff details
            aStaff.StaffFullName = txtFullName.Text;

            aStaff.StaffID = int.Parse(txtStaffID.Text);

            aStaff.StaffYearlySalary = double.Parse(txtSalary.Text);

            aStaff.StaffDateOfBirth = DateTime.Parse(txtDOB.Text);



            // Store the name in the session object
            Session["aStaff"] = aStaff;
            // navigate to the viewer page
            Response.Redirect("StaffViewer.aspx");
            
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