using System;
namespace CarClassLibrary
{
    public class clsCustomer
    {

        private bool mActive;
        private string mAddress;
        private Int32 mCustomerID;
        private DateTime mDateAdded;
        private string mEmailAddress;
        private string mFirstName;
        private string mLastName;
        private string mPhoneNumber;
        private string mPostCode;


        public bool Active
        {
            get
            {
                //return the rivate data
                return mActive;
            }
            set
            {
                //set the value of the private data member
                mActive = value;
            }
        }

        public string Address
        {
            get
            { 
                //return the private data
                return mAddress;
            }
            set
            {
                //set the value of the private data member
                mAddress = value;
            }
        }

        public Int32 CustomerID
        {
            get
            {
                //return the private data member
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                //return the private data member
                return mDateAdded;
            }
            set
            {
                //set the value of the private data member
                mDateAdded = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                //return the private data member
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                //set the value of the private data member
                mLastName = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                //set the value of the private data member
                mPhoneNumber = value;
            }
        }

        public string PostCode
        {
            get
            {
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }
        }

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

        public bool Find(int Customer)
        {

            //create an instance
            clsDataConnection DB = new clsDataConnection();
            //add a parameter
            DB.AddParameter("@CustomerID", CustomerID);
            //if one record is found
            if (DB.Count ==1)
            {
                //copy the data from the database to the member
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);

                return true;
            } 
            //if no records found
            else
            {
                return false;
            }
        }


    }
}