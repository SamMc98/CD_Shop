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
        public void ActivePropertyOK()


        {
/*   hello
            //create an instance of the class of the we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Active, TestData);
            */
        }
    }
}
