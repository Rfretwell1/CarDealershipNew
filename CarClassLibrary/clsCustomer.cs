using System;
namespace CarClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get;  set; }
        public string Address { get;  set; }
        public int CustomerID { get;  set; }
        public DateTime DateAdded { get;  set; }
        public string EmailAddress { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string PhoneNumber { get;  set; }
        public string PostCode { get;  set; }

        public string Valid(string FirstName, string LastName, string Address, string PostCode, string DateAdded, string EmailAddress, string PhoneNumber)
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

            if (EmailAddress =="")
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
            //if the email address of the customer is more than 50 characters
            if (PostCode.Length > 50)
            {
                //flag an error
                Error = Error + "Post Code cannot be more than 50 characters";
            }

            if (PhoneNumber == "")
            {
                //flag an error
                Error = Error + "Post Code cannot be blank and must be all digits e.g '07123456789'";
            }
            //if the email address of the customer is more than 50 characters
            if (PhoneNumber.Length > 50)
            {
                //flag an error
                Error = Error + "Phone Number cannot be more than 50 characters";
            }
            return Error;
        }
    }
}