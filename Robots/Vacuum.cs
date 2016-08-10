using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Vacuum : Robot
    {


        public Vacuum(string name)
        {
            this.name = name;
            this.canDance = false;
            this.canRun = false;
            this.arms = 0;
            this.legs = 0;
            this.hasWheels = true;
            this.awake = true;
            this.batteryCharge = 100;
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("I'm just a dumb vacuum. I slide around all day cleaning up your messy house.", this.name);
            this.batteryCharge -= 5;
        }

        public void CleanHouse()
        {
            if (this.awake)
            {
                Console.WriteLine("I'm cleaning the house right now. Please watch out.");
                this.batteryCharge -= 35;
                CheckBattery();
            }


        }
    }
}
