﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingOrders
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void InstanceOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrdersListOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderID = 1;
            TestItem.ShippingAddress = "5 Random Street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderPlaced = true;
            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList;
            Assert.AreEqual(AllOrders.OrdersList, TestList);
        }
      /*  [TestMethod]
        public void CountPropertyOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            Int32 SomeCount = 2;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }*/

        [TestMethod]
        public void ThisOrdersPropertyOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestOrders = new clsOrders();
            TestOrders.OrderID = 1;
            TestOrders.ShippingAddress = "5 Random Street";
            TestOrders.DeliveryDate = DateTime.Now.Date;
            TestOrders.OrderPlaced = true;
            AllOrders.ThisOrder = TestOrders;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.OrderID = 1;
            TestItem.ShippingAddress = "5 Random Street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestItem.OrderPlaced = true;
            TestList.Add(TestItem);
            AllOrders.OrdersList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        /* [TestMethod]
         public void TwoRecordsPresent()
         {
             clsOrdersCollection AllOrders = new clsOrdersCollection();
             Assert.AreEqual(AllOrders.Count, 2);
         }*/
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderPlaced = true;
            TestItem.OrderID = 2;
            TestItem.ShippingAddress = "3 New Street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.OrderPlaced = true;
            TestItem.ShippingAddress = "3 New Street";
            TestItem.DeliveryDate = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            TestItem.OrderPlaced = false;
            TestItem.ShippingAddress = "6 Saint James Lane";
            TestItem.DeliveryDate = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
