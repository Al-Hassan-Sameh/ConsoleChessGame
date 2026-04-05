using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleChessProject.Pieces
{
    internal abstract class Piece
    {
        public char HexCode { get; set; }
        //public Tuple<int, int> currentPosition { get; set; }
        public string CurrentPosition { get; set; }

        public abstract bool IsValidMove(Board b, string oldPosition, string newPosition, string color);
       

    }

}
