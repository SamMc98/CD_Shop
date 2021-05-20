using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {




        }

        private Boolean mInStock;
        public Boolean InStock
        {
            get { return mInStock; }
            set { mInStock = value; }
        }

        private int mStockID;
        public int StockID
        {
            get { return mStockID; }
            set { mStockID = value; }

        }

        private string mAlbumTitle;
        public string AlbumTitle
        {
            get { return mAlbumTitle; }
            set { mAlbumTitle = value; }
        }

        private DateTime mReleaseDate; 
        public DateTime ReleaseDate
        {
            get { return mReleaseDate; }
            set { mReleaseDate = value; }
        }

        private int mStockAmount;
        public int StockAmount
        {
            get { return mStockAmount; }
            set { mStockAmount = value; }
        }

        private Double mPrice;
        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

         public bool Find(int StockID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockID", StockID);
            DB.Execute("sproc_tblStockManagement_FilterID");
            if (DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mAlbumTitle = Convert.ToString(DB.DataTable.Rows[0]["AlbumTitle"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mStockAmount = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string AlbumTitle, string ReleaseDate, int StockAmount, string Price)
        {
            String Error = "";
            DateTime DateTemp;
            if (AlbumTitle.Length == 0)
            {
                Error = Error + "The album title may not be blank : ";
            }
            if (AlbumTitle.Length > 50)
            {
                Error = Error + "The album title must be less than 50 characters : ";
            }
            if (Price.Length == 0)
            {
                Error = Error + "The price may not be blank : ";
            }
            if (Price.Length > 50)
            {
                Error = Error + "The price must be less than 50 characters : ";
            }
            if (StockAmount < 0)
            {
                Error = Error + "The stock quantity must be 0 or more : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(ReleaseDate);
                
                if (DateTemp > DateTime.Today.AddDays(1))
                {
                    Error = Error + "The release date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The release date was not a valid date : ";
            }
            return Error;
        }
    }
}
   