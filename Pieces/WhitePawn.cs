using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class WhitePawn : Piece
    {
        public WhitePawn(string initialposition) 
        {
            this.hexCode = '\u265F';
            this.currentPosition = Utility.MapPosition(initialposition);
            this.positionString = initialposition;

        }

        public override bool IsValidMove(string oldPosition, string newPosition)
        {
            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;
            return i1 > i2 && j1 == j2;
        }

    }
}
