using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Robot
    {

        public string name;
        public int legs;
        public int arms;
        public List<string> languages;
        public bool canDance;
        public bool canRun;
        public bool hasWheels;
        public int batteryCharge;
        public bool awake;

        public Robot()
        {

        }

        public virtual void IntroduceMyself()
        {
            if (this.awake)
            {
                Console.WriteLine("Hello, my name is {0} and I'm a robot.", this.name);
                this.batteryCharge -= 10;
                CheckBattery();
            }

        }

        public virtual void Sleep()
        {
            if (this.awake)
            {
                Console.WriteLine("{0}: See you later. I'm going to sleep.", this.name);
                this.awake = false;
            }
            else
            {
                WriteAsleep();
            }
        }

        public virtual void Eat()
        {
            if (this.awake)
            {
                Console.WriteLine("{0}: I don't really like food because I'm a robot!", this.name);
                this.batteryCharge -= 10;
                CheckBattery();
            }

        }

        public virtual void RechargeBattery()
        {
            Console.WriteLine("{0} is recharging ...", this.name);
            this.batteryCharge = 100;
        }

        public virtual void Wake()
        {
            this.awake = true;
            CheckBattery();
        }

        public virtual void CheckBattery()
        {
            if (this.batteryCharge < 5)
            {
                RechargeBattery();
            }
        }

        public virtual void WriteAsleep()
        {
            Console.WriteLine("Recorded message from {0}: I'm currently asleep and not responding.", this.name);
        }

        public virtual void WriteBatteryCharge()
        {
            Console.WriteLine("{0}: Battery level = {1}", this.name, this.GetBatteryCharge().ToString());

        }

        public int GetBatteryCharge()
        {
            return this.batteryCharge;
        }
    }

}
