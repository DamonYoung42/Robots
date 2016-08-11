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
            this.languages = new List<string> {"italian","french","droidspeak", "shyriiwook", "jawaese", "english", "spanish", "russian" };
            this.awake = true;
            this.batteryCharge = 100;
        }

        public override void Talk()
        {
            if (this.awake)
            {
                base.Talk();
                Console.WriteLine("But I'm not just any robot. I'm a droid. I'm smarter than most robots.", this.name);

                this.batteryCharge -= 5;
            }

        }

        public void LearnLanguage(string language)
        {
            if (this.awake)
            {
                this.languages.Add(language);
                Console.WriteLine("I just learned how to speak in {0}", language);
                this.batteryCharge -= 40;
                CheckBattery();
            }
        }

        public void ForgetLanguage(string language)
        {
            if (this.awake)
            {
                this.languages.Remove(language);
                Console.WriteLine("I just forgot all of my {0}", language);
                this.batteryCharge -= 30;
                CheckBattery();
            }
        }

        public string GetLanguages()
        {
      
                 return string.Join("/", this.languages);
            
        }

        public void WriteLanguages()
        {
            Console.WriteLine("I speak many languages, including {0}: ", this.GetLanguages());
        }
    }
}
