using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrderLine
{
    [TestClass]
    public class tstOrderLine
    {
        //Good test data
        string CheckoutDate = DateTime.Now.Date.ToString();
        string OrderLineTotal = "10";
        string TotalCost = "9.99";

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
              if (OrderLine.CheckoutDate != Convert.ToDateTime("17/03/2021"))
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
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineTotalMinLessOne()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineTotal = "";
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineTotalMin()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderLineTotal = "a"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineTotalMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderLineTotal = "aa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineTotalMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderLineTotal = "aaaaa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineTotalMax()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderLineTotal = "aaaaaa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderLineTotalMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string OrderLineTotal = "";
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderLineTotalMid()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderLineTotal = "aaa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderLineTotalExtremeMax()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            string OrderLineTotal = "";
            OrderLineTotal = OrderLineTotal.PadRight(500, 'a');
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CheckoutDateMinLessOne()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string CheckoutDate = TestDate.ToString();
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CheckoutDateMin()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date; //today
            string CheckoutDate = TestDate.ToString();
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CheckoutDateMinPlusOne()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string CheckoutDate = TestDate.ToString();
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CheckoutDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string CheckoutDate = TestDate.ToString();
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CheckoutDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string CheckoutDate = TestDate.ToString();
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void CheckoutDateInvalidData()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            string CheckoutDate = "this is not a date!";
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void TotalCostMinLessOne()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            string TotalCost = "";
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMin()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "a"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostlMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "aa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "aaaaa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostMax()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "aaaaaa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string TotalCost = "";
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TotalCostMid()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLine = new clsOrderLine();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalCost = "aaa"; //this should be ok
            //invoke the method
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalCostExtremeMax()
        {
            clsOrderLine OrderLine = new clsOrderLine();
            String Error = "";
            string TotalCost = "";
            OrderLineTotal = OrderLineTotal.PadRight(500, 'a');
            Error = OrderLine.Valid(CheckoutDate, OrderLineTotal, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

    }
}
