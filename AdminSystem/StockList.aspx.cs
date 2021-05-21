using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }
    void DisplayStock()
    {

        clsStockCollection Stock = new clsStockCollection();
        lstList.DataSource = Stock.StockList;
        lstList.DataValueField = "StockID";
        lstList.DataTextField = "AlbumTitle";
        lstList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        Session["StockID"] = -1;
        
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;
        if (lstList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByAlbumTitle(txtFilter.Text);
        lstList.DataSource = Stock.StockList;
        lstList.DataValueField = "StockID";
        lstList.DataValueField = "AlbumTitle";
        lstList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByAlbumTitle("");
        txtFilter.Text = "";
        lstList.DataSource = Stock.StockList;
        lstList.DataValueField = "StockID";
        lstList.DataValueField = "AlbumTitle";
        lstList.DataBind();
    }
}