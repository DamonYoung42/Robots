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
            //Create Robot objects
            Droid Brian = new Droid("Brian");
            Vacuum Harry = new Vacuum("Harry");
            Drone Aero = new Drone("Aero");

            //Introduce Robots
            Brian.IntroduceMyself();
            Harry.IntroduceMyself();
            Aero.IntroduceMyself();

            //Eat
            Brian.Eat();
            Harry.Eat();
            Aero.Eat();

            //Drone Fly
            Aero.Fly();
            Aero.Land();

            //Droid Languages
            Brian.LearnLanguage("wookie");
            Brian.WriteLanguages();
            Brian.ForgetLanguage("russian");
            Brian.WriteLanguages();

            //Vacuum Clean
            Harry.CleanHouse();

            //Reading BatteryCharge
            Harry.WriteBatteryCharge();
            Brian.WriteBatteryCharge();
            Aero.WriteBatteryCharge();

            //Robots Sleep
            Brian.Sleep();
            Harry.Sleep();
            Aero.Sleep();

            //Robots Test Asleep
            Brian.IntroduceMyself();
            Harry.IntroduceMyself();
            Aero.IntroduceMyself();

            //Robots Recharge
            Brian.RechargeBattery();
            Harry.RechargeBattery();
            Aero.RechargeBattery();



            Console.ReadLine();
        }
    }
}
