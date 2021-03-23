using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingStaff
{
    [TestClass]
    public class tstStaffCollection
    {
        
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // test to see that it exists
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();

            //add an item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();

            // set its properties
            TestItem.Manager = true;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffFullName = "Sam Hughes";
            TestItem.StaffYearlySalary = 20000;
            TestItem.StaffID = 2;

            // add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            allStaff.StaffList = TestList;

            // test to see that the two values are the same
            Assert.AreEqual(allStaff.StaffList, TestList);
        }



        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();

            //set the properties of the test object
            TestStaff.Manager = true;
            TestStaff.StaffDateOfBirth = DateTime.Now.Date;
            TestStaff.StaffFullName = "Sam Hughes";
            TestStaff.StaffYearlySalary = 20000;
            TestStaff.StaffID = 2;

            // assign the data to the property
            allStaff.ThisStaff = TestStaff;

            //test to see that the two values are equal
            Assert.AreEqual(allStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // create some test data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();

            // add item to the list
            // create the item of test data
            clsStaff TestItem = new clsStaff();

            // set its properties
            TestItem.Manager = true;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffFullName = "Sam Hughes";
            TestItem.StaffYearlySalary = 200000;
            TestItem.StaffID = 2;

            // add item to the test list
            TestList.Add(TestItem);

            // assign the data to the property
            allStaff.StaffList = TestList;

            // test to see that the two values are the same
            Assert.AreEqual(allStaff.count, TestList.Count);  
        }


    }
}
