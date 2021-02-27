using System;
namespace ClassLibrary
{
    public class clsOrderLine
    {
        //properties
        private DateTime mCheckoutDate;
        private Int32 mOrderLineTotal;
        private double mTotalCost;
        private Int32 mOrderLineID;
        private Boolean mOrderLineCheckout;

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
 
        public int OrderLineID
        {
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

        public bool Find(int OrderLineID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", OrderLineID);
            DB.Execute("sproc_tblOrderLineProcessing_FilterID");
            if (DB.Count == 1)
            {
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
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
        }

        public string Valid(string checkoutDate, string orderLineTotal, string totalCost)
        {
            String Error = "";
            DateTime DateTemp;
            if (orderLineTotal.Length == 0)
            {
                Error = Error + "The order line total may not be blank : ";
            }
            if (orderLineTotal.Length > 50)
            {
                Error = Error + "The order line total must be less than 50 characters : ";
            }
            if (totalCost.Length == 0)
            {
                Error = Error + "The total cost may not be blank : ";
            }
            if (totalCost.Length > 6)
            {
                Error = Error + "The total cost must be less than 6 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(checkoutDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }
    }
}