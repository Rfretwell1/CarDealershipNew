using System;
using System.Collections.Generic;

namespace CarClassLibrary
{
    public class clsPaymentCollection
    {
        public int Count { get; set; }
        public List<clsPayment> PaymentList { get; set; }
        public object ThisPayment { get; set; }
    }

    public class clsPaymentcollection
    {
        //private data member for the list 
        List<clsPayment> mPaymentList = new List<clsPayment>();
        //public property for the payment list
        public List<clsPayment> PaymentList
        {
            get
            {
                //return the private data 
                return mPaymentList;
            }
            set
            {
                //set the private data 
                mPaymentList = value;
            }
        }


    }
    //public property for count 
    /*public int Count
    {
        get
        {
            //retur the count of the list 
            return mPaymentList.Count;
        }
        set
        {
            //we shall worry about this later 
        }
    }*/

    /*public clsPaymentCollection()   
    {
        //create an istance of the class we want to create
        clsPayment TestItem = new clsPayment();
        //set its properties 
        TestItem.Active = true;
        TestItem.PaymentNo = 1;
        TestItem.FirstName = "Ben";
        TestItem.Surname = "Stark";
        TestItem.CarID = "1";
        TestItem.EmployeeID = "E";
        TestItem.Description = "MOT";
        TestItem.DateTime = DateTime.Now.Date;
        TestItem.Cost = 50.00;
        //add the item to the test list 
        TestList.Add(TestItem);
        //add the item to the test list
        mPaymentList.Add(TestItem);


    }*/


}