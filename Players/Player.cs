using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Pieces;

namespace ConsoleChessProject.Players
{
    internal class Player
    {

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
