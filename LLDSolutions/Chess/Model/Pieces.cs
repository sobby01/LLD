using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Chess.Model
{
    public class Pawn : ChessPiece
    {
        public override bool CanMove(ChessBoard board, Position start, Position end)
        {
            return true;
        }
    }

    public class Rookie : ChessPiece
    {
        public override bool CanMove(ChessBoard board, Position start, Position end)
        {
            return true;
        }
    }

    public class Bishop : ChessPiece
    {
        public override bool CanMove(ChessBoard board, Position start, Position end)
        {
            return true;
        }
    }

    public class Knight : ChessPiece
    {
        public override bool CanMove(ChessBoard board, Position start, Position end)
        {
            return true;
        }
    }

    public class Queen : ChessPiece
    {
        public override bool CanMove(ChessBoard board, Position start, Position end)
        {
            return true;
        }
    }

    public class King : ChessPiece
    {
        public override bool CanMove(ChessBoard board, Position start, Position end)
        {
            return true;
        }
    }
}
