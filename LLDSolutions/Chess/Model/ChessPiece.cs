using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Chess.Model
{
    public abstract class ChessPiece
    {
        public bool IsWhite { get; set; }

        public bool IsBlack { get; set; }

        public bool IsKilled { get; set; }

        public abstract bool CanMove(ChessBoard board, Position start, Position end);
    }
}
