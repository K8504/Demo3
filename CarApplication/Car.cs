using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // Properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperties { get; set; }

        //Default constructor
        public Car()
        {

        }


        // Constructor...
        public Car(string model)
        {
            Model = model;
        }


        // Metod to give more speed
        public void Accelerate()
        {
            Speed += 10;
        }

        //metod to slow down
        public void Brake(int value)
        {
            Speed -= value; // Speed = Speed - value;
        }

        // metod to display car datat/ properties
        public void PrintData()
        {
            Console.WriteLine("Car properties: ");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Color : " + Color);
            Console.WriteLine("- Engine : " + Engine);
            Console.WriteLine("- Speed : " + Speed);
            Console.WriteLine("- Fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- Door count : " + DoorCount);
            Console.WriteLine("- Some static properties : " + SomeProperties);
        }

        //destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }

    }// Class
}// namespace
