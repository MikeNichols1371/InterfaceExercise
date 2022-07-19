using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany, IAllVehicles
    {
        // Truck Props
        public string FlatBedSize { get; set; }
        public bool TwoRowSeats { get; set; }

        // IVehicle Props
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasRadio { get; set; }
         
        // ICompany Props
        public string CompanyName { get; set; }
        public bool StillInBusiness { get; set; }
        public string VehicleType { get; set; }
    }
}
