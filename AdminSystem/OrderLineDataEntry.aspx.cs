using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderLineID_;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineID_ = Convert.ToInt32(Session["OrderLineID"]);
        if (IsPostBack == false)
        {
            if (OrderLineID_ != -1)
            {
                DisplayOrderLine();
            }
        }
    }
    private void DisplayOrderLine()
    {
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        OrderLine.ThisOrderLine.Find(OrderLineID_);
        txtOrderLineID.Text = OrderLine.ThisOrderLine.OrderLineID.ToString();
        txtOrderLineTotal.Text = OrderLine.ThisOrderLine.OrderLineTotal.ToString();
        txtCheckoutDate.Text = OrderLine.ThisOrderLine.CheckoutDate.ToString();
        txtTotalCost.Text = OrderLine.ThisOrderLine.TotalCost.ToString("0.##");
        ChkOrderLineCheckout.Checked = OrderLine.ThisOrderLine.OrderLineCheckout;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrders
        clsOrderLine OrderLine = new clsOrderLine();
        string OrderLineID = txtOrderLineID.Text;
        string OrderLineTotal = txtOrderLineTotal.Text;
        string CheckoutDate = txtCheckoutDate.Text;
        string TotalCost = txtTotalCost.Text;
        string Error = "";
        Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
        if (Error == "")
        {
            OrderLine.OrderLineID = Int32.Parse(OrderLineID);
            OrderLine.OrderLineTotal = Int32.Parse(OrderLineTotal);
            OrderLine.CheckoutDate = Convert.ToDateTime(CheckoutDate);
            OrderLine.TotalCost = Double.Parse(TotalCost);
            OrderLine.OrderLineCheckout = ChkOrderLineCheckout.Checked;
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (OrderLineID_ == -1)
            {
                OrderLineList.ThisOrderLine = OrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineID_);
                OrderLineList.ThisOrderLine = OrderLine;
                OrderLineList.Update();
            }
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine OrderLine = new clsOrderLine();
        Int32 OrderLineID;
        Boolean Found = false;
        OrderLineID = Convert.ToInt32(txtOrderLineID.Text);
        Found = OrderLine.Find(OrderLineID);
        if (Found == true)
        {
            txtCheckoutDate.Text = OrderLine.CheckoutDate.ToString();
            txtOrderLineTotal.Text = OrderLine.OrderLineTotal.ToString();
            txtTotalCost.Text = OrderLine.TotalCost.ToString();
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Error. No such record exists!";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }
}