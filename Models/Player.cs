using System.Collections.Generic;


namespace Survivor.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public ICollection<Appearance> SeasonsPlayed {get; set;}
        public int TotalDays { get; set; }
        public string Gender { get; set; }
        public int CurrentAge { get; set; }
        public int GameAge { get; set; }
        public bool Winner { get; set; }
        public Player()
        {
            this.SeasonsPlayed = new HashSet<Appearance>();
        }

    }
}