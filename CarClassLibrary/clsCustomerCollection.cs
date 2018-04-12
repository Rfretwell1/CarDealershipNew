using System;
using System.Collections.Generic;

namespace CarClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        public List<clsCustomer> AllCustomers;

        public List <clsCustomer> CustomerList

        {
            get
            {
                //return the private data
                return mCustomerList;
            }

            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mCustomerList.Count;
            }

            set
            {
                //set the private data
            }
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private Data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }


     /*  public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }*/

        public int Add()
         {
             //adds a new record to the database based on the values of mThisCustomer
             //set the primary key value of the new record
             mThisCustomer.CustomerID = 21;
             //return the primary key of the new record
             return mThisCustomer.CustomerID;
         }

        public void Delete()
        {
            //deletes the record point to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update1");
        }
    }



}