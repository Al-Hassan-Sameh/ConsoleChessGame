using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Pieces;

namespace ConsoleChessProject.Players
{
    internal class WhitePlayer : Player
    {
        public override Board MovePiece(Board board, Piece p, string newposition)
        {
            //Piece p = board.GetPiece(oldposition);
            int m = Utility.MapPosition(p.CurrentPosition).Item1;
            int n = Utility.MapPosition(p.CurrentPosition).Item2;
            if (p.IsValidMove(board, p.CurrentPosition, newposition))
            {
                board.Tiles[m, n] = '•';
                //p.currentPosition = Utility.MapPosition(newposition);
                int i = Utility.MapPosition(newposition).Item1;
                int j = Utility.MapPosition(newposition).Item2;
                board.Tiles[i, j] = p.HexCode;
            }
            //p.currentPosition = Utility.MapPosition(newposition);
            p.CurrentPosition = newposition;
            
            return board;
        }
    }
}
