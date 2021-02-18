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
        }        public DateTime CheckoutDate
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
    }
}