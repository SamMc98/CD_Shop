using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        private int mStaffID;
        private DateTime mDateAdded;
        private Boolean mManager;
        private String mFullName;
        private Double mStaffSalary;

        //good test data
        //create the good test data for the method valid
        string FullName = "Sam Hughes";
        string DOB = DateTime.Now.Date.ToString();
        string Salary = "30000";

        public bool Manager
        {
            get
            {
                // return the private data
                return mManager;
            }
            set
            {
                mManager = value;
            }
        }
        public DateTime StaffDateOfBirth
        {
            get
            {
                //this line of code sends the data out of the property
                return mDateAdded;
            }
            set
            {
                // this line of code allows data into the property
                mDateAdded = value;
            }

        }
        public int StaffID
        {
            get
            {
                //this line of code sends the data out of the property
                return mStaffID;
            }
            set
            {
                // this line of code allows data into the property
                mStaffID = value;
            }
        }

        public string StaffFullName
        {
            get
            {
                // reutrn the private data
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }
        public double StaffYearlySalary
        {
            get
            {
                // return theprivate data
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        public bool Find(int staffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", staffID);
            DB.Execute("sproc_StaffManagement_FilterByStaffID");
            // if one record isfound (there should be either one or zero)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mManager = Convert.ToBoolean(DB.DataTable.Rows[0]["Manager"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mStaffSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);

                // return that everything worked OK
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem
                return false;
            }

        }

        public string Valid(string fullName, string dOB, string salary)
        {
            //create a string var to store the error
            String Error = "";

            // temp var to store date values
            DateTime DateTemp;

            // temp var for salary
            Int32 theSal;
            
            //if the FullName is blank
            if(fullName.Length == 0)
            {
                // record the error
                Error = Error + "The FullName may not be blank : ";
            }
            // if the fullname is greater than 21 chars 
            if(fullName.Length > 21)
            {
                // record the error
                Error = Error + "The FullName must be equal to or less than 21 characters";
            }
            try
            {
                // copy the DOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dOB);
                // create a date 100 years in the past to check that the person is not more than 100 years old
                DateTime DateMinusHund;
                DateMinusHund = DateTime.Now.Date.AddYears(-100);
                if (DateTemp <= DateMinusHund)
                {
                    // record the error
                    Error = Error + "The date cannot be 100 years or more the past : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            /*
            // create a date 1 day earlier than 16 years ago to make sure the person is atleast 16 years old
            DateTime DateSixteen;
            DateSixteen = DateTime.Now.Date.AddYears(-16).AddDays(-1);
            if(DateTemp >= DateSixteen)
            {
                // record the error
                Error = Error + "The employee has to be atleast 16 years old to work here";
            }*/
            try
            {
                theSal = Convert.ToInt32(salary);

                if (theSal < 100)
                {
                    //record the error
                    Error = Error + "The salary cannot be less than 100 : ";
                }

                if (theSal > 100000)
                {
                    //record the error
                    Error = Error + "The salary cannot be more than 100,000 : ";
                }
            }
            catch
            {
                Error = Error + "The Salary was not a valid Integer : ";
            }


            return Error;
        }
    }
}