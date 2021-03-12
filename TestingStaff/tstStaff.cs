using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create the good test data for the method valid
        string FullName = "Sam Hughes";
        string DOB = DateTime.Now.Date.ToString();
        string Salary = "30000";


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

            if (aStaff.StaffDateOfBirth != Convert.ToDateTime("1995-11-10"))
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
            if (aStaff.StaffFullName != "SamHughes")
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
            if (aStaff.StaffYearlySalary != 30000)
            {
                OK = false;
            }

            //test that the result is correct
            Assert.IsTrue(OK);
        }
        
        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // string var to store any error message
            String Error = "";

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, Salary);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
         } 

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // string variable to store any error message
            String Error = "";

            //create some test data to pass to the method
            string FullName = ""; // this should trigger an error

            // invoke the metho
            Error = aStaff.Valid(FullName, DOB, Salary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            // create instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // string var to store the error message
            String Error = "";

            // create some test data to pass to the method
            string Fullname = "aa";

            // invoke the method

            Error = aStaff.Valid(FullName, DOB, Salary);

            // test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // string var to store the error message
            String Error = "";

            // create some test data to pass to the method
            String FullName = "aaaaaaaaaaaaaaaaaaaa";

            // invoke the method
            Error = aStaff.Valid(FullName, DOB, Salary);

            // test to see that result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // string var to store the erro message
            String Error = "";

            // create test data to pass to the method
            String FullName = "aaaaaaaaaaaaaaaaaaaa";

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, Salary);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // create a string var to store the error message
            String Error = "";

            // create some test data to pass to the method
            String FullName = "aaaaaaaaaa";

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff aStafff = new clsStaff();

            // create a string var for the error message
            String Error = "";

            //create some test data to pass to the method
            String FullName = "aaaaaaaaaaaaaaaaaaaaaaa";

            //invoke the method
            Error = aStafff.Valid(FullName, DOB, Salary);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxExtreme()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // strin var to store any error mesaage
            String Error = "";
            // create some test data to pass to teh method
            string FullName = "";
            FullName = FullName.PadRight(500, 'a'); // this should fail

            // invoke the method
            Error = aStaff.Valid(FullName, DOB, Salary);
            // test to see that result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxLessOneYear()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // string var for error message
            String Error = "";

            // var to store test data
            DateTime TestDate;

            // set the date to todays date
            TestDate = DateTime.Now.Date;

            //change the date to whatevre the date is less than 100 years
            TestDate = TestDate.AddYears(-99);

            //conver the date var to a string
            String DateAdded = TestDate.ToString();

            // invoke the method
            Error = aStaff.Valid(FullName, DateAdded, Salary);

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // create a variable to store an error message
            String Error = "";

            // create a var to store the test date data
            DateTime TestDate;

            // set the date to todays date
            TestDate = DateTime.Now.Date;

            // change the date to whatever the max dob is minus 1 year
            TestDate = TestDate.AddYears(-101);

            // convert the date var to a string
            string DateAdded = TestDate.ToString();

            // invoke the method
            Error = aStaff.Valid(FullName, DateAdded, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // create a variable to store an error message
            String Error = "";

            // create a var to store the test date data
            DateTime TestDate;

            // set the date to todays date
            TestDate = DateTime.Now.Date;

            // change the date to whatever the max dob is minus 1 year
            TestDate = TestDate.AddYears(-1000);

            // convert the date var to a string
            string DateAdded = TestDate.ToString();

            // invoke the method
            Error = aStaff.Valid(FullName, DateAdded, Salary);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DOBminLessOne()
        {
            // create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // create a variable to store an error message
            String Error = "";

            // create a var to store the test date data
            DateTime TestDate;

            // set the date to todays date
            TestDate = DateTime.Now.Date;

            // change the date to whatever the max dob is minus 1 year
            TestDate = TestDate.AddYears(-15);

            // convert the date var to a string
            string DateAdded = TestDate.ToString();

            // invoke the method
            Error = aStaff.Valid(FullName, DateAdded, Salary);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
     

        [TestMethod]
        public void SalarayExtremeMin()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 0;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMinMinusOne()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 99;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMin()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 100;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMinPlusOne()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 101;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMaxLessOne()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 99999;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMax()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 100000;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMid()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 50000;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SalarayMaxPlusOne()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 100001;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalarayExtremeMax()
        {
            //create an instance of the class
            clsStaff aStaff = new clsStaff();

            //create a variable to store an error message
            String Error = "";

            //create a var to store test date
            Int32 TestData;

            // change the salary data to an extreme min
            TestData = 100000001;

            // convert from int to string
            String stringData = TestData.ToString();

            //invoke the method
            Error = aStaff.Valid(FullName, DOB, stringData);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DOBInvalidDate()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            // strin var to store any error message
            String Error = "";

            // set the DateAdded to a non date value
            string DateAdded = "this is not a date!";

            // invoke the method 
            Error = aStaff.Valid(FullName, DateAdded, Salary);

            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SalaryValidInt()
        {
            //create an instance of the class we want to create
            clsStaff aStaff = new clsStaff();

            //string var to store any error message
            String Error = "";

            // set the salary to a non int value
            string SalaryR = "this is not a salary!";

            // invoke the method
            Error = aStaff.Valid(FullName, DOB, SalaryR);

            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
