using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Pieces;
using ConsoleChessProject.Players;

namespace ConsoleChessProject
{
    internal class Game
    {
        public void Start()
        {
            Player whitePlayer = new Player("White");
            Player blackPlayer = new Player("Black");

            Board board = new Board();
            board = Utility.SetUpBoard(board);
            Utility.PrintBoard(board);
            string[] move = new string[2];
            Piece piece = new Rook("h1", '\u265C');

            while (true)
            {
                board = whitePlayer.Play(board, piece, move, whitePlayer.Color);
                Utility.PrintBoard(board);
                board = blackPlayer.Play(board, piece, move, blackPlayer.Color);
                Utility.PrintBoard(board);
            }

        }

    }
}
