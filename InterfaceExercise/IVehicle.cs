using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public string Make { get; set; }
		public string Model { get; set; }
		public int DoorCount { get; set; }
		public bool IsElectric { get; set; }

		public void VehicleOn();
		public void Drive();
		public void Neutral();
		public void Reverse();
		public void Park();
		public void VehicleOff();
	}
}

