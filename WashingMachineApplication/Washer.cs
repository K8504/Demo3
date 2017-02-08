using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingMachineApplication
{
    class Washer
    {
        public bool IsOn { get; set; }
        public bool Wash { get; set; }
        public bool Spinning { get; set; }
        public int SpinningSpeed { get; set; }
        public double WashingTime { get; set; }
        

        public void StartEnd()
        {
            Console.WriteLine("Washer is On ");
        }
    }
}
