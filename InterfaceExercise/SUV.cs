using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle , ICompany
	{
		public SUV()
		{
		}

        public bool AllWheelDrive { get; set; } = false;
        public int PassengerCapacity { get; set; } = 5;

        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";
        public int DoorCount { get; set; } = 4;
        public bool IsElectric { get; set; } = false;
        public string CompanyCountry { get; set; } = "USA";
        public string ForgeignOrDomestic { get; set; } = "Domestic";

        public void Drive()
        {
            Console.WriteLine("The SUV is in drive.");
        }
        public void Neutral()
        {
            Console.WriteLine("The SUV is in neutral.");
        }
        public void Park()
        {
            Console.WriteLine("The SUV is in park.");
        }
        public void Reverse()
        {
            Console.WriteLine("The SUV is in Reverse.");
        }
        public void VehicleOff()
        {
            Console.WriteLine("The SUV has been turned off.");
        }
        public void VehicleOn()
        {
            Console.WriteLine("The SUV has been turned on.");
        }
    }
}

