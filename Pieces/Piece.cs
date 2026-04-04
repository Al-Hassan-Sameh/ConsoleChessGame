using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal abstract class Piece
    {
        public char hexCode { get; set; }
        public Tuple<int, int> currentPosition { get; set; }
        public string positionString { get; set; }

        public abstract bool IsValidMove(string oldPosition, string newPosition);
       

    }

}
