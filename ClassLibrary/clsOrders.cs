﻿using System;

namespace ClassLibrary
{
    public class clsOrders

    {
        private Int32 mOrderID;
        private DateTime mDeliveryDate;
        private String mShippingAddress;
        private Boolean mOrderPlaced;
        private String mProductName;
        private Int32 mProductQuantity;

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

        public String ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }

        public Int32 ProductQuantity
        {
            get
            {
                return mProductQuantity;
            }
            set
            {
                mProductQuantity = value;
            }
        }
        
        public bool Find(int OrderID)
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
            catch {
                Error = Error + "The delivery date was not a valid date : ";
            }
            return Error;
        }
    }
}