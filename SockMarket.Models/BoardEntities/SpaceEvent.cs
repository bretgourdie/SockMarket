using System;

namespace SockMarket.Models.BoardEntities
{
    public class SpaceEvent
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool DecrementsMoveCounter { get; set; }

        public bool EventOccursOnPass { get; set; }

        public bool EventOccursOnLanding { get; set; }
    }
}
