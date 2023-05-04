using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle , ICompany
	{
		public Truck()
		{
		}

        public double TruckBedLength { get; set; } = 6.78;
        public bool IsDiesel { get; set; } = false;

        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";
        public int DoorCount { get; set; } = 2;
        public bool IsElectric { get; set; } = false;
        public string CompanyCountry { get; set; } = "USA";
        public string ForgeignOrDomestic { get; set; } = "Domestic";

        public void Drive()
        {
            Console.WriteLine("The truck is in drive.");
        }
        public void Neutral()
        {
            Console.WriteLine("The truck is in neutral.");
        }
        public void Park()
        {
            Console.WriteLine("The truck is in park.");
        }
        public void Reverse()
        {
            Console.WriteLine("The truck is in Reverse.");
        }
        public void VehicleOff()
        {
            Console.WriteLine("The truck has been turned off.");
        }
        public void VehicleOn()
        {
            Console.WriteLine("The truck has been turned on.");
        }
    }
}

