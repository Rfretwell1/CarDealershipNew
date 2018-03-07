using System;

namespace CarTest
{
    public class clsCar
    {
        public bool Active { get;  set; }
        public DateTime Age { get; set; }
        public string BodyType { get;  set; }
        public string CarMake { get;  set; }
        public string CarModel { get;  set; }
        public string Colour { get;  set; }
        public int Mileage { get; set; }

        public bool Valid(string someCar)
        {
            throw new NotImplementedException();
        }
    }
}