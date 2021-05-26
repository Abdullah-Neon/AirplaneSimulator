using System;
using System.Collections.Generic;
using System.Text;

namespace AirLinesSimulator
{
    public class AirPlane
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool CheckPassenger { get; set; }
        public bool FeedbackMaintence { get; set; }
        public Passenger Passenger { get; set; }

        public string OnPasscheck()
        {
            if(CheckPassenger)
            {
                return "pasenger is Full....Ready for Fly";
            }
            CheckPassenger = true;
            return "No Passenger is in the waiting,,should to start engine";
        }

        public string OffPasscheck()
        {
            if (!CheckPassenger)
            {
                return "pasenger is Not Full.";
            }
            CheckPassenger = false;
            return "Need check again passenger list";
        }


        public string OnMaintence()
        {
            if(FeedbackMaintence)
            {
                return "Maintence is Ok";
            }
            FeedbackMaintence = true;
            return "No Problem Found";
        }

        public string OffMaintence()
        {
            if (!FeedbackMaintence)
            {
                return "Maintence is NOt Ok";
            }
            FeedbackMaintence = false;
            return "Problem Found";
        }





    }

}
