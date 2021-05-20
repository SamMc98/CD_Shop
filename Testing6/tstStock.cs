using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStock

    {
            //Good test data
            string AlbumTitle = "2014 Forest Hills Drive";
            string ReleaseDate = DateTime.Now.Date.ToString();
            string Price = "5.9900";
            int StockAmount = 8;

            [TestMethod]
        public void InstanceOK()

        {
            //create an insatnce of the class we want to create
                clsStock AnStock = new clsStock();
            //test to see that it exists
                Assert.IsNotNull(AnStock);


        }

        [TestMethod]
        public void InStockPropertyOK()


        {

            //create an instance of the class of the we want to create
                clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
                Boolean TestData = true;
            //assign the data to the property
                AnStock.InStock = TestData;
            //test to see that the two values are the same
                Assert.AreEqual(AnStock.InStock, TestData);
            
        }

        [TestMethod]
        public void StockIDPropertyOK()


        {

            //create an instance of the class of the we want to create
                clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
                int TestData = 1;
            //assign the data to the property
                AnStock.StockID = TestData;
            //test to see that the two values are the same
                Assert.AreEqual(AnStock.StockID, TestData);

        }

        [TestMethod]
        public void AlbumTitlePropertyOK()


        {

            //create an instance of the class of the we want to create
                clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
                string TestData = "Album";
            //assign the data to the property
                AnStock.AlbumTitle = TestData;
            //test to see that the two values are the same
                Assert.AreEqual(AnStock.AlbumTitle, TestData);

        }

        [TestMethod]
        public void ReleaseDatePropertyOK()


        {

            //create an instance of the class of the we want to create
                clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
                DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.ReleaseDate = TestData;
            //test to see that the two values are the same
                Assert.AreEqual(AnStock.ReleaseDate, TestData);

        }

        [TestMethod]
        public void StockAmountPropertyOK()


        {

            //create an instance of the class of the we want to create
                clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
                int TestData = 1;
            //assign the data to the property
            AnStock.StockAmount = TestData;
            //test to see that the two values are the same
                Assert.AreEqual(AnStock.StockAmount, TestData);

        }

        [TestMethod]
        public void PricePropertyOK()


        {

            //create an instance of the class of the we want to create
                clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
                Double TestData = 1;
            //assign the data to the property
            AnStock.Price = TestData;
            //test to see that the two values are the same
                Assert.AreEqual(AnStock.Price, TestData);

        }

        
        //change to match my current ID's 
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Int32 StockID = 1;
            Found = Stock.Find(StockID);
            Assert.IsTrue(Found);
        }
        
        [TestMethod]
        public void TestStockIDFound()
        {
            clsStock Stock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockID = 1;
            Found = Stock.Find(StockID);
            if (Stock.StockID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Error = Stock.Valid(AlbumTitle, ReleaseDate, StockAmount, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            Int32 StockAmount;
            StockAmount = 0;
            StockAmount = StockAmount - 1;
            int stockAmount = StockAmount;
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, stockAmount, Price);
            Assert.AreNotEqual(Error, "");
        }
        
       
        [TestMethod]
        public void ReleaseDateMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date; //today
            string releaseDate = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(AlbumTitle, releaseDate, StockAmount, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        
        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string releaseDate = TestDate.ToString();
            //invoke the method
            Error = Stock.Valid(AlbumTitle, releaseDate, StockAmount, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void ReleaseDateInvalidData()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string releaseDate = "this is not a date!";
            Error = Stock.Valid(AlbumTitle, releaseDate, StockAmount, Price);
            Assert.AreNotEqual(Error, "");
        }
        /*
        [TestMethod]
        public void ShippingAddressMinLessOne()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            string ShippingAddress = "";
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
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
            Error = Order.Valid(ShippingAddress, deliveryDate, productName, productQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            string ProductName = "";
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "a"; //this should be ok
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aa"; //this should be ok
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaa"; //this should be ok
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ProductName = "";
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsOrders Order = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaa"; //this should be ok
            //invoke the method
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsOrders Order = new clsOrders();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a');
            Error = Order.Valid(shippingAddress, deliveryDate, ProductName, productQuantity);
            Assert.AreNotEqual(Error, "");
        }
        */
    }
}
