using System.Collections.Generic;

namespace SockMarket.Models.BoardEntities
{
    public class BoardState
    {
        public List<Rule> RulesInPlay { get; set; }
        
        public List<Player> Players { get; set; }

        public BoardState()
        {
            RulesInPlay = new List<Rule>();
            Players = new List<Player>();
        }
    }
}
