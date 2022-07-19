using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehiclesAvailable = new List<IAllVehicles>();


            var firstCar = new Car()
            {
                VehicleType = "Car",
                HasSunRoof = true,
                HasTrunk = true,
                NumberOfWheels = 4,
                NumberOfWindows = 6,
                NumberOfSeats = 5,
                HasRadio = true,
                CompanyName = "Nissan",
                StillInBusiness = true,
            };
            vehiclesAvailable.Add(firstCar);


            var firstTruck = new Truck();

            firstTruck.VehicleType = "Truck";
            firstTruck.FlatBedSize = "Large";
            firstTruck.TwoRowSeats = true;
            firstTruck.NumberOfWheels = 4;
            firstTruck.NumberOfWindows = 6;
            firstTruck.NumberOfSeats = 5;
            firstTruck.HasRadio = true;
            firstTruck.CompanyName = "Dodge";
            firstTruck.StillInBusiness = true;

            vehiclesAvailable.Add(firstTruck);

            var firstSUV = new SUV()
            {
                VehicleType = "Suv",
                CargoSize = "Large",
                HasThirdRowSeat = true,
                NumberOfWheels = 4,
                NumberOfWindows = 8,
                NumberOfSeats = 8,
                HasRadio = true,
                CompanyName = "Cadillac",
                StillInBusiness = true,

            };
            vehiclesAvailable.Add(firstSUV);

            Console.WriteLine("Vehicles Available: ");
            Console.WriteLine();

            foreach (var vehicle in vehiclesAvailable)
            {
                Console.WriteLine($"Vehicle type: {vehicle.VehicleType} ");
                Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
                Console.WriteLine($"Number of Windows: {vehicle.NumberOfWindows}");
                Console.WriteLine($"Number of Seats: {vehicle.NumberOfSeats}");
                Console.WriteLine($"Does this Vehicle have a Radio: {vehicle.HasRadio}");
                Console.WriteLine($"Company Name of Manufacturer: {vehicle.CompanyName}");
                Console.WriteLine($"Is the Manufacturer still in business: {vehicle.StillInBusiness}");
                Console.WriteLine();
            }

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
