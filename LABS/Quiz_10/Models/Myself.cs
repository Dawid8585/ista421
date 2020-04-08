using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test10.Model
{
    public class Myself
    {
        public string Name { get; set; }
        public string HowWeMet { get; set; }
        public Myself Related { get; set; }
        public static Myself[] GetMyself()
        {
            Myself Wife = new Myself
            {
                Name = "Miranda",
                HowWeMet = "High School Sweet Hearts."
            };
            Myself Bestfriend1 = new Myself
            {
                Name = "Rone",
                HowWeMet = "He was yelling at me in wierd giraffe noises. He still does it after i get done with class."
            };
            Myself Bestfriend2 = new Myself
            {
                Name = "Maia",
                HowWeMet = "The Flight Deck, She the real MVP."
            };
            Myself Bestfriend3 = new Myself
            {
                Name = "Johnson",
                HowWeMet = "He kept calling me Butters. He's with the Giraffe"
            };
            Wife.Related = Bestfriend1;
            return new Myself[] { Wife, Bestfriend1, Bestfriend2, Bestfriend3, null };

        }
    }
}