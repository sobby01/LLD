using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Chess.Constants
{
    public enum GameStatus
    {
        ACTIVE, 
        BLACK_WIN, 
        WHITE_WIN, 
        FORFEIT, 
        STALEMATE, 
        RESIGNATION
    }

    public enum AccountStatus
    {
        ACTIVE,
        CLOSED,
        CANCELED, 
        BLACKLISTED, 
        NONE
    }
}
