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
        //Create a new instance of clsOrderLine
        clsOrderLine OrderLine = new clsOrderLine();
        //Get the data from the session object
        OrderLine = (clsOrderLine)Session["OrderLine"];
        //Display the data entered for these entries
        Response.Write(OrderLine.OrderLineID + "<br>" + OrderLine.OrderLineCheckout + "<br>" + OrderLine.CheckoutDate + "<br>" + OrderLine.OrderLineTotal + "<br>" + OrderLine.TotalCost);
    }
}