﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingOrders
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Test to see whether it exists
            Assert.IsNotNull(Order);
        }

        [TestMethod]
        public void OrderPlacedOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            Order.OrderPlaced = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.OrderPlaced, TestData);
        }

        [TestMethod]
        public void DeliveryDateOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            Order.DeliveryDate = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.DeliveryDate, TestData);
        }

        [TestMethod]
        public void ShippingAddressOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            String TestData = "Leicester";
            //Assign the data to the property
            Order.ShippingAddress = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.ShippingAddress, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            int TestData = 1;
            //Assign the data to the property
            Order.OrderID = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.OrderID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.DeliveryDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testShippingAddressFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.ShippingAddress != "5 Test Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testOrderPlacedFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.OrderPlaced != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
