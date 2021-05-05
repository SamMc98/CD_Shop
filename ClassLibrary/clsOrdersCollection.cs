using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        public List<clsOrders> mOrdersList = new List<clsOrders>();
        public clsOrders mThisOrder = new clsOrders();

        public clsOrdersCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            PopulateArray(DB);
        }
        public List<clsOrders> OrdersList {
            get
            {
                return mOrdersList;
            }
            set
            {
                mOrdersList = value;
            }
        }
        public int Count {
            get
            {
                return mOrdersList.Count;
            }
            set
            {
            }
        }
        public clsOrders ThisOrder {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderPlaced", mThisOrder.OrderPlaced);
            return DB.Execute("sproc_tblOrderProcessing_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderPlaced", mThisOrder.OrderPlaced);
            DB.Execute("sproc_tblOrderProcessing_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrderProcessing_Delete");
        }

        public void ReportByShippingAddress(string ShippingAddress)
        {
            //filters the records based on full or partial
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShippingAddress", ShippingAddress);
            DB.Execute("sproc_tblOrderProcessing_FilterByShippingAddress");
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrdersList = new List<clsOrders>();
            while (Index < RecordCount)
            {
                clsOrders Order = new clsOrders();
                Order.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                Order.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                Order.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);
                Order.OrderPlaced = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderPlaced"]);
                mOrdersList.Add(Order);
                Index++;
            }
        }
    }
}