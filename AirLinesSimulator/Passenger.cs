using System;
using System.Collections.Generic;
using System.Text;

namespace AirLinesSimulator
{
    public class Passenger
    {
        public string PName { get; set; }
        public string PAge { get; set; }
        public string PEmail { get; set; }
        public string PAddress { get; set; }


        public string GetInfo()
        {
            return $"Passenger Name :{PName} Passenger Age:{PAge} Passenger Email:{PEmail} Passenger Address:{PAddress} ";
        }
    }
}
