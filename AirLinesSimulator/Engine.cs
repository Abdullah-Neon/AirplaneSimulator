using System;
using System.Collections.Generic;
using System.Text;

namespace AirLinesSimulator
{
    public class Engine
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public string EngineNo { get; set; }
        public bool Accelarate { get; set; }
        public bool FuelTank { get; set; }


        public string OnEngine()
        {
            if(Accelarate)
            {
                return "Plane Engine Is On ";
            }
            Accelarate = true;
            return "Plane is ready for takeoff";
        }

        public string OffEngine()
        {
            if (!Accelarate)
            {
                return "Plane Engine Is Off ";
            }
            Accelarate = false;
            return "Plane is not ready for takeoff";
        }


        public string StartEngine()
        {
            if (FuelTank)
            {
                return "Checking Fuel Tank ";
            }
            FuelTank= true;
            return "Plane is ready for Startting Engine";
        }

        public string StopEngine()
        {
            if (!FuelTank)
            {
                return "Need To Load Fuel ";
            }
            FuelTank = false;
            return "Plane is ready for takeoff";
        }

        public string getinfo()
        {
            return $"Company: {Company} Model:{Model} EngineNo: {EngineNo} ";
        }

    }
}
