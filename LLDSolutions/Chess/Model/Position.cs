using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Chess.Model
{
    public class Position
    {
        public Position(int x, int y, ChessPiece chessPiece)
        {
            this.X = x;
            this.Y = y;
            this.Piece = chessPiece;
        }

        public ChessPiece Piece { get; private set; }

        public int X { get; private set; }

        public int Y { get; private set; }
    }
}
