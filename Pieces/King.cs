using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class King : Piece
    {
        public King(string initialposition, char hexcode)
        {
            this.HexCode = hexcode;
            //this.currentPosition = Utility.MapPosition(initialposition);
            this.CurrentPosition = initialposition;

        }
        public override bool IsValidMove(Board board, string oldPosition, string newPosition, string color)
        {

            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;

            List<Piece> blackPieces = new List<Piece> { board.blackBishop1, board.blackBishop2, board.blackRook1, board.blackRook2, board.blackKing, board.blackQueen, board.blackKnight1, board.blackKnight2,
            board.blackPawn1, board.blackPawn2, board.blackPawn3, board.blackPawn4, board.blackPawn5, board.blackPawn6, board.blackPawn7, board.blackPawn8};
            List<Piece> whitePieces = new List<Piece> { board.whiteBishop1, board.whiteBishop2, board.whiteKing, board.whiteKnight1, board.whiteKnight2, board.whiteRook1, board.whiteRook2,
            board.whiteQueen, board.whitePawn1, board.whitePawn2, board.whitePawn3, board.whitePawn4, board.whitePawn5, board.whitePawn6, board.whitePawn7, board.whitePawn8
            };

            if(Utility.SelfKill(board, newPosition, color))
            {
                return false;
            }
            int deltaX = j2 - j1;
            int deltaY = i2 - i1;

            bool movedDiag = Math.Abs(deltaY) == 1 && Math.Abs(deltaX) == 1;
            bool movedFwd = deltaX == 0 && deltaY == 1;
            bool movedBwd = deltaX == 0 && deltaY == -1;
            bool movedRight = deltaX == 1 && deltaY == 0;
            bool movedLeft = deltaX == -1 && deltaY == 0;
            if( movedDiag || movedFwd || movedBwd || movedRight || movedLeft)
            {
                return true;
            }
            Console.WriteLine("Invalid Move!\n\t\t\t\t\t");
            return false;

        }
    }
}
