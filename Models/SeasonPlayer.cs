using System.Collections.Generic;

namespace Survivor.Models
{
    public class SeasonPlayer
    {
       public int SeasonPlayerId {get;set;}
       public int PlayerId {get;set;}
       public int SeasonId {get;set;}

       public Player Player {get; set;}
       public Season Season {get;set;}
    }
}