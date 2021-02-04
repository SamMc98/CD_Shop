using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            // instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(Staff);
        }
    }
}
