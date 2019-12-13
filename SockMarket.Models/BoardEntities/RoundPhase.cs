namespace SockMarket.Models.BoardEntities
{
    public enum RoundPhase
    {
        BeforeRoundBegins,
        RoundBegins,
        AfterRoundBegins,

        BeforePlayerTurn,
        PlayerTurn,
        AfterPlayerTurn,

        BeforeRoundEnds,
        RoundEnds,
        AfterRoundEnds
    }
}
