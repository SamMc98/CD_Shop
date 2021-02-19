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
        //Create a new instance of clsOrders
        clsOrders Order = new clsOrders();
        //Get the data from the session object
        Order = (clsOrders)Session["Order"];
        //Display the house number for this entry
        Response.Write(Order.ShippingAddress);
        Response.Write(Order.DeliveryDate);
      //  Response.Write(Order.OrderLineCheckout + " " + Order.CheckoutDate + " " + Order.OrderLineTotal + " " + Order.TotalCost);
    }
}