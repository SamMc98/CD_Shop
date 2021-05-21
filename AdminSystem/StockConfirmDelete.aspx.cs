using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStockCollection TheStocks = new clsStockCollection();
        TheStocks.ThisStock.Find(StockID);
        TheStocks.Delete();
        Response.Redirect("StocksList.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StocksList.aspx");
    }
}