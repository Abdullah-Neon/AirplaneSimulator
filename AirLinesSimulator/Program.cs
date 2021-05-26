using System;

namespace AirLinesSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            passenger.PName = "Abdullah";
            passenger.PAge = "10";
            passenger.PEmail = "neon@gmail.com";
            passenger.PAddress = "Dhaka,Bangladesh";


           

            Console.WriteLine("Passenger Information :"+" " + passenger.GetInfo());


            AirPlane airplane = new AirPlane();
            Console.WriteLine(airplane.Brand = "Air Plane Name : EMIRATES AIRLINES ");
            Console.WriteLine(airplane.Model = "Air Plane Model : BOWING 777");
            Console.WriteLine(airplane.Color = "Air Plane Color :WHITE");
            Console.WriteLine(airplane.OnPasscheck());
            Console.WriteLine(airplane.OffPasscheck());
            Console.WriteLine(airplane.OnMaintence());
            Console.WriteLine(airplane.OffMaintence());


            Engine airengine = new Engine();
            airengine.Company = "XYZ";
            airengine.Model = "E123";
            airengine.EngineNo = "5372";
            Console.WriteLine(airengine.OnEngine());
            Console.WriteLine(airengine.OffEngine());
            Console.WriteLine(airengine.StartEngine());
            Console.WriteLine(airengine.StopEngine());

            Console.WriteLine(airengine.getinfo());
            




            Console.WriteLine();
         
            
            
            
            
        
            







            Console.ReadKey();
        }
    }
}
