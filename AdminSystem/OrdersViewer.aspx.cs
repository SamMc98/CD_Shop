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
        //Display the data entered for these entries
        Response.Write(Order.OrderID + "<br>");
        Response.Write(Order.ShippingAddress + "<br>");
        Response.Write(Order.DeliveryDate + "<br>");
        Response.Write(Order.OrderPlaced + "<br>");
        Response.Write(Order.ProductName + "<br>");
        Response.Write(Order.ProductQuantity + "<br>");
    }
}