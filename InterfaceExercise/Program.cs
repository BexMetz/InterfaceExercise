using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var civic = new Car();
            civic.Make = "Honda";
            civic.Model = "Civic";
            civic.ForgeignOrDomestic = "Foreign";
            civic.CompanyCountry = "Japan";

            var corvette = new Car();
            corvette.Make = "";
            corvette.Model = "";
            corvette.ForgeignOrDomestic = "Foreign";
            corvette.CompanyCountry = "France";
            corvette.StandardOrSport = "Sport";
            corvette.IsConvertable = true;
            corvette.DoorCount = 2;

            var tundra = new Truck();
            tundra.Make = "Toyota";
            tundra.Model = "Tundra";
            tundra.ForgeignOrDomestic = "Foreign";
            tundra.CompanyCountry = "Japan";
            tundra.TruckBedLength = 8.9;
            tundra.IsDiesel = true;

            var cyberTruck = new Truck();
            cyberTruck.Make = "Tesla";
            cyberTruck.Model = "Cyber Truck";
            cyberTruck.IsElectric = true;

            var escalade = new SUV();
            escalade.Make = "Cadillac";
            escalade.Model = "Escalade";
            escalade.PassengerCapacity = 8;
            
            var forerunner = new SUV();
            forerunner.Make = "Toyota";
            forerunner.Model = "Forerunner";
            forerunner.ForgeignOrDomestic = "Foreign";
            forerunner.CompanyCountry = "Japan";
            forerunner.AllWheelDrive = true;
            forerunner.PassengerCapacity = 8;


            Console.WriteLine($"");

            var cars = new List<Car> { civic, corvette };
            foreach(var c in cars)
            {
                Console.WriteLine($"Make: {c.Make}");
                Console.WriteLine($"Model: {c.Model}");
                Console.WriteLine($"{c.ForgeignOrDomestic} made in {c.CompanyCountry}");
                Console.WriteLine($"Convertable: {c.IsConvertable}");
                Console.WriteLine($"Model type: {c.StandardOrSport}");
                Console.WriteLine($"Electric: {c.IsElectric}");
                Console.WriteLine($"Door count: {c.DoorCount}");
                Console.WriteLine($"");
            }

            civic.VehicleOn();
            corvette.Neutral();

            Console.WriteLine($"");

            var trucks = new List<Truck> { tundra, cyberTruck };
            foreach (var t in trucks)
            {
                Console.WriteLine($"Make: {t.Make}");
                Console.WriteLine($"Model: {t.Model}");
                Console.WriteLine($"{t.ForgeignOrDomestic} made in {t.CompanyCountry}");
                Console.WriteLine($"Bed length: {t.TruckBedLength}");
                Console.WriteLine($"Diesel: {t.IsDiesel}");
                Console.WriteLine($"Electric: {t.IsElectric}");
                Console.WriteLine($"Door count: {t.DoorCount}");
                Console.WriteLine($"");
            }
            tundra.Drive();
            cyberTruck.Reverse();

            Console.WriteLine($"");

            var suvs = new List<SUV> { escalade, forerunner };
            foreach (var s in suvs)
            {
                Console.WriteLine($"Make: {s.Make}");
                Console.WriteLine($"Model: {s.Model}");
                Console.WriteLine($"{s.ForgeignOrDomestic} made in {s.CompanyCountry}");
                Console.WriteLine($"All wheel drive: {s.AllWheelDrive}");
                Console.WriteLine($"Passenger capacity: {s.PassengerCapacity}");
                Console.WriteLine($"Electric: {s.IsElectric}");
                Console.WriteLine($"Door count: {s.DoorCount}");
                Console.WriteLine($"");
            }
            escalade.Park();
            forerunner.VehicleOff();

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //x//Create 2 Interfaces called IVehicle & ICompany

            //x//Create 3 classes called Car , Truck , & SUV

            //x//In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //x//In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //x//In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //x//Now, create objects of your 3 classes and give their members values;
            //x//Creatively display and organize their values
        }
    }
}
