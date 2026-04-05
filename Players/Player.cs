using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;
using ConsoleChessProject.Pieces;

namespace ConsoleChessProject.Players
{
    internal class Player
    {
        public string Color { get; set; }

        public Player(string color)
        {
            this.Color = color;
        }

        public Board Play(Board board, Piece piece, string[] move, string color)
        {
            string oldPosition = "";
            string newPositon = "";
            while (piece is not null)
            {

                move = Utility.ReadNewMove();
                if (string.Concat(move).Length < 4)  // exclude incorrect moves
                {
                    Console.WriteLine("\t\t\t\t\tIt seems like you have a typo!");
                    continue;
                }
                oldPosition = move[0].ToLower();
                newPositon = move[1].ToLower();
                if (!Utility.IsValidPosition(oldPosition) && !Utility.IsValidPosition(newPositon)) // validate positions
                {
                    continue;
                }
                while (!Utility.IsEmpty(board, oldPosition)) // validate that player doesn't move an empty tile
                {
                    piece = board.GetPiece(oldPosition);
                    break;
                }
                if (!Utility.PieceBelongsToPlayer(board, piece, oldPosition, color)) // validate that player moves only his pieces 
                {
                    continue;
                }
                if (piece.IsValidMove(board, oldPosition, newPositon)) // finally, validate the move itself
                {
                    board = this.MovePiece(board, piece, newPositon);
                    break;
                }
                continue;
            }
            return board;
        }
        public Board MovePiece(Board board, Piece p, string newposition)
        {
            int m = Utility.MapPosition(p.CurrentPosition).Item1;
            int n = Utility.MapPosition(p.CurrentPosition).Item2;
            board.Tiles[m, n] = '•';
            int i = Utility.MapPosition(newposition).Item1;
            int j = Utility.MapPosition(newposition).Item2;
            board.Tiles[i, j] = p.HexCode;
            
            p.CurrentPosition = newposition;

            return board;
        }
    }
}
