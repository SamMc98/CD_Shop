using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStock
    {
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
        public void StockAmountOK()


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
        public void PriceOK()


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


    }
}
