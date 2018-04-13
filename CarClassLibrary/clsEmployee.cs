using System;

namespace CarClassLibrary
{
    public class clsEmployee
    { // private data member for the employeee number 
        private Int32 mEmployeeNo;
        private bool mActive;
        private string mFirstName;
        private string mLastName;  
        private string mAddress;
        private DateTime mDateJoined;
        private string mPostCode;
        private string mEmailAddress;
        private string mJobTitle;
        private string mPhoneNumber;

      
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }


        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }



        public int EmployeeNo
        {
            get
            {
                return mEmployeeNo;
            }
            set
            {
                mEmployeeNo = value;
            }
        }
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return mJobTitle;
            }
            set
            {
                mJobTitle = value;
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
                mPostCode = value;
            }
        }

        public string Employee { get; set; }

        public bool Find(int EmployeeNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@EmployeeNo", EmployeeNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByEmployeeNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
               mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
               mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mJobTitle = Convert.ToString(DB.DataTable.Rows[0]["JobTitle"]);
                mEmployeeNo = Convert.ToInt32(DB.DataTable.Rows[0]["EmployeeNo"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string firstName, string lastName, string address, string postCode, string dateJoined, string emailAddress, string phoneNumber, string Jobtitle)
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

        public bool Valid(string someText)
        {
            throw new NotImplementedException();
        }
    }

}


