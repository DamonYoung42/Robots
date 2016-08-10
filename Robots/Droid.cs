using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Droid : Robot
    {
        
        public Droid (string name)
        {
            this.name = name;
            this.hasWheels = true;
            this.languages = new List<string> {"italian","french","english","spanish","russian" };
            this.awake = true;
            this.batteryCharge = 100;
        }

        public override void Talk()
        {
            if (this.awake)
            {
                base.Talk();
                Console.WriteLine("But I'm not just any robot. I'm a droid. I'm smarter than most robots.", this.name);
                Console.WriteLine("I speak many languages, including: ");
                foreach (string lang in this.languages)
                {
                    Console.WriteLine(lang);
                }
                this.batteryCharge -= 5;
            }

        }
    }
}
