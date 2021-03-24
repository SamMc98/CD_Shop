﻿using System;
using System.Collections.Generic;
namespace ClassLibrary
 
{
    public class clsStaffCollection
    {

        //private data member for thelist
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        // constructor for the class
        public clsStaffCollection()
        {
            // var for the index
            Int32 Index = 0;

            // var to store the record count
            Int32 RecordCount = 0;

            // object for the data connection
            clsDataConnection DB = new clsDataConnection();

            // execute the sotred procedure
            DB.Execute("sproc_StaffManagement_SelectAll");

            // get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while(Index < RecordCount)
            {
                // create a blank staff
                clsStaff aStaff = new clsStaff();
                // read in the fields from the current record
                aStaff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["Manager"]);
                aStaff.StaffDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                aStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                aStaff.StaffYearlySalary = Convert.ToInt32(DB.DataTable.Rows[Index]["Salary"]);
                aStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);

                // add the record to the private data member
                mStaffList.Add(aStaff);

                // point at the next record
                Index++;
            }
        }


        public List<clsStaff> StaffList
        {
            get
            {
                // return the private data
                return mStaffList;
            }
            set
            {
                // set the private data
                mStaffList = value;
            }
        }
        public int count
        {
            get
            {
                // return the count of the list
                return mStaffList.Count;
            }
            set
            {
                // we shall worry about this later
            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                // return the priavte data
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            // adds a new record to the databse based on the values of thisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisStaff.StaffFullName);
            DB.AddParameter("@Manager", mThisStaff.Manager);
            DB.AddParameter("@DOB", mThisStaff.StaffDateOfBirth);
            DB.AddParameter("@Salary", mThisStaff.StaffYearlySalary);

            // execute the query returning the primary key value
            return DB.Execute("sproc_StaffManagement_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            // connect to the database
            clsDataConnection DB = new clsDataConnection();

            // set the parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@FullName", mThisStaff.StaffFullName);
            DB.AddParameter("@Manager", mThisStaff.Manager);
            DB.AddParameter("@DOB", mThisStaff.StaffDateOfBirth);
            DB.AddParameter("@Salary", mThisStaff.StaffYearlySalary);

            // execute the stored procedure
            DB.Execute("sproc_StaffManagement_Update");
        }
    }
}