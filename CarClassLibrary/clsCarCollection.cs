using CarTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarClassLibrary
{
    public class clsCarCollection
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
                AnCar.CarNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CarNo"]);
                AnCar.CarMake = Convert.ToString(DB.DataTable.Rows[Index]["CarMake"]);
                AnCar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AnCar.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);                                               
                AnCar.BodyType = Convert.ToString(DB.DataTable.Rows[Index]["BodyType"]);
                AnCar.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                AnCar.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCar.Mileage = Convert.ToInt32(DB.DataTable.Rows[Index]["Mileage"]);
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

        public clsMaintenance ThisMaitenance { get; set; }

        public int Add()
        {
            //Add a new record to the database based on the value thisCar
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarNo", mThisCar.Active);
            DB.AddParameter("@CarMake", mThisCar.CarMake);
            DB.AddParameter("@CarModel", mThisCar.CarModel);
            DB.AddParameter("@Colour", mThisCar.Colour);
            DB.AddParameter("@BodyType", mThisCar.BodyType);
            DB.AddParameter("@Age", mThisCar.Age);
            DB.AddParameter("@Active", mThisCar.Active);
            DB.AddParameter("@Mileage", mThisCar.Mileage);
            
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCar2_Insert");


        }
        public void Delete()
        {
            //deletes the record pointed to by thisCar
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarNo", mThisCar.CarNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_Delete");
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

        public void FilterByCarMake2(string CarMake)
        {
            //filters the records based on a full or partial car make
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@CarMake", CarMake);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByCarMake");
            //populate the array list with the data table
            PopulateArray(DB);

        }

    }

}
