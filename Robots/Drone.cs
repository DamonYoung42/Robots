using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Drone : Robot
    {
        public Drone(string name)
        {
            this.name = name;
            this.canDance = false;
            this.canRun = false;
            this.hasWheels = true;
            this.awake = true;
            this.batteryCharge = 100;
        }

        public override void Talk()
        {
            if (this.awake)
            {
                Console.WriteLine("Hello, everybody! My name is {0} and I am a drone. I may be the coolest type of robot because I can fly!", this.name);
                this.batteryCharge -= 5;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
        }

        public void Fly()
        {
            if (this.awake)
            {
                Console.WriteLine("Look at me, I'm flying!!!");
                this.batteryCharge -= 50;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
        }

        public void Land()
        {
            if (this.awake)
            {
                Console.WriteLine("Coming in for a landing. Watch out!!!");
                this.batteryCharge -= 20;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
            
        }

        public override void CheckBattery()
        {
            if (this.batteryCharge < 5)
            {
                Console.WriteLine("Oops, I've run out of battery life and I'm going to crash!");
                this.awake = false;        
            }
        }
    }
}
