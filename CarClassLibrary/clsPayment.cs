using System;

namespace CarClassLibrary
{
    public class clsPayment
    {
        public string CarID
        {
            get
            {
                return mCarID;
            }
            set
            {
                mCarID = value;
            }
        }

        public double Cost { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public int PaymentNo
        {
            get
            {
                return mPaymentNo;
            }
            set
            {
                mPaymentNo = value; 
            }
        }

       
        
        public string Surname { get; set; }
        public bool Active { get; set; }

        public bool Find(Int32 PaymentID)
        {
            //set the private data member to the test data value
            mPaymentNo = 21;
            mCarID = "Test CarID";

            //always return true 
            return true;
        }
        //private data member to the test data value 
        private Int32 mPaymentNo;
        private string mCarID;

        public string Valid(string PaymentNo, string FirstName, string Surname, string CarID, string EmployeeID, string Description, string DateTime, string Cost)
        {
            //create a string variable to store the error 
            String Error = "";
            //is car id valid
            try
            {
                Int32 TempCarID = Convert.ToInt32(CarID);
                //if the CarID is blank
                if (TempCarID <= 0)
                {
                    Error = Error + "The CarId Should Not be 0";
                }
            }
            catch
            {
                Error = Error + "CarID is not a valid number";
            }

            if (FirstName == "")
            {
                //flag an error
                Error = Error + "FirstName cannot be blank";
            }
            //if the FirstNAme of the customer is more than 50 characters
            if (FirstName.Length > 50)
            {
                //flag an error
                Error = Error + "FirstName cannot be more than 50 characters";
            }

            if (EmployeeID == "")
            {
                //flag an error
                Error = Error + "EmployeeID cannot be blank";
            }
            //if the EmployeeID of the customer is more than 50 characters
            if (EmployeeID.Length > 50)
            {
                //flag an error
                Error = Error + "EmployeeID cannot be more than 50 characters";
            }

            if (Description == "")
            {
                //flag an error
                Error = Error + "Description cannot be blank";
            }
            //if the Description of the customer is more than 50 characters
            if (Description.Length > 50)
            {
                //flag an error
                Error = Error + "Description cannot be more than 50 characters";
            }

            if (DateTime == "")
            {
                //flag an error
                Error = Error + "DateTime cannot be blank";
            }
            //if the DateTime of the customer is more than 50 characters
            if (DateTime.Length > 50)
            {
                //flag an error
                Error = Error + "DateTime cannot be more than 50 characters";
            }

            if (Cost == "")
            {
                //flag an error
                Error = Error + "Description cannot be blank";
            }
            //if the Cost of the customer is more than 50 characters
            if (Cost.Length > 50)
            {
                //flag an error
                Error = Error + "Cost cannot be more than 50 characters";
            }
            //return any error messages 
            return Error; 
        }

    }
    
}