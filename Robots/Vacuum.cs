using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Vacuum : Robot
    {
        public string powerSupply;

        public Vacuum(string name) : base(name)
        {
            this.powerSupply = "Electric";
        }

        public override void IntroduceMyself()
        {
            if (this.awake)
            {
                base.IntroduceMyself();
                Console.WriteLine("I'm just a dumb vacuum. I slide around all day cleaning up your messy house.", this.name);
                this.batteryCharge -= 5;
            }

            else                
            {
                WriteAsleep();
            }
        }

        public void CleanHouse()
        {
            if (this.awake)
            {
                Console.WriteLine("{0}: I'm cleaning the house right now. Please watch out.", this.name);
                this.batteryCharge -= 35;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
        }

        public override void Eat()
        {
            if (this.awake)
            {
                Console.WriteLine("{0}: Unfortunately, I don't get to choose what I eat. It's just a scrap bonanza in my house.", this.name);
                this.batteryCharge -= 10;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
        }
        public void ChangeBatterySupply()
        {
            if (this.powerSupply == "Electric")
            {
                this.powerSupply = "Battery";
            }
            else
            {
                this.powerSupply = "Electric";
            }
        }

        public string GetBatterySupply()
        {
            return this.powerSupply;
        }
    }
}
