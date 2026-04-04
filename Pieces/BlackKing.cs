using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class BlackKing : Piece
    {
        public BlackKing(string initialposition)
        {
            this.hexCode = '\u2654';
            this.currentPosition = Utility.MapPosition(initialposition);
            this.positionString = initialposition;

        }
        public override bool IsValidMove(string oldPosition, string newPosition)
        {
            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;

            int deltaX = j2 - j1;
            int deltaY = i2 - i1;

            bool movedDiag = Math.Abs(deltaY) == 1 && Math.Abs(deltaX) == 1;
            bool movedFwd = deltaX == 0 && deltaY == 1;
            bool movedBwd = deltaX == 0 && deltaY == -1;
            bool movedRight = deltaX == 1 && deltaY == 0;
            bool movedLeft = deltaX == -1 && deltaY == 0;
            return movedDiag || movedFwd || movedBwd || movedRight || movedLeft;
        }
    }
}
