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

        /* public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblStockManagement_FilterID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mOrderPlaced = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderPlaced"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string shippingAddress, string deliveryDate, string productName, int productQuantity)
        {
            String Error = "";
            DateTime DateTemp;
            if (shippingAddress.Length == 0)
            {
                Error = Error + "The shipping address may not be blank : ";
            }
            if (shippingAddress.Length > 50)
            {
                Error = Error + "The shipping address must be less than 50 characters : ";
            }
            if (productName.Length == 0)
            {
                Error = Error + "The product name may not be blank : ";
            }
            if (productName.Length > 50)
            {
                Error = Error + "The product name must be less than 50 characters : ";
            }
            if (productQuantity < 0)
            {
                Error = Error + "The product quantity must be 0 or more : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(deliveryDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The delivery date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Today.AddYears(1))
                {
                    Error = Error + "The delivery date cannot be in the future by one year : ";
                }
            }
            catch
            {
                Error = Error + "The delivery date was not a valid date : ";
            }
            return Error;
        }
    }
}
*/
    }
}