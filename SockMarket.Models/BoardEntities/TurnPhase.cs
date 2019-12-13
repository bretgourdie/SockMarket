namespace SockMarket.Models.BoardEntities
{
    public enum TurnPhase
    {
        BeforeTurnBegins,
        TurnBegins,
        AfterTurnBegins,

        BeforeRoll,
        Roll,
        AfterRoll,

        BeforeMovement,
        Movement,
        AfterMovement,

        BeforeSpaceAction,
        SpaceAction,
        AfterSpaceAction,

        BeforeTurnEnds,
        TurnEnds,
        AfterTurnEnds
    }
}
