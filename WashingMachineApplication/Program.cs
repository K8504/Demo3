using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.IsOn = true;
            washer.Spinning = true;
            washer.SpinningSpeed = 800;
            washer.WashingTime = 1.20;
            washer.StartEnd();
            Console.WriteLine("Spinning is On");
            Console.WriteLine("Spinning speed " + washer.SpinningSpeed);
            Console.WriteLine("Washing time " + washer.WashingTime + " hours");
        } //Github
    }
}
