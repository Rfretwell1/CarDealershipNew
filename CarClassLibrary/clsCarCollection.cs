using CarTest;
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
                //create a blank address
                clsCar AnCar = new clsCar();
                //read in the fields from the current record
                AnCar.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnCar.CarMake = Convert.ToString(DB.DataTable.Rows[Index]["AddressNo"]);
                AnCar.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CountyNo"]);
                AnCar.Colour = Convert.ToString(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCar.Mileage = Convert.ToInt32(DB.DataTable.Rows[Index]["HouseNo"]);
                AnCar.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["PostCode"]);
                AnCar.BodyType = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                //add the record to the private data mamber
                mCarList.Add(AnCar);
                //point at the next record
                Index++;
            }

        }
    }

}
