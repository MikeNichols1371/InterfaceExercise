using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany, IAllVehicles
    {
        // SUV Props
        public string CargoSize { get; set; }
        public bool HasThirdRowSeat { get; set; }

        // IVehicle Props
        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasRadio { get; set; }
        public string VehicleType { get; set; }

        // ICompany Props
        public string CompanyName { get; set; }
        public bool StillInBusiness { get; set; }
    }
}
