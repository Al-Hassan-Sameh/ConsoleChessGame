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
            Player player1 = new WhitePlayer();
            Player player2 = new BlackPlayer();

            Board board = new Board();
            board = Utility.SetUpBoard(board);
            Utility.PrintBoard(board);
            string[] move  = new string[2];
            string oldPosition = "";
            string newPositon = "";
            Piece piece = new Rook("h1", '\u265C');

            while (true)
            {
                do
                {

                    move = Utility.ReadNewMove();
                    oldPosition = move[0].ToLower();
                    newPositon = move[1].ToLower();
                    while (!Utility.IsEmpty(board, oldPosition))
                    {
                        piece = board.GetPiece(oldPosition);
                    }
                }
                while (piece is not null && !Utility.IsWhitePiece(board, piece, oldPosition));
                board = player1.MovePiece(board, piece, newPositon);
                Utility.PrintBoard(board);
                do
                {
                    move = Utility.ReadNewMove();
                    oldPosition = move[0].ToLower();
                    newPositon = move[1].ToLower();
                    while (!Utility.IsEmpty(board, oldPosition))
                    {
                        piece = board.GetPiece(oldPosition);
                    }
                }
                while (piece is not null && !Utility.IsBlackPiece(board, piece, oldPosition));
                board = player2.MovePiece(board, board.GetPiece(oldPosition), newPositon);
                Utility.PrintBoard(board);
            }

        }

    }
}
