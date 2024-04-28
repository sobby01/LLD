using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TicTacToe.Game
{
    public class Cell
    {
        int row;
        int col;
        Symbol symbol;

        public Cell(int row, int col, Symbol piece)
        {
            this.row = row;
            this.col = col;
            this.symbol = piece;
        }

        public int getRow()
        {
            return row;
        }

        public void setRow(int row)
        {
            this.row = row;
        }

        public int getCol()
        {
            return col;
        }

        public void setCol(int col)
        {
            this.col = col;
        }

        public Symbol getPiece()
        {
            return symbol;
        }

        public void setPiece(Symbol symbol)
        {
            this.symbol = symbol;
        }
    }
}
