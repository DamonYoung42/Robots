using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    class RobotSimulation
    {
        public RobotSimulation()
        {

        }

        public void RunSimulation()
        {
            //Create Robot objects
            Droid Brian = new Droid("Brian");
            Vacuum Harry = new Vacuum("Harry","Electric");
            Drone Aero = new Drone("Aero", true);
            Drone NoFlyZone = new Drone("NoFlyZone", false);

            //Eat
            Brian.Eat();
            Harry.Eat();
            Aero.Eat();

            //Drone Fly
            Aero.Fly();
            NoFlyZone.Fly();
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
            NoFlyZone.WriteBatteryCharge();

            //Vacuum PowerSupply
            Harry.ChangeBatterySupply();

            //Robots Sleep
            Brian.Sleep();
            Harry.Sleep();
            Aero.Sleep();
            NoFlyZone.Sleep();

            //Robots Test Asleep
            Brian.IntroduceMyself();
            Harry.IntroduceMyself();
            Aero.IntroduceMyself();
            NoFlyZone.IntroduceMyself();

            Brian.Wake();
            Harry.Wake();
            Aero.Wake();
            NoFlyZone.Wake();

            //Robots Recharge
            Brian.RechargeBattery();
            Harry.RechargeBattery();
            Aero.RechargeBattery();


            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }

    }
}
