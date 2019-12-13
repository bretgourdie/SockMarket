﻿using SockMarket.Models.BoardEntities;

namespace SockMarket.Models.Core
{
    public abstract class Rule
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public abstract bool ShouldRun(BoardState boardState, int runningPlayerId);

        public abstract void Run(BoardState boardState, int runningPlayerId);
    }
}