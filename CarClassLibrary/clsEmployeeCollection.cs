using CarTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarClassLibrary
{
    public class clsEmployeeCollection
    {


        //k // i have changed a few things


        List<clsEmployee> mEmployeeList = new List<clsEmployee>();
        // public property for count 

        clsEmployee mThisEmployee = new clsEmployee();


        public List<clsEmployee> EmployeeList
        {
            //getter send data requesting code 
            get
            {
                // returns private data member 
                return mEmployeeList;
            }
            // setter acepts data from other objects 
            set
            {
                //assign the incoming value to the private data member 
                mEmployeeList = value;

            }

        }
        public int Count
        {
            get
            {
                // return the count property of the private list
                return mEmployeeList.Count;

            }
            set
            {
                // assign the incoming value to the private data member 

            }
        }
        //hey

        public clsEmployee ThisEmployee
        {
            get
            {
                // return the private data 
                return mThisEmployee;
            }
             set
            {
                // set the private data 
                mThisEmployee = value;
            }
        }
  


        public clsEmployeeCollection()
        {
            // war for the index 
            Int32 Index = 0;
            //var to stor the record count 
            Int32 RecordCount = 0;
            // create an instance oof the employee class to store an employee 
            clsDataConnection DB = new clsDataConnection();
            // excecute the stored procudure to et the list of data
            DB.Execute("sproc_tblEmployees_SelectAll");
            // get get the count of records 
            RecordCount = DB.Count;
            // while ther are records to procces 
            while (Index < RecordCount)
            {
                //create a new instance of the employee class 

                clsEmployee AnEmployee = new clsEmployee();
                // read in the fiels from the current record 
                AnEmployee.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnEmployee.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnEmployee.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnEmployee.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnEmployee.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnEmployee.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnEmployee.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AnEmployee.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnEmployee.JobTitle = Convert.ToString(DB.DataTable.Rows[Index]["JobTitle"]);
                AnEmployee.EmployeeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["EmployeeNo"]);
                AnEmployee.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                // add the record to the private data member 
                mEmployeeList.Add(AnEmployee);
                // point ot the next record 
                Index++;

            }

        }


        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisEmployee.FirstName);
            DB.AddParameter("@LastName", mThisEmployee.LastName);
            DB.AddParameter("@DOB", mThisEmployee.DOB);
            DB.AddParameter("@Address", mThisEmployee.Address);
            DB.AddParameter("@PhoneNumber", mThisEmployee.PhoneNumber);
            DB.AddParameter("@EmailAddress", mThisEmployee.EmailAddress);
            DB.AddParameter("@Active", mThisEmployee.Active);
            DB.AddParameter("@PostCode", mThisEmployee.PostCode);
            DB.AddParameter("@JobTitle", mThisEmployee.JobTitle);
            DB.AddParameter("@DateJoined", mThisEmployee.DateJoined);
            DB.AddParameter("@Active", mThisEmployee.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAddress_Insert");
        }

    }
}




