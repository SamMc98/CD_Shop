﻿using System;
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


        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // create the item of test data
            clsStaff TestItem = new clsStaff();

            // var to store the primary key
            Int32 PrimaryKey = 0;

            // set its properties
            TestItem.Manager = true;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffFullName = "Joe Hughes";
            TestItem.StaffYearlySalary = 15000;

            // set ThisStaff to the test data
            allStaff.ThisStaff = TestItem;

            // add the record
            PrimaryKey = allStaff.Add();

            // set the primary key of the test data
            TestItem.StaffID = PrimaryKey;

            // find the record
            allStaff.ThisStaff.Find(PrimaryKey);

            // test to see that the two values are the same
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // create the item of test data
            clsStaff TestItem = new clsStaff();

            // var to store the PK
            int PrimaryKey = 80;

            // set its properties
            TestItem.Manager = true;
            TestItem.StaffFullName = "some name";
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffYearlySalary = 20000;

            // set ThisStaff to the test data
            allStaff.ThisStaff = TestItem;

            // add the record
            PrimaryKey = allStaff.Add();
            // set the PK of the test data
            TestItem.StaffID = PrimaryKey;

            // modify the test data
            TestItem.Manager = true;
            TestItem.StaffFullName = "anotehr name";
            TestItem.StaffDateOfBirth = DateTime.Now.Date;
            TestItem.StaffYearlySalary = 40000;

            // set the record based on the new test data
            allStaff.ThisStaff = TestItem;

            // update the record
            allStaff.Update();

            // find the record
            allStaff.ThisStaff.Find(PrimaryKey);

            // test to see ThisStaff matches the test data
            Assert.AreEqual(allStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection allStaff = new clsStaffCollection();

            // creete an item of test data
            clsStaff TestItem = new clsStaff();

            // var to store the PK
            Int32 PrimaryKey = 0;

            // set its properties
            TestItem.Manager = true;
            TestItem.StaffID = 10;
            TestItem.StaffFullName = "Some Name";
            TestItem.StaffYearlySalary = 100000;
            TestItem.StaffDateOfBirth = DateTime.Now.Date;

            // set thisAddress to the test data
            allStaff.ThisStaff = TestItem;

            // add the record
            PrimaryKey = allStaff.Add();

            // set the primary key of the test data
            TestItem.StaffID = PrimaryKey;

            // find the record
            allStaff.ThisStaff.Find(PrimaryKey);

            // delete the record
            allStaff.Delete();

            // now find the record
            Boolean Found = allStaff.ThisStaff.Find(PrimaryKey);

            // test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            // create an instance of the class containing unfiltered results
            clsStaffCollection allStaff = new clsStaffCollection();

            // create an instance of the filtered data
            clsStaffCollection filteredStaff = new clsStaffCollection();

            // apply a blank string (should return all records)
            filteredStaff.ReportByName("");
            // test to see that the two values are the same
            Assert.AreEqual(allStaff.count, filteredStaff.count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            // create an instance of the filtered data
            clsStaffCollection filteredStaff = new clsStaffCollection();

            // apply a name that doesn't exist
            filteredStaff.ReportByName("xxx xxx");
            // test to see that there are no records
            Assert.AreEqual(0, filteredStaff.count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            // create an instance of the filtered data
            clsStaffCollection filteredStaff = new clsStaffCollection();

            // var to store the outcome
            Boolean OK = true;

            // apply a post code that doesn't exist
            filteredStaff.ReportByName("SamHughes");

            // check that the correct number of records are found
            if(filteredStaff.count == 1)
            {
                // check that the first record is ID 1
                if(filteredStaff.StaffList[0].StaffID != 1)
                {
                    OK = false;
                }
                
            }
            else
            {
                OK = false;
            }
            // test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
