using System.Collections.Generic;

namespace CarClassLibrary
{
    public class clsMaintenanceCollection
    {


        //private data member for the list
        List<clsMaintenance> mMaintenanceList = new List<clsMaintenance>();




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
    
        public clsMaintenance ThisMaintenance { get; set; }
    }
}