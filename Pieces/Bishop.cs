using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class Bishop : Piece
    {

        public Bishop(string initialposition, char hexcode) 
        {
            this.HexCode = hexcode;
            //this.currentPosition = Utility.MapPosition(initialposition);
            this.CurrentPosition = initialposition;
        }

        public override bool IsValidMove(Board b, string oldPosition, string newPosition)
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
                if (movedDiag)
                {
                    return true;
                }
                
            }
            Console.Write("Invalid Move!\n\t\t\t\t\t");
            return false;
        }

    }
}
