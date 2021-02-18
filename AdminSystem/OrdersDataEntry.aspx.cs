﻿using System;
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
    //Method for OK button
    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrders
        clsOrders Order = new clsOrders();
        //Capture the shipping address
        Order.ShippingAddress = txtShippingAddress.Text;
        //Capture the delivery date
        Order.DeliveryDate = DateTime.Parse(txtDeliveryDate.Text);
        //Capture the order placed
        //Order.OrderPlaced = Boolean.Parse(ChkOrderPlaced.Text);
        //display the active state
       // ChkOrderLineCheckout.Checked = Order.ThisclsOrder.Active;
        //Capture the checkout date
        Order.CheckoutDate = DateTime.Parse(txtCheckoutDate.Text);
        //Capture the orderLine total
        Order.OrderLineTotal = int.Parse(txtOrderLineTotal.Text);
        //Capture the total cost
        Order.TotalCost = double.Parse(txtTotalCost.Text);
        //Store the shipping address in the session object
        Session["Order"] = Order;
        //Navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }
}