using System.Collections.Generic;

namespace SockMarket.Models.BoardEntities
{
    public class Board
    {
        public int Id { get; set; }

        public List<Space> Spaces { get; set; }

        public List<Path> Paths { get; set; }

        public List<SpaceEvent> SpaceEvents { get; set; }

        public List<Rule> InitialRules { get; set; }

        public List<Item> AvailableItems { get; set; }

        int StartSpaceId { get; set; }

        public Board()
        {
            AvailableItems = new List<Item>();
            InitialRules = new List<Rule>();
            Paths = new List<Path>();
            SpaceEvents = new List<SpaceEvent>();
            Spaces = new List<Space>();
        }
    }
}
