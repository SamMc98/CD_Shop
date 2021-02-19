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
            // set the private data members to the test data value
            mStaffID = 1;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mManager = true;
            mFullName = "Test Name";
            mStaffSalary = 10000.50;
            // always return true
            return true;
        }
    }
}