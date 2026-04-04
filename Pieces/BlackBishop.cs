using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class BlackBishop : Piece
    {
        public BlackBishop(string initialposition) 
        {
            this.hexCode = '\u2657';
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
            bool validDeltaX = Enumerable.Range(0, 8).Contains(Math.Abs(deltaX));
            bool validDeltaY = Enumerable.Range(0, 8).Contains(Math.Abs(deltaY));
            if (validDeltaX && validDeltaY)
            {
                bool movedDiag = Math.Abs(deltaY) == Math.Abs(deltaX);
                List<bool> bools = new List<bool> { movedDiag};
                foreach (var move in bools)
                {
                    if (move)
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("Invalid Move!");
            return false;
        }

    }
}
