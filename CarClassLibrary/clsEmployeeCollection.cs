using CarTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarClassLibrary
{
    public class clsEmployeeCollection
    {




        List<clsEmployee> mEmployeeList = new List<clsEmployee>();
        // public property for count 


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


        public clsEmployee ThisEmployee { get; set; }




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
    }
}




