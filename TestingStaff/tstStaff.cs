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



        [TestMethod]
        public void ManagerOK()
        {
            // create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            // create some test data
            Boolean TestData = true;
            // assign the data to the property
            Staff.Manager = TestData;
            // test to see if the two values are the same
            Assert.AreEqual(Staff.Manager, TestData);
        }

        [TestMethod]
        public void StaffDateOfBirth()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            // create some test data
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            Staff.StaffDateOfBirth = TestData;
            // test that the two values are the same
            Assert.AreEqual(Staff.StaffDateOfBirth, TestData);
            
        }

        [TestMethod]
        public void StaffID()
        {
            // create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            // create some test data
            int TestData = 1;
            // assign the data to the property
            Staff.StaffID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(Staff.StaffID, TestData);

        }


        [TestMethod]
        public void StaffFullName()
        {
            // create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            // create some test data
            String TestData = "abc";
            // Assign the data to the property
            Staff.StaffFullName = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(Staff.StaffFullName, TestData);
        }

        [TestMethod]
        public void StaffYearlySalary()
        {
            // create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            // create some test data
            double TestData = 1000.50;
            // assign the data to the property
            Staff.StaffYearlySalary = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(Staff.StaffYearlySalary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // boolean variable to store the results of the validation
            bool Found = false;
            // create some test data to use with the method
            Int32 StaffID = 1;
            // invoke the method
            Found = aStaff.Find(StaffID);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdNoFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // bool variable to store the result of the search
            Boolean Found = false;

            // bool variable to store the result of the search if data is OK
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffID = 1;

            //invoke the method
            Found = aStaff.Find(StaffID);

            // check the staffID
            if(aStaff.StaffID != 1)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDataAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // bool var to store the result of the search
            Boolean Found = false;

            // bool var to record if data is OK (Assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 StaffID = 1;

            // invoke the method
            Found = aStaff.Find(StaffID);

            if (aStaff.StaffDateOfBirth != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIfManager()
        {
            // create an isntance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // bool var to store the result of the search
            Boolean Found = false;

            // bool var to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffID = 1;

            // invoke the method
            Found = aStaff.Find(StaffID);

            if (aStaff.Manager != true)
            {
                OK = false;
            }
            //test to see that the result is correct

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFullNameFound()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // bool var to store teh result of the search
            Boolean Found = false;

            // bool var to record if the data is OK
            Boolean OK = true;

            // create some test data to use with the method
            Int32 StaffID = 1;

            // invoke the method
            Found = aStaff.Find(StaffID);

            // check the staff name
            if (aStaff.StaffFullName != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffSalary()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // bool var to store the result of the search
            Boolean Found = false;

            //bool var to store if the record data is OK (assume it is)
            Boolean OK = true;

            // create some test data to use with the method
            Int32 StaffID = 1;

            // invoke the method
            Found = aStaff.Find(StaffID);

            // check the property
            if (aStaff.StaffYearlySalary != 10000.50)
            {
                OK = false;
            }

            //test that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
