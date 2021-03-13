using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        public List<clsOrders> mOrdersList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();

        public clsOrdersCollection(){
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderProcessing_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrders Order = new clsOrders();
                Order.OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                Order.ShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                Order.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                Order.OrderPlaced = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderPlaced"]);
                mOrdersList.Add(Order);
                Index++;
            }

            /**clsOrders TestItem = new clsOrders();
            TestItem.OrderID = 1;
            TestItem.ShippingAddress = "5 Random Street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderPlaced = true;
            mOrdersList.Add(TestItem);
            TestItem = new clsOrders();
            TestItem.OrderID = 2;
            TestItem.ShippingAddress = "5 Main Street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderPlaced = true;
            mOrdersList.Add(TestItem);*/
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
            //mThisOrder.OrderID = 1;
            //return mThisOrder.OrderID;
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
    }
}