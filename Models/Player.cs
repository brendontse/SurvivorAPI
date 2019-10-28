using System.Collections.Generic;

namespace Survivor.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public ICollection<SeasonPlayer> Seasons {get; set;}
        public int PlayerDays { get; set; }
        public Player()
        {
            this.Seasons = new HashSet<SeasonPlayer>();
        }

    }
}