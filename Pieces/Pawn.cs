using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class Pawn : Piece
    {
        public Pawn(string initialposition, char hexcode) 
        {
            this.HexCode = hexcode;
            this.currentPosition = Utility.MapPosition(initialposition);
            this.positionString = initialposition;

        }

        public override bool IsValidMove(Board b, string oldPosition, string newPosition)
        {
            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;
            if (b.Tiles[i1, j1].Equals(b.blackPawn1.HexCode))
            {
                return i1 < i2 && j1 == j2;
            }
            return i1 > i2 && j1 == j2;
        }

    }
}
