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
           clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLineProcessing_SelectAll");
            PopulateArray(DB);
        }

        public List<clsOrderLine> OrderLineList {
            get
            {
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

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineID", mThisOrderLine.OrderLineID);
            DB.Execute("sproc_tblOrderLineProcessing_Delete");
        }

         public void ReportByTotalCost(string TotalCost)
        {
            //filters the records based on full or partial total cost
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TotalCost", TotalCost);
            DB.Execute("sproc_tblOrderLineProcessing_FilterByTotalCost");
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderLineList = new List<clsOrderLine>();
            while (Index < RecordCount)
            {
                clsOrderLine OrderLine = new clsOrderLine();
                OrderLine.OrderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                OrderLine.OrderLineCheckout = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderLineCheckout"]);
                OrderLine.CheckoutDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["CheckoutDate"]);
                OrderLine.OrderLineTotal = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineTotal"]);
                OrderLine.TotalCost = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalCost"]);
                mOrderLineList.Add(OrderLine);
                Index++;
            }
        }
    }
}