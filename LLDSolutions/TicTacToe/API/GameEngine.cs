using LLDSolutions.TicTacToe.Boards;
using LLDSolutions.TicTacToe.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TicTacToe.API
{
    public class Game
    {
        private readonly TIcTacToeBoard board;
        private readonly Player[] players;
        private Player currentPlayer;
        private TicTacToe.Game.GameStatus gameStatus;
        private readonly int cellCount = 3;
        private readonly int noOfPlayers = 2;
        private readonly int[] arrRow = new int[3];
        private readonly int[] arrCol = new int[3];
        private int drl = 0;
        private int dlr = 0;

        public Game(Player p1, Player p2)
        {
            players = new Player[noOfPlayers];
            players[0] = p1;
            players[1] = p2;
            board = new TIcTacToeBoard(cellCount);
            currentPlayer = players[0];
            gameStatus = GameStatus.PLAYING;
        }

        public GameStatus GetGameStatus()
        {
            return gameStatus;
        }

        public void SetGameStatus(GameStatus gameStatus)
        {
            this.gameStatus = gameStatus;
        }

        public bool Play(int row, int col)
        {
            if (GameStatus.PLAYING == gameStatus)
            {
                if (IsValidMove(row, col))
                {
                    board.Cells[row, col].setPiece(currentPlayer.GetSymbol());

                    if (CheckIfWon(row, col))
                    {
                        board.PrintBoardStatus();
                        return false;
                    }
                    else if (CheckIfDraw(row, col))
                    {
                        board.PrintBoardStatus();
                        return false;
                    }

                    gameStatus = GameStatus.PLAYING;
                    ChangeTurn();
                    board.PrintBoardStatus();
                    return true;
                }

                Console.WriteLine(currentPlayer.GetUserName() + " Please put a valid move!");
                board.PrintBoardStatus();
                return false;
            }
            else
            {
                Console.WriteLine(currentPlayer.GetUserName() + " has already won the game! GAME IS OVER");
                board.PrintBoardStatus();
                return false;
            }
        }

        private bool CheckIfDraw(int row, int col)
        {
            if (drl > cellCount || dlr > cellCount || arrCol[col] > cellCount || arrRow[row] > cellCount
                || -cellCount > arrRow[row] || drl < -cellCount || dlr < -cellCount || arrCol[col] < -cellCount)
            {
                gameStatus = GameStatus.DRAW;
                Console.WriteLine("Game has been finished with status DRAW!!");
                return true;
            }

            return false;
        }

        private void ChangeTurn()
        {
            currentPlayer = currentPlayer.UserId.Equals(players[0].UserId) ? players[1] : players[0];
        }

        private bool CheckIfWon(int row, int col)
        {
            if (currentPlayer.UserId.Equals(players[0].UserId))
            {
                if (row == col)
                {
                    dlr++;
                }
                else if (row + col == cellCount - 1)
                {
                    drl++;
                }

                arrRow[row] = arrRow[row] + 1;
                arrCol[col] = arrCol[col] + 1;
                if (arrRow[row] == cellCount || arrCol[col] == cellCount || drl == cellCount || dlr == cellCount)
                {
                    gameStatus = GameStatus.WON;
                    Console.WriteLine(currentPlayer.GetUserName() + " has won the Game!!");
                    return true;
                }
            }
            else
            {
                if (row == col)
                {
                    dlr--;
                }
                else if (row + col == -(cellCount - 1))
                {
                    drl--;
                }

                arrRow[row] = arrRow[row] - 1;
                arrCol[col] = arrCol[col] - 1;
                if (arrRow[row] == -cellCount || arrCol[col] == -cellCount || drl == -cellCount || dlr == -cellCount)
                {
                    gameStatus = GameStatus.WON;
                    Console.WriteLine(currentPlayer.GetUserName() + " has won the Game!!");
                    return true;
                }
            }

            return false;
        }

        private bool IsValidMove(int row, int col)
        {
            return row < cellCount && col < cellCount && board.Cells[row, col] != null;
        }
    }
}
