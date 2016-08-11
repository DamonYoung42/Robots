using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Drone : Robot
    {
        public bool canFly; 

        public Drone(string name, bool canFly) : base(name)
        {
            this.canFly = canFly;
        }

        public override void IntroduceMyself()
        {
            if (this.awake)
            {
                Console.WriteLine("Hello, everybody! My name is {0} and I am a drone. Drones may be the coolest type of robot because some have the ability to fly!", this.name);
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
            if (this.canFly)
            {
                if (this.awake)
                {
                    Console.WriteLine("{0}: Look at me, I'm flying!!!", this.name);
                    this.batteryCharge -= 50;
                    CheckBattery();
                }
                else
                {
                    WriteAsleep();
                }
            }
            else
            {
                Console.WriteLine("{0}: Sorry, I'm not a flying drone.", this.name);
            }

        }

        public void Land()
        {
            if (this.canFly)
            {
                if (this.awake)
                {
                    Console.WriteLine("{0}: Coming in for a landing. Watch out!", this.name);
                    this.batteryCharge -= 20;
                    CheckBattery();
                }
                else
                {
                    WriteAsleep();
                }
            }
            else
            {
                Console.WriteLine("{0}: Sorry, I'm not a flying drone.", this.name);
            }

        }

        public override void CheckBattery()
        {
            if (this.batteryCharge < 5)
            {
                Console.WriteLine("{0}: Oops, I've run out of battery life and I'm going to crash!", this.name);
                this.awake = false;        
            }
        }
    }
}
