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
    }
}