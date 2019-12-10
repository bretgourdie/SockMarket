using SockMarket.Models.BoardEntities;
using System.Collections.Generic;

namespace SockMarket.Models
{
    public class Player
    {
        public int PlayerIndex { get; set; }

        public Wallet Wallet { get; set; }

        public List<SockPile> SockPiles { get; set; }

        public Space PreviousSpace;

        public Space CurrentSpace;

        public List<Rule> Cheats { get; set; }

        public Player()
        {
            SockPiles = new List<SockPile>();
            Cheats = new List<Rule>();
        }
    }
}
