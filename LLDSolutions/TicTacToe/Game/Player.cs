using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TicTacToe.Game
{
    public class Player : User
    {
        private readonly Symbol symbol;

        public Player(string userName, string userId, Symbol piece) : base(userName, userId)
        {
            this.symbol = piece;
        }

        public Symbol GetSymbol()
        {
            return symbol;
        }
    }
}
