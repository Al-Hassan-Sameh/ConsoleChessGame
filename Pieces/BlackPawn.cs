using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class BlackPawn : Piece
    {
        public BlackPawn(string initialposition) 
        {
            this.hexCode = '\u2659';
            this.currentPosition = Utility.MapPosition(initialposition);
            this.positionString = initialposition;

        }

        public override bool IsValidMove(string oldPosition, string newPosition)
        {
            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;
            return i1 < i2 && j1 == j2;
        }

    }
}
