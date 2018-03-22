﻿using CarTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    class clsCarCollection
    {
        //private data member for the list
        List<clsCar> mCarList = new List<clsCar>();
        //private data member thisAddress
        clsCar mThisCar = new clsCar();

        //constructor for the class
        public clsCarCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCar_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCarList = new List<clsCar>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Car
                clsCar AnCar = new clsCar();
                //read in the fields from the current record
                AnCar.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCar.CarMake = Convert.ToString(DB.DataTable.Rows[Index]["CarMake"]);
                AnCar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnCar.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                AnCar.Mileage = Convert.ToInt32(DB.DataTable.Rows[Index]["Mileage"]);
                AnCar.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                AnCar.BodyType = Convert.ToString(DB.DataTable.Rows[Index]["BodyTYpe"]);
                //add the record to the private data mamber
                mCarList.Add(AnCar);
                //point at the next record
                Index++;
            }

        }
        //Public property for the Car list
              public List<clsCar> CarList
        {
              get
            {
                //return the private data
                return mCarList;
            }
            set
            {
                //set the private data
                mCarList = value;
            }
        }

        //Public property for count
        public int Count
        {    
            get
            {
                //return the count of the list
                return mCarList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //Public property for This Car
        public clsCar ThisCar
        {
            get
            {
                //return the private data
                return mThisCar;
            }
            set
            {
                //set the private data
                mThisCar = value;
            }
        }
        public int Add()
        {
            //Add a new record to the database based on the value thisCar
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Active", mThisCar.Active);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@Colour", mThisCar.Colour);
            DB.AddParameter("@Age", mThisCar.Age);
            DB.AddParameter("@BodyType", mThisCar.BodyType);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCar_Insert");


        }
        public void Delete()
        {
            //deletes the record pointed to by thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Delete");
        }

        public int Update()
        {
            //Update an existing record in the database based on the value thisCar
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Active", mThisCar.Active);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@Colour", mThisCar.Colour);
            DB.AddParameter("@Age", mThisCar.Age);
            DB.AddParameter("@BodyType", mThisCar.BodyType);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCar_Update");


        }
   

    }

}
