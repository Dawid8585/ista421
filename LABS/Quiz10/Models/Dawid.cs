using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz10.Models
{
    public class Dawid
    {
        public string Name { get; set; }
        public string Whoarewe { get; set; }
        public Dawid Related { get; set; }
        public static Dawid[] GetMyself()
        {
            Dawid ME = new Dawid
            {
                Name = "Dawid",
                Whoarewe = "Thats me hahahaha.",
                
            };
            Dawid Family1 = new Dawid
            {
                Name = "Robert",
                Whoarewe = "That's my dad he was born in Poland during the USSR."
            };
            Dawid Family2 = new Dawid
            {
                Name = "Ewa",
                Whoarewe = "That's my mom her legal last name is Perkowska not Perkowski (it's a Polish thing)."
            };
            Dawid Family3 = new Dawid
            {
                Name = "Patryk",
                Whoarewe = "He's my brother, I say im cooler but secretly we're both cool."
            };
            
            return new Dawid[] { ME, Family1, Family2, Family3};
        }
    }
}
