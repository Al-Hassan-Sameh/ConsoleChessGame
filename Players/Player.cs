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
                    Console.WriteLine("\t\t\t\t\tInvalid Move!\n\t\t\t\t\t");
                    continue;
                }



                List<Piece> blackPieces = new List<Piece> { board.blackBishop1, board.blackBishop2, board.blackRook1, board.blackRook2, board.blackKing, board.blackQueen, board.blackKnight1, board.blackKnight2,
                board.blackPawn1, board.blackPawn2, board.blackPawn3, board.blackPawn4, board.blackPawn5, board.blackPawn6, board.blackPawn7, board.blackPawn8};
                List<Piece> whitePieces = new List<Piece> { board.whiteBishop1, board.whiteBishop2, board.whiteKing, board.whiteKnight1, board.whiteKnight2, board.whiteRook1, board.whiteRook2,
                board.whiteQueen, board.whitePawn1, board.whitePawn2, board.whitePawn3, board.whitePawn4, board.whitePawn5, board.whitePawn6, board.whitePawn7, board.whitePawn8
                };
                //if (color.Equals(whitePieces) && blackPieces.Contains(piece))
                while (!Utility.IsEmpty(board, oldPosition)) // validate that player doesn't move an empty tile
                {
                    piece = board.GetPiece(oldPosition);
                    break;
                }
                if (!Utility.PieceBelongsToPlayer(board, piece, oldPosition, color)) // validate that player moves only his pieces 
                {
                    continue;
                }
                if (piece.IsValidMove(board, oldPosition, newPositon, color)) // finally, validate the move itself
                {
                    board = this.MovePiece(board, piece, newPositon);
                    break;
                }
                Console.WriteLine("\t\t\t\t\tInvalid Move!\n\t\t\t\t\t");
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
