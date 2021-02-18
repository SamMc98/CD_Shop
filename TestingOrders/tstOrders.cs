using System;
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

        [TestMethod]
        public void TestCheckoutDateFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.CheckoutDate != Convert.ToDateTime("18/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 2;
            Found = Order.Find(OrderID);
            if (Order.OrderLineID != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testOrderLineCheckoutFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.OrderLineCheckout != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void testOrderLineTotalFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.OrderLineTotal != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testTotalCostFound()
        {
            clsOrders Order = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = Order.Find(OrderID);
            if (Order.TotalCost != 9.99)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
