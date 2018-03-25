using System;
using CarClassLibrary;

namespace CarTest
{
    public class clsCar
    {
        //private data member for the AddressNo property
        private Int32 mCarNo;
        //private data member for HouseNo
        private string mCarMake;
        //private data member for street
        private string mCarModel;
        //private data member for town
        private string mColour;
        //private data member for post code
        private string mBodyType;
        //private data member for county no
        private Int32 mAge;
        //private data member for active       
        private Boolean mActive;
        //private date added data member
        private Int32 mMileage;
        
        
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //public property for Mileage
        public Int32 Mileage
        {
            get
            {
                //return the private data
                return mMileage;
            }
            set
            {
                //set the private data
                mMileage = value;
            }
        }

        //public property for the address number
        public int CarNo
        {
            get
            {
                //return the private data
                return mCarNo;
            }
            set
            {
                //set the value of the private data member
                mCarNo = value;
            }
        }

        //public property for county no
        public string CarMake
        {
            get
            {
                //return the private data
                return mCarMake;
            }
            set
            {
                //set the private data
                mCarMake = value;
            }
        }

        //public property for house no
        public string CarModel
        {
            get
            {
                //return private data
                return mCarModel;
            }
            set
            {
                //set the private data
                mCarModel = value;
            }
        }

        //public property for post code
        public string Colour
        {
            get
            {
                //return the private data
                return mColour;
            }
            set
            {
                //set the private data
                mColour = value;
            }
        }

        //public data member for street
        public string BodyType
        {
            get
            {
                //return the private data
                return mBodyType;
            }
            set
            {
                //set the private data
                mBodyType = value;
            }
        }

        //public data member for Town
        public Int32 Age
        {
            get
            {
                //return the private data
                return mAge;
            }
            set
            {
                //set the private data
                mAge = value;
            }
        }
    
    public bool Find(int CarNo)
      
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CarNo", CarNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCar_FilterByCarNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
            //copy the data from the database to the private data members
            CarNo = Convert.ToInt32(DB.DataTable.Rows[0]["CarNo"]);                                   
            CarMake = Convert.ToString(DB.DataTable.Rows[0]["CarMake"]);
            CarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
            Colour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
            BodyType = Convert.ToString(DB.DataTable.Rows[0]["BodyType"]);
            Age = Convert.ToInt32(DB.DataTable.Rows[0]["Age"]);                       
            Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); 
            Mileage = Convert.ToInt32(DB.DataTable.Rows[0]["Mileage"]);
            
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