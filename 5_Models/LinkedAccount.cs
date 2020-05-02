using _5_Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Models
{
    public class LinkedAccount
    {

        public Platform Platform { get; set; }
        public String Identifier { get; set; }
        public int AmountOfHoursPlayed { get; set; }
        public IEnumerable<Achievement> Achievements { get; set; }
        public Playstyle Playstyle { get; set; }

        public LinkedAccount() { }

        public LinkedAccount(Platform platform, String identifier, int amountOfHoursPlayed, IEnumerable<Achievement> achievements, Playstyle playstyle)
        {
            this.Platform = platform;
            this.Identifier = identifier;
            this.AmountOfHoursPlayed = amountOfHoursPlayed;
            this.Achievements = achievements;
            this.Playstyle = playstyle;
        }

    }
}
