using System;

namespace ClassLibrary
{
    public class clsOrders

    {
        private Int32 mOrderID;
        private DateTime mDeliveryDate;
        private String mShippingAddress;
        private Boolean mOrderPlaced;
        private DateTime mCheckoutDate;
        private Int32 mOrderLineTotal;
        private double mTotalCost;
        private Int32 mOrderLineID;
        private Boolean mOrderLineCheckout;

        public bool OrderPlaced {
            get
            {
                return mOrderPlaced;
            }
            set
            {
                mOrderPlaced = value;
            }
        }
        public DateTime CheckoutDate
        {
            get
            {
                return mCheckoutDate;
            }
            set
            {
                mCheckoutDate = value;
            }
        }
        public DateTime DeliveryDate
        {
            get
            {
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }
        public string ShippingAddress {
            get
            {
                return mShippingAddress;
            }
            set
            {
                mShippingAddress = value;
            }

        }    
        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }
        public int OrderLineID {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }
        public bool OrderLineCheckout
        {
            get
            {
                return mOrderLineCheckout;
            }
            set
            {
                mOrderLineCheckout = value;
            }
        }
        public int OrderLineTotal
        {
            get
            {
                return mOrderLineTotal;
            }
            set
            {
                mOrderLineTotal = value;
            }
        }
        public double TotalCost
        {
            get
            {
                return mTotalCost;
            }
            set
            {
                mTotalCost = value;
            }
        }

        public bool Find(int OrderID)
        {
            mOrderID = 1;
            mDeliveryDate = Convert.ToDateTime("16/09/2015");
            mShippingAddress = "5 Test Street";
            mOrderPlaced = true;
            mCheckoutDate = Convert.ToDateTime("18/02/2021");
            mOrderLineTotal = 10;
            mTotalCost = 9.99;
            mOrderLineCheckout = true;
            mOrderLineID = 2;
            return true;
        }
        /*public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrderProcessing_FilterID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mOrderPlaced = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderPlaced"]);

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Find2(int OrderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", OrderLineID);
            DB.Execute("sproc_tblOrderLineProcessing_FilterID");
            if (DB.Count == 1)
            { 
                mOrderLineCheckout = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderLineCheckout"]);
                mCheckoutDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CheckoutDate"]);
                mOrderLineTotal = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineTotal"]);
                mTotalCost = Convert.ToDouble(DB.DataTable.Rows[0]["TotalCost"]);

                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}