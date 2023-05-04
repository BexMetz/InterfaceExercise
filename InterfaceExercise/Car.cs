using System;
namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
		public Car()
        {
        }

        public bool IsConvertable { get; set; } = false;
        public string StandardOrSport { get; set; } = "Standard";


        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";
        public int DoorCount { get; set; } = 4;
        public bool IsElectric { get; set; } = false;
        public string CompanyCountry { get; set; } = "USA";
        public string ForgeignOrDomestic { get; set; } = "Domestic";

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is in drive.");
        }
        public void Neutral()
        {
            Console.WriteLine($"The {GetType().Name} is in neutral.");
        }
        public void Park()
        {
            Console.WriteLine($"The {GetType().Name} is in park."); 
        }
        public void Reverse()
        {
            Console.WriteLine($"The {GetType().Name} is in Reverse.");
        }
        public void VehicleOff()
        {
            Console.WriteLine($"The {GetType().Name} has been turned off.");
        }
        public void VehicleOn()
        {
            Console.WriteLine($"The {GetType().Name} has been turned on."); 
        }
    }
}

