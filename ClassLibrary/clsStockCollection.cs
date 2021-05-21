using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        
    public List<clsStock> mStockList = new List<clsStock>();
    public clsStock mThisStock = new clsStock();

    public clsStockCollection()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblStockManagement_SelectAll");
        PopulateArray(DB);
    }
    public List<clsStock> StockList
    {
        get
        {
            return mStockList;
        }
        set
        {
            mStockList = value;
        }
    }
    public int Count
    {
        get
        {
            return mStockList.Count;
        }
        set
        {
        }
    }
    public clsStock ThisStock
    {
        get
        {
            return mThisStock;
        }
        set
        {
            mThisStock = value;
        }

    }

        public int Add()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@AlbumTitle", mThisStock.AlbumTitle);
        DB.AddParameter("@ReleaseDate", mThisStock.ReleaseDate);
        DB.AddParameter("@InStock", mThisStock.InStock);
        DB.AddParameter("@StockQuantity", mThisStock.StockAmount);
        DB.AddParameter("@Price", mThisStock.Price);
        return DB.Execute("sproc_tblStockManagement_Insert");
    }

    public void Update()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@StockID", mThisStock.StockID);
        DB.AddParameter("@AlbumTitle", mThisStock.AlbumTitle);
        DB.AddParameter("@ReleaseDate", mThisStock.ReleaseDate);
        DB.AddParameter("@InStock", mThisStock.InStock);
        DB.AddParameter("@StockQuantity", mThisStock.StockAmount);
        DB.AddParameter("@Price", mThisStock.Price);
        DB.Execute("sproc_tblStockManagement_Update");
    }

    public void Delete()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@StockID", mThisStock.StockID);
        DB.Execute("sproc_tblStockManagement_Delete");
    }

    public void ReportByAlbumTitle(string AlbumTitle)
    {
        //filters the records based on full or partial
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@AlbumTitle", AlbumTitle);
        DB.Execute("sproc_tblStockManagement_FilterByAlbumTitle");
        PopulateArray(DB);
    }

    public void PopulateArray(clsDataConnection DB)
    {
        Int32 Index = 0;
        Int32 RecordCount;
        RecordCount = DB.Count;
        mStockList = new List<clsStock>();
        while (Index < RecordCount)
        {
            clsStock Stock = new clsStock();
            Stock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
            Stock.AlbumTitle = Convert.ToString(DB.DataTable.Rows[Index]["AlbumTitle"]);
            Stock.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
            Stock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
            Stock.StockAmount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
            Stock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
            mStockList.Add(Stock);
            Index++;
        }
    }
}
}