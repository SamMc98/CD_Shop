using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingOrders
{
    [TestClass]
    public class tstOrders
    {
        //Good test data
        string shippingAddress = "5 Random Street";
        string deliveryDate = DateTime.Now.Date.ToString();

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
            if (Order.DeliveryDate != Convert.ToDateTime("24/01/2021"))
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
        public void ValidMethodOK()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            Error = Order.Valid(shippingAddress, deliveryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            string ShippingAddress = "";
            Error = Order.Valid(ShippingAddress, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMin()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "a"; //this should be ok
            //invoke the method
            Error = Order.Valid(ShippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aa"; //this should be ok
            //invoke the method
            Error = Order.Valid(ShippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aaaaa"; //this should be ok
            //invoke the method
            Error = Order.Valid(ShippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressMax()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Order.Valid(ShippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShippingAddress = "";
            //invoke the method
            Error = Order.Valid(ShippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ShippingAddressMid()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ShippingAddress = "aaa"; //this should be ok
            //invoke the method
            Error = Order.Valid(ShippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingAddressExtremeMax()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            string ShippingAddress = "";
            ShippingAddress = ShippingAddress.PadRight(500, 'a');
            Error = Order.Valid(ShippingAddress, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateMin()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date; //today
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
      /*  [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }*/

        [TestMethod]
        public void DeliveryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DeliveryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string deliveryDate = TestDate.ToString();
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void DeliveryDateInvalidData()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            string deliveryDate = "this is not a date!";
            Error = Order.Valid(shippingAddress, deliveryDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
