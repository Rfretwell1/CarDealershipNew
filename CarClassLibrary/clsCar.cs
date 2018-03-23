using System;
using CarClassLibrary;

namespace CarTest
{
    public class clsCar
    {
        public bool Active { get; set; }
        public int CarNo { get; set; }
        public int Age { get; set; }
        public string BodyType { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string Colour { get; set; }
        public int Mileage { get; set; }
    
        public bool Find(int CarNo)
      
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CarMake", CarMake);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByCarMake");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
            //copy the data from the database to the private data members
            Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
            CarNo = Convert.ToInt32(DB.DataTable.Rows[0]["CarNo"]);
            Age = Convert.ToInt32(DB.DataTable.Rows[0]["HouseNo"]);
            BodyType = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
            CarMake = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
            CarModel = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
            Colour = Convert.ToString(DB.DataTable.Rows[0]["CountyNo"]);
            Mileage = Convert.ToInt32(DB.DataTable.Rows[0]["DateAdded"]);
            
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
        public string Valid(string CarModel, string CarMake,string Colour, string Mileage,string BodyType, string Age)
        {
            {
                //boolean flag to indictate that all is ok();
                string Error = "";
               
             
                if (CarModel.Length < 5)
                {
                    //flag an error
                    Error = Error + "Car model must be more than 5 characters ";
                }

                //Car model is greater than 14
                if (CarModel.Length > 14)
                {
                    //flag an error
                    Error = Error + "Car model may not be more than 14 characters ";
                }
               
                if (CarMake.Length < 5)
                {
                    //flag an error
                    Error = Error + "Car make must be greater than 5 characters ";
                }
                //Car Make is greater than 10 charachters
                if (CarMake.Length > 10)
                {
                    //flag an error
                    Error = Error + "Car make may not be greater than 10 characters ";
                }
                //Age is less 0 
                if (Age.Length < 1)
                {
                    Error = Error + "Age should not be 0";
                
                }
                //Age is greater than 20
                if (Age.Length > 2)
                {
                    Error = Error + "Age should not be greater than 99";
                }
                //Colour is less than 3
                if (Colour.Length < 3)
                {
                    Error = Error + "Colour may not be less than 3 characters";
                
                }
                //Colour is less than 3
                if (Colour.Length > 9)
                {
                    Error = Error + "Colour must not be more than 9 characters";

                }
                //Mileage is less than 0
                if (Mileage.Length < 1)
                {
                    Error = Error + "Mileage must not be less than 0";
                }
                //Mileage is greater than 300000
                if (Mileage.Length > 6.1)
                {
                    Error = Error + "Mileage must not be greater than 300000";
                }
                //BodyType is less than 3
                if (BodyType.Length < 3)
                {
                    Error = Error + "BodyType must not be less than 3 charachters";

                }
                //BodyType is Greater than 13
                if(BodyType.Length > 13)
                {

                    Error = Error + "BodyType must not be greater than 13 characters ";
                }

                return Error;
                
            }
        }
    }
}