using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            //Droid Michael = new Droid("Brian");
            Vacuum Andrew = new Vacuum("Harry");
            Drone Aero = new Drone("Aero");
            //Michael.Talk();
            Andrew.Talk();
            Andrew.Eat();
            //Michael.Sleep();
            Aero.Talk();
            Aero.Fly();
            Aero.Land();
            Console.ReadLine();
        }
    }
}
