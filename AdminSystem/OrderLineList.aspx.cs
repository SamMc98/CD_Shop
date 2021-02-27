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
        clsOrderLineCollection Orders = new clsOrderLineCollection();
        lstOrderLineList.DataSource = Orders.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineID";
        lstOrderLineList.DataTextField = "TotalCost";
        lstOrderLineList.DataBind();
    }
}