using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany, IAllVehicles
    {
        // Car Props
        public bool HasSunRoof { get; set; }
        public bool HasTrunk { get; set; }

        //IVehicle Props
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
