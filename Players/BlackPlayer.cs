using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Pieces;

namespace ConsoleChessProject.Players
{
    internal class BlackPlayer : Player
    {
        public override Board MovePiece(Board board, Piece p, string newposition)
        {
            //Piece p = board.GetPiece(oldposition);
            int m = Utility.MapPosition(p.positionString).Item1;
            int n = Utility.MapPosition(p.positionString).Item2;
            if (p.IsValidMove(p.positionString, newposition))
            {
                board.Tiles[m, n] = '•';
                p.currentPosition = Utility.MapPosition(newposition);
                int i = Utility.MapPosition(newposition).Item1;
                int j = Utility.MapPosition(newposition).Item2;
                board.Tiles[i, j] = p.hexCode;
            }
            p.currentPosition = Utility.MapPosition(newposition);
            p.positionString = newposition;

            return board;
        }
    }
}
