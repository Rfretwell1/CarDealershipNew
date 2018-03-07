using System;

namespace ClassLibrary
{
    public class clsEmployee
    {
        public string Employee { get; set; }
        public int EmployeeNo { get; set; }
        public bool Active { get; set; }
        public string Address { get; set; }
        public int EmployeeID { get; set; }
        public DateTime DateJoined { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }

       


        public Boolean Valid(string FirstName)
        {
            // var to record ant error found in the county nme asumming all is ok 
            Boolean OK = true;
            // test to tsee if the county a zero characters 
            if (FirstName.Length == 0)
            {
                // set ol to false 
                OK = false;
            }
            // test to see that the string sis more tha 20 characters 
            if (FirstName.Length > 20)
            {
                //set ok to false 
                OK = false;
            }
            // return results of all tests 
            return OK;
        }
    }
}