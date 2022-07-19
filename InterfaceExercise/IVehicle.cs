using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string VehicleType { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfWindows { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasRadio { get; set; }
        public string CompanyName { get; set; }
        public bool StillInBusiness { get; set; }


    }
}
