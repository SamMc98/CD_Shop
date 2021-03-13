using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();

        public clsOrderLineCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLineProcessing_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrderLine OrderLine = new clsOrderLine();
                OrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                OrderLine.OrderLineCheckout = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderLineCheckout"]);
                OrderLine.CheckoutDate = Convert.ToDateTime(DB.DataTable.Rows[0]["CheckoutDate"]);
                OrderLine.OrderLineTotal = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineTotal"]);
                OrderLine.TotalCost = Convert.ToDouble(DB.DataTable.Rows[0]["TotalCost"]);
                mOrderLineList.Add(OrderLine);
                Index++;
            }
            /**clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineID = 1;
            TestItem.OrderLineCheckout = true;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 9.9900;
            TestItem.OrderLineTotal = 2;
            mOrderLineList.Add(TestItem);
            TestItem = new clsOrderLine();
            TestItem.OrderLineID = 2;
            TestItem.OrderLineCheckout = true;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 21.0000;
            TestItem.OrderLineTotal = 3;
            mOrderLineList.Add(TestItem);*/
        }

        public List<clsOrderLine> OrderLineList {
            get
            {
               // List<clsOrderLine> mOrderLineList = null;
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }
        public int Count {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {
            }
        }
        public clsOrderLine ThisOrderLine { get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }

        public int Add()
        {
            //  mThisOrderLine.OrderLineID = 1;
            //  return mThisOrderLine.OrderLineID;
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineCheckout", mThisOrderLine.OrderLineCheckout);
            DB.AddParameter("@CheckoutDate", mThisOrderLine.CheckoutDate);
            DB.AddParameter("@OrderLineTotal", mThisOrderLine.OrderLineTotal);
            DB.AddParameter("@TotalCost", mThisOrderLine.TotalCost);
            return DB.Execute("sproc_tblOrderLineProcessing_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.AddParameter("@OrderLineCheckout", mThisOrderLine.OrderLineCheckout);
            DB.AddParameter("@CheckoutDate", mThisOrderLine.CheckoutDate);
            DB.AddParameter("@OrderLineTotal", mThisOrderLine.OrderLineTotal);
            DB.AddParameter("@TotalCost", mThisOrderLine.TotalCost);
            DB.Execute("sproc_tblOrderLineProcessing_Update");
        }
    }
}