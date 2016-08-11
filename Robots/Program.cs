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
            Droid Brian = new Droid("Brian");
            Vacuum Harry = new Vacuum("Harry");
            Drone Aero = new Drone("Aero");
            //Michael.Talk();
            //Andrew.Talk();
            //Andrew.Eat();
            ////Michael.Sleep();
            //Aero.Talk();
            //Aero.Fly();
            //Aero.Land();

            Brian.Talk();
            Brian.WriteLanguages();
            Brian.LearnLanguage("wookie");
            Brian.WriteLanguages();
            Brian.ForgetLanguage("russian");
            Brian.WriteLanguages();


            Console.ReadLine();
        }
    }
}
