using System.Collections.Generic;

namespace SockMarket.Models.BoardEntities
{
    public class Item
    {
        public int Id { get; set; }

        public List<Rule> RulesToAdd { get; set; }

        public List<Rule> RulesToRemove { get; set; }
    }
}
