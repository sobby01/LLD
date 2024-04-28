using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TicTacToe.Game
{
    public class User
    {
        private string userName;
        public readonly string UserId;

        public User(string userName, string userId)
        {
            this.userName = userName;
            UserId = userId;
        }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public string GetUserId()
        {
            return UserId;
        }
    }
}
