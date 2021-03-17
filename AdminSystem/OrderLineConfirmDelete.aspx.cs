using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderLineID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection TheOrderLine = new clsOrderLineCollection();
        TheOrderLine.ThisOrderLine.Find(OrderLineID);
        TheOrderLine.Delete();
        Response.Redirect("OrderLineList.aspx");
    }
}