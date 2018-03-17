using System;
using CarClassLibrary;
using System.Collections.Generic;

namespace CarClassLibrary
{
    public class clsEmployeeCollection
    {
       



        private List<clsEmployee> mAllEmployees = new List<clsEmployee>();
        // public property for count 
        public int Count
        {
            get
            {
                // return the count property of the private list
                return mAllEmployees.Count;

            }
            set
            {
                // assign the incoming value to the private data member 
               
            }
        }

            public List<clsEmployee> AllEmployees
        {
            //getter send data requesting code 
            get
            {
                // returns private data member 
                return mAllEmployees;
            }
            // setter acepts data from other objects 
            set
            {
                //assign the incoming value to the private data member 
                mAllEmployees = value;

            }

        }

        public clsEmployeeCollection()
        {
            // create an instance oof the employee class to store an employee 
            clsDataConnection DB = new clsDataConnection();
            // excecute the stored procudure to et the list of data
            DB.Execute("sproc_tblEmployees_SelectAll");
            // get get the count of records 
            Int32 RecordCount = DB.Count;
            //set up an index for the loop 
            Int32 Index = 0;
            // while ther are records to procces 
            while (Index < RecordCount)
            {
                //create a new instance of the employee class 
                clsEmployee AnEmployee = new clsEmployee();
                //get the employee name 
                AnEmployee.FirstName = DB.DataTable.Rows[Index]["Employee"].ToString();
                //get the primary key 
                AnEmployee.EmployeeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["Employee"]);
                // add the employee to the private data member 
                mAllEmployees.Add(AnEmployee);
                // increment the index 
                Index++;
              
            }


        }
     




        }





    }

    
      


