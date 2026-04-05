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
            //this.currentPosition = Utility.MapPosition(initialposition);
            this.CurrentPosition = initialposition;

        }

        public override bool IsValidMove(Board b, string oldPosition, string newPosition, string color)
        {
            int i1 = Utility.MapPosition(oldPosition).Item1;
            int j1 = Utility.MapPosition(oldPosition).Item2;
            int i2 = Utility.MapPosition(newPosition).Item1;
            int j2 = Utility.MapPosition(newPosition).Item2;
            int deltaX = j2 - j1;
            int deltaY = i2 - i1;
            if (b.Tiles[i1, j1].Equals(b.blackPawn1.HexCode))
            {
                bool correctBlackMove = (deltaY == 1 && deltaX == 0) || (deltaY > 0 && deltaX == deltaY);
                if (!correctBlackMove)
                {
                    Console.WriteLine("\t\t\t\t\tInvalid Move!\n\t\t\t\t\t");
                    return false;
                }
                return true;
            }
            bool correctWhiteMove = (deltaY == -1 && deltaX == 0) || (deltaY < 0 && deltaX == deltaY) ;
            if (!correctWhiteMove)
            {
                Console.WriteLine("\t\t\t\t\tInvalid Move!\n\t\t\t\t\t");
                return false;
            }
            return true;
        }

    }
}
