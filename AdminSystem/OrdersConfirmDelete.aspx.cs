using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrdersCollection TheOrders = new clsOrdersCollection();
        TheOrders.ThisOrder.Find(OrderID);
        TheOrders.Delete();
        Response.Redirect("OrdersList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}