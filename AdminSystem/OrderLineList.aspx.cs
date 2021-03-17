using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderLines();
        }
    }
    public void DisplayOrderLines()
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataTextField = "TotalCost";
        lstOrderLineList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderLineID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderLineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("OrderLineDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineID;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineID = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineID"] = OrderLineID;
            Response.Redirect("OrderLineConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list.";
        }
    }
}