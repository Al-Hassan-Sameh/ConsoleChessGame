using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal class Knight : Piece
    {
        public Knight(string initialposition, char hexcode) 
        {
            this.HexCode = hexcode;
            //this.currentPosition = Utility.MapPosition(initialposition);
            this.CurrentPosition = initialposition;

        }
        public override bool IsValidMove(Board b, string oldPosition, string newPosition, string color)
        {
            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;

            int absDeltaX = Math.Abs(j2 - j1);
            int absDeltaY = Math.Abs(i2 - i1);

            bool movedL1 = absDeltaX == 1 && absDeltaY == 2;
            bool movedL2 = absDeltaX == 2 && absDeltaY == 1;
            if(movedL1 || movedL2)
            {
                return true;
            }
            Console.WriteLine("Invalid Move!\n\t\t\t\t\t");
            return false;
        }
    }
}
