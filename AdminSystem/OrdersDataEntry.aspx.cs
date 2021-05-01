﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID_;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID_ = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID_ != -1)
            {
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        clsOrdersCollection TheOrder = new clsOrdersCollection();
        TheOrder.ThisOrder.Find(OrderID_);
        txtOrderID.Text = TheOrder.ThisOrder.OrderID.ToString();
        txtShippingAddress.Text = TheOrder.ThisOrder.ShippingAddress;
        txtDeliveryDate.Text = TheOrder.ThisOrder.DeliveryDate.ToString();
        ChkOrderPlaced.Checked = TheOrder.ThisOrder.OrderPlaced;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrders
        clsOrders Order = new clsOrders();
        string OrderID = txtOrderID.Text;
        string ShippingAddress = txtShippingAddress.Text;
        string DeliveryDate = txtDeliveryDate.Text;
        string Error = "";
        Error = Order.Valid(ShippingAddress, DeliveryDate);
        if (Error == "") {
            Order.OrderID = Int32.Parse(OrderID);
            Order.ShippingAddress = ShippingAddress;
            Order.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            Order.OrderPlaced = ChkOrderPlaced.Checked;
            clsOrdersCollection OrderList = new clsOrdersCollection();
            if (OrderID_ == -1)
            {
                OrderList.ThisOrder = Order;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID_);
                OrderList.ThisOrder = Order;
                OrderList.Update();
            }
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Error. No such record exists!";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}