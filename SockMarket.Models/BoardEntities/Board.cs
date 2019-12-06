using System.Collections.Generic;

namespace SockMarket.Models.BoardEntities
{
    public class Board
    {
        public int Id { get; set; }

        List<Space> Spaces { get; set; }

        List<Path> Paths { get; set; }

        List<SpaceEvent> SpaceEvents { get; set; }

        int StartSpaceId { get; set; }

        public Board()
        {
            Spaces = new List<Space>();
            Paths = new List<Path>();
            SpaceEvents = new List<SpaceEvent>();
        }
    }
}
