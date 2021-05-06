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
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        
        clsOrdersCollection Orders = new clsOrdersCollection();
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "ShippingAddress";
        lstOrdersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrdersDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete.";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByShippingAddress(txtFilter.Text);
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataValueField = "ShippingAddress";
        lstOrdersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrdersCollection Orders = new clsOrdersCollection();
        Orders.ReportByShippingAddress("");
        txtFilter.Text = "";
        lstOrdersList.DataSource = Orders.OrdersList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataValueField = "ShippingAddress";
        lstOrdersList.DataBind();
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }
}