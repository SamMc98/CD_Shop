using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrderLine
{
    [TestClass]
    public class tstOrderLine
    {
        string checkoutDate = DateTime.Now.Date.ToString();
        string orderLineTotal = "10";
        string totalCost = "9.99";

        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we will create
            clsOrderLine OrderLine = new clsOrderLine();
            //Test to see whether it exists
            Assert.IsNotNull(OrderLine);
        }

        [TestMethod]
        public void OrderLineIDOK()
        {
            //Create an instance of the class we will create
            clsOrderLine OrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            int TestData = 1;
            //Assign the data to the property
            OrderLine.OrderLineID = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(OrderLine.OrderLineID, TestData);
        }

        [TestMethod]
        public void OrderLineCheckoutOK()
        {
            //Create an instance of the class we will create
            clsOrderLine OrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            OrderLine.OrderLineCheckout = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(OrderLine.OrderLineCheckout, TestData);
        }

        [TestMethod]
        public void CheckoutDateOK()
        {
            //Create an instance of the class we will create
            clsOrderLine OrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            OrderLine.CheckoutDate = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(OrderLine.CheckoutDate, TestData);
        }

        [TestMethod]
        public void OrderLineTotalOK()
        {
            //Create an instance of the class we will create
            clsOrderLine OrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            int TestData = 2;
            //Assign the data to the property
            OrderLine.OrderLineTotal = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(OrderLine.OrderLineTotal, TestData);
        }

        [TestMethod]
        public void TotalCostOK()
        {
            //Create an instance of the class we will create
            clsOrderLine OrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            Double TestData = 12.50;
            //Assign the data to the property
            OrderLine.TotalCost = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(OrderLine.TotalCost, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineID = 1;
            Found = OrderLine.Find(OrderLineID);
            Assert.IsTrue(Found);
        }

          [TestMethod]
          public void TestCheckoutDateFound()
          {
            clsOrderLine OrderLine = new clsOrderLine();
              Boolean Found = false;
              Boolean OK = true;
              Int32 OrderLineID = 1;
              Found = OrderLine.Find(OrderLineID);
              if (OrderLine.CheckoutDate != Convert.ToDateTime("18/01/2021"))
              {
                  OK = false;
              }
              Assert.IsTrue(OK);
          }

         [TestMethod]
         public void TestOrderLineIDFound()
         {
            clsOrderLine OrderLine = new clsOrderLine();
             Boolean Found = false;
             Boolean OK = true;
             Int32 OrderLineID = 1;
             Found = OrderLine.Find(OrderLineID);
             if (OrderLine.OrderLineID != 1)
             {
                 OK = false;
             }
             Assert.IsTrue(OK);
         }
         [TestMethod]
         public void testOrderLineCheckoutFound()
         {
            clsOrderLine OrderLine = new clsOrderLine();
             Boolean Found = false;
             Boolean OK = true;
             Int32 OrderLineID = 1;
             Found = OrderLine.Find(OrderLineID);
             if (OrderLine.OrderLineCheckout != true)
             {
                 OK = false;
             }
             Assert.IsTrue(OK);
         }

         [TestMethod]
         public void testOrderLineTotalFound()
         {
            clsOrderLine OrderLine = new clsOrderLine();
             Boolean Found = false;
             Boolean OK = true;
             Int32 OrderLineID = 1;
             Found = OrderLine.Find(OrderLineID);
             if (OrderLine.OrderLineTotal != 2)
             {
                 OK = false;
             }
             Assert.IsTrue(OK);
         }
         [TestMethod]
         public void testTotalCostFound()
         {
            clsOrderLine OrderLine = new clsOrderLine();
             Boolean Found = false;
             Boolean OK = true;
             Int32 OrderLineID = 1;
             Found = OrderLine.Find(OrderLineID);
             if (OrderLine.TotalCost != 9.9900)
             {
                 OK = false;
             }
             Assert.IsTrue(OK);
         }
        public void ValidMethodOK()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            Error = OrderLine.Valid(checkoutDate, orderLineTotal, totalCost);
            Assert.AreEqual(Error, "");
        }
    }
}
