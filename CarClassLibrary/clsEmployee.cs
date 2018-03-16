using System;

namespace CarClassLibrary
{
    public class clsEmployee
    {
        public clsEmployee()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Employee { get; set; }
        public int EmployeeNo { get; set; }
        public bool Active { get; set; }
        public DateTime DateJoined { get; set; }
        public string EmailAddress { get; set; }
        public string JobTitle { get; set; }
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



        public string Valid(string FirstName, string LastName, string Address, string PostCode, string DateJoined, string EmailAddress, string PhoneNumber, string Jobtitle)
        {
            //boolean flag to indictate that all is ok();
            string Error = "";
            //if the name of the county is blank
            if (FirstName == "")
            {
                //flag an error
                Error = Error + "First name cannot be blank ";
            }

            //if the name of the customer is more than 50 characters
            if (FirstName.Length > 50)
            {
                //flag an error
                Error = Error + "First name cannot be more than 50 characters ";
            }

            if (LastName == "")
            {
                //flag an error
                Error = Error + "Last name cannot be blank ";
            }

            //if the name of the customer is more than 50 characters
            if (LastName.Length > 50)
            {
                //flag an error
                Error = Error + "Last name cannot be more than 50 characters ";
            }

            if (EmailAddress == "")
            {
                //flag an error
                Error = Error + "Email Address cannot be blank";
            }
            //if the email address of the customer is more than 50 characters
            if (EmailAddress.Length > 50)
            {
                //flag an error
                Error = Error + "Email Address cannot be more than 50 characters";
            }

            if (Address == "")
            {
                //flag an error
                Error = Error + "Address cannot be blank";
            }
            //if the email address of the customer is more than 50 characters
            if (Address.Length > 50)
            {
                //flag an error
                Error = Error + "Address cannot be more than 50 characters";
            }

            if (PostCode == "")
            {
                //flag an error
                Error = Error + "Post Code cannot be blank";
            }
            //if the email address of the customer is more than 10 characters
            if (PostCode.Length > 10)
            {
                //flag an error
                Error = Error + "Post Code cannot be more than 10 characters";
            }
            if (Jobtitle == "")
            {
                //flag an error
                Error = Error + "Job Title cannot be blank";
            }
            //if the email address of the customer is more than 30 characters
            if (Jobtitle.Length > 30)
            {
                //flag an error
                Error = Error + "Phone Number cannot be more than 30 characters";
            }

            if (PhoneNumber == "")
            {
                //flag an error
                Error = Error + "Post Code cannot be blank and must be all digits e.g '0742432432432'";
            }
            //if the email address of the customer is more than 15 characters
            if (PhoneNumber.Length > 15)
            {
                //flag an error
                Error = Error + "Phone Number cannot be more than 15 characters";
            }
            return Error;
        }
    }
}


