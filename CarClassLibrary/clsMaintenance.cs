using System;

namespace CarClassLibrary
{
    public class clsMaintenance
    {
        //private data member for the active
        private bool mActive;
        //private data member for the cost
        private Int32 mCost;
        //private data member for the date
        private DateTime mDate;
        //private data member for the Description
        private string mDescription;
        //private data member for the repair 
        private Boolean mRepair;
        //private data member for the maintenanceId
        private Int32 mMaintenanceID;




        public bool Active {
            get
            {
                //return the pritivate data 
                return mActive;

            }

            set
            {
                // set the value of the private data member 
                mActive = value;

            }
        }
        public int Cost {
            get
            {
                //return the pritivate data 
                return mCost;

            }

            set
            {
                // set the value of the private data member 
               mCost = value;

            }
        }
        public DateTime Date {
            get
            {
                //return the pritivate data 
                return mDate;

            }

            set
            {
                // set the value of the private data member 
                mDate = value;

            }
        }
        public string Description {
            get
            {
                //return the pritivate data 
                return mDescription;

            }

            set
            {
                // set the value of the private data member 
               mDescription = value;

            }
        }
        public bool Repair {
            get
            {
                //return the pritivate data 
                return mRepair;

            }

            set
            {
                // set the value of the private data member 
                mRepair = value;

            }
        }
        public int MaintenanceID

        {
            get
            {
                //return the pritivate data 
                return mMaintenanceID;
           
            }

            set
            {
                // set the value of the private data member 
                mMaintenanceID = value;

            }
        }

        public string Valid(string Description,string Cost, string MntDate)
        {
            string Error = "";
            if (Description == "")
            {
                Error = Error + "description may not be blank ";
            }
            if (Description.Length > 50)
            {
                Error = Error + "description 50 characters or less ";
            }

            if (Cost == "")
            {
                Error = Error + "cost may not be blank ";
            }
            if (Cost.Length > 50)
            {
                Error = Error + "cost 50 characters or less ";
            }


            if (MntDate == "")
            {
                Error = Error + "date may not be blank ";
            }
            return Error;
        }

        public bool Find(int Maintenance)
        {
            //Set the pritvate data member to the set data value
            mMaintenanceID = 12;
            mActive = true;
            mCost = 1;
            mDate = Convert.ToDateTime("16/9/2017");
            mDescription= "test description";
            mRepair = true;
           //alwyas return true 
            return true;
        }

     
    }
}