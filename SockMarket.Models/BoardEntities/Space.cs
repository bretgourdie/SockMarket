using System.Collections.Generic;

namespace SockMarket.Models.BoardEntities
{
    public class Space
    {
        public int Id { get; set; }

        public List<int> SpaceEventIds { get; set; }

        public virtual List<SpaceEvent> SpaceEvents { get; set; }

        public Point2D Point { get; set; }

        public Space()
        {
            SpaceEventIds = new List<int>();
            SpaceEvents = new List<SpaceEvent>();
        }
    }
}
