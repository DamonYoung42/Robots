using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Droid : Robot
    {
        public List<string> languages;

        public Droid (string name) : base(name)
        {
            this.languages = new List<string> {"italian","french","droidspeak", "shyriiwook", "jawaese", "english", "spanish", "russian" };

        }

        public override void IntroduceMyself()
        {
            if (this.awake)
            {
                base.IntroduceMyself();
                Console.WriteLine("But I'm not just any robot. I'm a droid. I'm smarter than most robots.");
                WriteLanguages();
                this.batteryCharge -= 5;
            }
            else
            {
                WriteAsleep();
            }

        }

        public void LearnLanguage(string language)
        {
            if (this.awake)
            {
                this.languages.Add(language);
                Console.WriteLine("{0}: I just learned how to speak in {1}", this.name, language);
                this.batteryCharge -= 40;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
        }

        public void ForgetLanguage(string language)
        {
            if (this.awake)
            {
                this.languages.Remove(language);
                Console.WriteLine("{0}: I just forgot all of my {1}", this.name, language);
                this.batteryCharge -= 30;
                CheckBattery();
            }
            else
            {
                WriteAsleep();
            }
        }

        protected string GetLanguages()
        {
      
                 return string.Join(", ", this.languages);
            
        }

        public void WriteLanguages()
        {
            Console.WriteLine("I speak many languages, including {0}. ", this.GetLanguages());
        }
    }
}
