using System;
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
    }
}
