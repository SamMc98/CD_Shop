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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrders
        clsOrders Order = new clsOrders();
        //Capture the order ID
        Order.OrderID = Int32.Parse(txtOrderID.Text);
        //Capture the shipping address
        Order.ShippingAddress = txtShippingAddress.Text;
        //Capture the delivery date
        Order.DeliveryDate = DateTime.Parse(txtDeliveryDate.Text);
        //Capture the order placed
        if (ChkOrderPlaced.Checked)
        {
            Order.OrderPlaced = true;
        }
        else
        {
            Order.OrderPlaced = false;
        }
        //Store the shipping address in the session object
        Session["Order"] = Order;
        //Navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders Order = new clsOrders();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = Order.Find(OrderID);
        if (Found == true)
        {
            txtShippingAddress.Text = Order.ShippingAddress;
            txtDeliveryDate.Text = Order.DeliveryDate.ToString();
        }
    }
}