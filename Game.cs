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
            Player whitePlayer = new Player();
            Player blackPlayer = new Player();

            Board board = new Board();
            board = Utility.SetUpBoard(board);
            Utility.PrintBoard(board);
            string[] move  = new string[2];
            string oldPosition = "";
            string newPositon = "";
            Piece piece = new Rook("h1", '\u265C');

            while (true)
            {
                while (piece is not null)
                {

                    move = Utility.ReadNewMove();
                    if (move.Length < 4)
                    {
                        Console.WriteLine("\t\t\t\t\tIt seems like you have a typo!");
                        continue;
                    }
                    oldPosition = move[0].ToLower();
                    newPositon = move[1].ToLower();
                    if(!Utility.IsValidPosition(oldPosition) && !Utility.IsValidPosition(newPositon))
                    {
                        continue; 
                    }
                    while (!Utility.IsEmpty(board, oldPosition))
                    {
                        piece = board.GetPiece(oldPosition);
                        break;
                    }
                    if(!Utility.IsWhitePiece(board, piece, oldPosition))
                    {
                        continue;
                    }
                    if(piece.IsValidMove(board, oldPosition, newPositon))
                    {
                        board = whitePlayer.MovePiece(board, piece, newPositon);
                        break;
                    }
                    continue;
                }
                Utility.PrintBoard(board);
                while (piece is not null)
                {

                    move = Utility.ReadNewMove();
                    if (move.Length < 4)
                    {
                        Console.WriteLine("\t\t\t\t\tIt seems like you have a typo!");
                        continue;
                    }
                    oldPosition = move[0].ToLower();
                    newPositon = move[1].ToLower();
                    if (!Utility.IsValidPosition(oldPosition) && !Utility.IsValidPosition(newPositon))
                    {
                        continue;
                    }
                    while (!Utility.IsEmpty(board, oldPosition))
                    {
                        piece = board.GetPiece(oldPosition);
                        break;
                    }
                    if (!Utility.IsBlackPiece(board, piece, oldPosition))
                    {
                        continue;
                    }
                    if (piece.IsValidMove(board, oldPosition, newPositon))
                    {
                        board = blackPlayer.MovePiece(board, piece, newPositon);
                        break;
                    }
                    continue;
                }
                Utility.PrintBoard(board);
            }

        }

    }
}
