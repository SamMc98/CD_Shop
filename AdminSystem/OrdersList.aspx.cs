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
}