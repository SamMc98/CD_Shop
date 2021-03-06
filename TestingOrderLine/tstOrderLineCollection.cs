﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingOrderLine
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);
        }
        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineID = 1;
            TestItem.OrderLineCheckout = true;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 9.9900;
            TestItem.OrderLineTotal = 2;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }
       /* [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Int32 SomeCount = 2;
            AllOrderLines.Count = SomeCount;
            Assert.AreEqual(AllOrderLines.Count, SomeCount);
        }*/
        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.OrderLineID = 1;
            TestOrderLine.OrderLineCheckout = true;
            TestOrderLine.CheckoutDate = DateTime.Now.Date;
            TestOrderLine.TotalCost = 9.9900;
            TestOrderLine.OrderLineTotal = 2;
            AllOrderLines.ThisOrderLine = TestOrderLine;
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineID = 1;
            TestItem.OrderLineCheckout = true;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 9.9900;
            TestItem.OrderLineTotal = 2;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }
        /* [TestMethod]
         public void TwoRecordsPresent()
         {
             clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
             Assert.AreEqual(AllOrderLines.Count, 2);
         }*/
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineCheckout = true;
            TestItem.OrderLineID = 2;
            TestItem.OrderLineTotal = 2;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 2.9999;
            AllOrders.ThisOrderLine = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderLineID = PrimaryKey;
            AllOrders.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrderLine, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderLineCheckout = true;
            TestItem.OrderLineID = 2;
            TestItem.OrderLineTotal = 2;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 2.9999;
            AllOrders.ThisOrderLine = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderLineID = PrimaryKey;
            TestItem.OrderLineCheckout = false;
            TestItem.OrderLineID = 5;
            TestItem.OrderLineTotal = 12;
            TestItem.CheckoutDate = DateTime.Now.Date;
            TestItem.TotalCost = 9.9999;
            AllOrders.ThisOrderLine = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrderLine, TestItem);
        }
    }
}
