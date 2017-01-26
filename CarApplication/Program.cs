using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create new instance from Car Class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 0.5;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            car.Accelerate();
            car.PrintData();
            car.Brake(7);
            Car.SomeProperties = 56;
            car.PrintData();


            // create another car object
            string model = "Speedster";

            Car nascar = new Car(model);
            nascar.PrintData();
            nascar.Color = "Black";
            Console.WriteLine("Color is " + nascar.Color);
        }
    }
}
