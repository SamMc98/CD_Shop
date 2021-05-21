using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestStock = new clsStock();
            TestStock.StockID = 1;
            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("16/02/2021");
            TestStock.StockAmount = 5;
            TestStock.Price = Convert.ToDouble("9.9900");
            TestStock.InStock = true;
            TestList.Add(TestStock); 
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.StockID = 1;
            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("16/02/2021");
            TestStock.StockAmount = 5;
            TestStock.Price = Convert.ToDouble("9.9900");
            TestStock.InStock = true;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestStock = new clsStock();
            TestStock.StockID = 1;
            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("16/02/2021");
            TestStock.StockAmount = 5;
            TestStock.Price = Convert.ToDouble("9.9900");
            TestStock.InStock = true;
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            Int32 PrimaryKey = 0;
            TestStock.InStock = true;
            TestStock.StockID = 1;
            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("16/02/2021");
            TestStock.StockAmount = 5;
            TestStock.Price = Convert.ToDouble("9.9900");
            TestStock.InStock = true;
            AllStock.ThisStock = TestStock;
            PrimaryKey = AllStock.Add();
            TestStock.StockID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            Int32 PrimaryKey = 0;

            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("16/02/2021");
            TestStock.StockAmount = 5;
            TestStock.Price = Convert.ToDouble("9.9900");
            TestStock.InStock = true;


            AllStock.ThisStock = TestStock;
            PrimaryKey = AllStock.Add();
            TestStock.StockID = PrimaryKey;

            
            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("15/02/2021");
            TestStock.StockAmount = 8;
            TestStock.Price = Convert.ToDouble("8.9900");
            TestStock.InStock = true;


            AllStock.ThisStock = TestStock;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            Int32 PrimaryKey = 0;
            TestStock.AlbumTitle = "2014 Forrest Hills Drive";
            TestStock.ReleaseDate = Convert.ToDateTime("16/02/2021");
            TestStock.StockAmount = 5;
            TestStock.Price = Convert.ToDouble("9.9900");
            TestStock.InStock = true;
            TestStock.StockID = 1;
            AllStock.ThisStock = TestStock;
            PrimaryKey = AllStock.Add();
            TestStock.StockID = PrimaryKey;
            AllStock.ThisStock.Find(PrimaryKey);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByAlbumTitleMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByAlbumTitle("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByAlbumTitleNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByAlbumTitle("XXX XXX");
            Assert.AreEqual(0, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByAlbumTitleTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByAlbumTitle("Thriller");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].StockID != 4)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
