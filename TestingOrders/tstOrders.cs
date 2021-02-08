using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Order.CheckoutDate = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.CheckoutDate, TestData);
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
        public void BuyerNameOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            String TestData = "Sam McPhee";
            //Assign the data to the property
            Order.BuyerName = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.BuyerName, TestData);
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
        public void OrderLineIDOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            int TestData = 1;
            //Assign the data to the property
            Order.OrderLineID = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.OrderLineID, TestData);
        }

        [TestMethod]
        public void OrderLineCheckoutOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            Order.OrderLineCheckout = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.OrderLineCheckout, TestData);
        }

        [TestMethod]
        public void CheckoutDateOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            Order.CheckoutDate = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.CheckoutDate, TestData);
        }

        [TestMethod]
        public void OrderLineTotalOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            int TestData = 2;
            //Assign the data to the property
            Order.OrderLineTotal = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.OrderLineTotal, TestData);
        }

        [TestMethod]
        public void TotalCostOK()
        {
            //Create an instance of the class we will create
            clsOrders Order = new clsOrders();
            //Create some test data to assign to the property
            Double TestData = 12.50;
            //Assign the data to the property
            Order.TotalCost = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(Order.TotalCost, TestData);
        }
    }
}