using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockID_;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID_ = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            if (StockID_ != -1)
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        clsStockCollection TheStock = new clsStockCollection();
        TheStock.ThisStock.Find(StockID_);
        txtStockID.Text = TheStock.ThisStock.StockID.ToString();
        txtAlbumTitle.Text = TheStock.ThisStock.AlbumTitle;
        txtReleaseDate.Text = TheStock.ThisStock.ReleaseDate.ToString();
        txtStockQuantity.Text = TheStock.ThisStock.StockAmount.ToString();
        txtPrice.Text = TheStock.ThisStock.Price.ToString();
        chkInStock.Checked = TheStock.ThisStock.InStock;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    { 
        clsStock Stock = new clsStock();
        string StockID = txtStockID.Text;
        string InStock = chkInStock.Text;
        string AlbumTitle = txtAlbumTitle.Text;
        string ReleaseDate = txtReleaseDate.Text;
        string StockAmount = txtStockQuantity.Text;
        string Price = txtPrice.Text; 
        string Error = "";
        Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
        if (Error == "")
        {
            Stock.StockID = Int32.Parse(StockID);
            Stock.AlbumTitle = Convert.ToString(AlbumTitle);
            Stock.InStock = chkInStock.Checked;
            Stock.ReleaseDate = Convert.ToDateTime(ReleaseDate);
            Stock.StockAmount = Int32.Parse(StockAmount);
            clsStockCollection StockList = new clsStockCollection();
            if (StockID_ == -1)
            {
                StockList.ThisStock = Stock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(StockID_);
                StockList.ThisStock = Stock;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
    //find
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStock Stock = new clsStock();
        Int32 StockID;
        Boolean Found = false;
        StockID = Convert.ToInt32(txtStockID.Text);
        Found = Stock.Find(StockID);
        if (Found == true)
        {
            txtStockQuantity.Text = Stock.StockAmount.ToString();
            txtReleaseDate.Text = Stock.ReleaseDate.ToString();
            txtPrice.Text = Stock.Price.ToString();
            txtAlbumTitle.Text = Stock.AlbumTitle;
            lblError.Text = "";
        }
        else
        {
            lblError.Text = "Error. No such record exists!";
        }
    }
}