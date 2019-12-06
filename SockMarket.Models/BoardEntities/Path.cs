using System.Collections.Generic;

namespace SockMarket.Models.BoardEntities
{
    public class Path
    {
        public int Id { get; set; }

        public int FromSpaceId { get; set; }

        public int ToSpaceId { get; set; }

        public bool IsDoublyLinked { get; set; }
    }
}
