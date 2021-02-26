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
    }
}