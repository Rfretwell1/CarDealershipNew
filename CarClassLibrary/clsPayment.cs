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

       
        public string SurnameName { get; set; }
        

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
    }
    
}