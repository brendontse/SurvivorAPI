using System.Collections.Generic;

namespace Survivor.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public string SeasonName { get; set; }
        public ICollection<SeasonPlayer> Players {get; set;}
        public Season()
        {
            this.Players = new HashSet<SeasonPlayer>();
        }
    }
}