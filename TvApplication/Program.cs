using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.IsOn = true;
            tv.Channel = 6;
            tv.Volume = 15;
            Console.WriteLine("TV is turned On");
            Console.WriteLine("Loading...");
            Console.WriteLine("Channel has been switched to " + tv.Channel);
            Console.WriteLine("Volume: " + tv.Volume);
            


        }
    }
}
