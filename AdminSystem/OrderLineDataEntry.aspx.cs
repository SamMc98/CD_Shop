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
        txtTotalCost.Text = OrderLine.ThisOrderLine.TotalCost.ToString();
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
            /*
            // Session["OrderLine"] = OrderLine;
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            OrderLineList.ThisOrderLine = OrderLine;
            OrderLineList.Add();
            Response.Redirect("OrderLineViewer.aspx");*/
            OrderLine.OrderLineID = Int32.Parse(OrderLineID);
            OrderLine.OrderLineTotal = Int32.Parse(OrderLineTotal);
            OrderLine.CheckoutDate = Convert.ToDateTime(CheckoutDate);
            OrderLine.TotalCost = Double.Parse(TotalCost);
            OrderLine.OrderLineCheckout = ChkOrderLineCheckout.Checked;
            //Session["OrderLine"] = OrderLine;
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

        /**Create a new instance of clsOrderLine
        clsOrderLine OrderLine = new clsOrderLine();
        //Capture the orderLine checkout
        if (ChkOrderLineCheckout.Checked)
        {
            OrderLine.OrderLineCheckout = true;
        }
        else
        {
            OrderLine.OrderLineCheckout = false;
        }
        //Capture the orderLine ID
        OrderLine.OrderLineID = Int32.Parse(txtOrderLineID.Text);
        //Capture the checkout date
        OrderLine.CheckoutDate = DateTime.Parse(txtCheckoutDate.Text);
        //Capture the orderLine total
        OrderLine.OrderLineTotal = Int32.Parse(txtOrderLineTotal.Text);
        //Capture the total cost
        OrderLine.TotalCost = double.Parse(txtTotalCost.Text);
        //Store the shipping address in the session object
        Session["OrderLine"] = OrderLine;
        //Navigate to the viewer page
        Response.Redirect("OrderLineViewer.aspx");*/
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
}