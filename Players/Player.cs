using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Pieces;

namespace ConsoleChessProject.Players
{
    internal abstract class Player
    {

        public abstract Board MovePiece(Board board, Piece piece, string newposition);
    }
}
