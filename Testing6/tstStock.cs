using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStock
        
    {
            string AlbumTitle = "2014 Forest Hills Drive";
            string ReleaseDate = DateTime.Now.Date.ToString();
            string Price = "9.9900";
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
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
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
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(stockAmount));
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
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
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
            Error = Stock.Valid(AlbumTitle, releaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void ReleaseDateInvalidData()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string releaseDate = "this is not a date!";
            Error = Stock.Valid(AlbumTitle, releaseDate, Price, Convert.ToInt32(StockAmount));
            Assert.AreNotEqual(Error, "");
        }

        //bits contiuning after working with sam
        
        [TestMethod]
        public void AlbumTitleMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string albumTitle = "";
            Error = Stock.Valid(albumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AlbumTitle = "a"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AlbumTitle = "aa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AlbumTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AlbumTitle = "aaaaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AlbumTitle = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AlbumTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string AlbumTitle = "";
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AlbumTitleMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AlbumTitle = "aaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AlbumTitleExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string albumTitle = "";
            albumTitle = AlbumTitle.PadRight(500, 'a');
            Error = Stock.Valid(albumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string price = "";
            Error = Stock.Valid(AlbumTitle, ReleaseDate, price, Convert.ToInt32(StockAmount));
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "a"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aa"; //this should be ok
                                 //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceNameMax()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string price = "";
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        
        [TestMethod]
        public void PriceNameMid()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaa"; //this should be ok
            //invoke the method
            Error = Stock.Valid(AlbumTitle, ReleaseDate, Price, Convert.ToInt32(StockAmount));
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string price = "";
            Price = Price.PadRight(500, 'a');
            Error = Stock.Valid(AlbumTitle, ReleaseDate, price, Convert.ToInt32(StockAmount));
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
