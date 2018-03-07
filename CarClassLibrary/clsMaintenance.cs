using System;

namespace CarClassLibrary
{
    public class clsMaintenance
    {
        public bool Active { get; set; }
        public int Cost { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Repair { get; set; }
        public int MaintenanceID { get; set; }

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
            MaintenanceID = 12;
            //alwyas return true 
            return true;
        }

     
    }
}