using System;
using System.Collections.Generic;

namespace CarClassLibrary
{
    public class clsMaintenanceCollection
    {
        public clsMaintenanceCollection()
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //data connection
            clsDataConnection DB = new clsDataConnection();
            //excute stored produces
            DB.Execute("sproc_tblMaintenance_SelectAll");
            //get the record count
            RecordCount = DB.Count;
            //while there are records
            while (Index < RecordCount)
            {
                //create a bank maintenancne
                clsMaintenance anMaintenance = new clsMaintenance();
                //read the feilds from the curreent record
                anMaintenance.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                anMaintenance.MaintenanceID = Convert.ToInt32(DB.DataTable.Rows[Index]["MaintenanceID"]);
                anMaintenance.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                anMaintenance.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                anMaintenance.Repair = Convert.ToBoolean(DB.DataTable.Rows[Index]["Repair"]);
                anMaintenance.Cost = Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
                //add the record to the private data member
                mMaintenanceList.Add(anMaintenance);
                //point at the next record
                Index++;

            }
        }


       

        //private data member for the list
        List<clsMaintenance> mMaintenanceList = new List<clsMaintenance>();
 //private data member  
        clsMaintenance mThisMaintenance = new clsMaintenance();

        public clsMaintenance ThisMaintenance
        {
            get
            {
                //Return the private data
                return mThisMaintenance;
            }
                set
            {
                //set the private data
                mThisMaintenance = value;
            }
                
                }



        public List<clsMaintenance> MaintenanceList
        
        
        {
            get
            {
                //return the private data
                return mMaintenanceList;
            }

            set
            {
                //set the priviate data
                mMaintenanceList = value;
            }
        }

             public int count
        {
            get
            {
                //return the private data
                return mMaintenanceList.Count;
            }

            set
            {
                //set the priviate data

            }

        
        }
    
       
    }
}