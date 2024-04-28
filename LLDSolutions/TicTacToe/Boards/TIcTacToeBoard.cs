using LLDSolutions.TicTacToe.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TicTacToe.Boards
{
    public class TIcTacToeBoard
    {
        public Cell[,] Cells;
        private readonly int NoOfCell;

        public TIcTacToeBoard(int noOfCell)
        {
            NoOfCell = noOfCell;
            Cells = new Cell[NoOfCell, NoOfCell];
            InitializeBoard();
        }

        public Cell[,] GetBoxes()
        {
            return Cells;
        }

        public void SetBoxes(Cell[,] cells)
        {
            Cells = cells;
        }

        public void PrintBoardStatus()
        {
            Console.WriteLine(" ----------------------");
            for (int i = 0; i < NoOfCell; i++)
            {
                for (int j = 0; j < NoOfCell; j++)
                {
                    if (Cells[i, j].getPiece() == Symbol.Empty)
                    {
                        Console.Write(" | " + "  " + " | ");
                    }
                    else
                    {
                        Console.Write(" | " + Cells[i, j].getPiece() + "  | ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine(" ----------------------");
            }
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < NoOfCell; i++)
            {
                for (int j = 0; j < NoOfCell; j++)
                {
                    Cells[i, j] = new Cell(i, j, Symbol.Empty);
                }
            }
            Console.WriteLine("GAME STARTED");
            PrintBoardStatus();
        }
    }
}
