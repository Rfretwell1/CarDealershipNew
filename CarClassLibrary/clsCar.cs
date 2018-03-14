using System;

namespace CarTest
{
    public class clsCar
    {
        public bool Active { get;  set; }
        public int Age { get; set; }
        public string BodyType { get;  set; }
        public string CarMake { get;  set; }
        public string CarModel { get;  set; }
        public string Colour { get;  set; }
        public int Mileage { get; set; }

        public string Valid(string CarModel, string CarMake,string Colour, string Milage,string BodyType, string Age)
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

                return Error;
                
            }
        }
    }
}