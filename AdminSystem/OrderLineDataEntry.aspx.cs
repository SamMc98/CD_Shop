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
        //Create a new instance of clsOrderLine
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
        Response.Redirect("OrderLineViewer.aspx");
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
        }
    }
}