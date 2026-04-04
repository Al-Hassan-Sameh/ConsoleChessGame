using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Players;

namespace ConsoleChessProject
{
    internal class Game
    {
        public void Start()
        {
            Player player1 = new WhitePlayer();
            Player player2 = new BlackPlayer();

            Board b = new Board();
            b = Utility.SetUpBoard(b);
            Utility.PrintBoard(b);
            string[] move  = new string[2];
            string oldPosition = "";
            string newPositon = "";
            while (true)
            {
                do
                {

                    move = Utility.ReadNewMove();
                    oldPosition = move[0].ToLower();
                    newPositon = move[1].ToLower();
                }
                while (!Utility.IsWhitePiece(b, b.GetPiece(oldPosition), oldPosition));
                b = player1.MovePiece(b, b.GetPiece(oldPosition), newPositon);
                Utility.PrintBoard(b);
                do
                {
                    move = Utility.ReadNewMove();
                    oldPosition = move[0].ToLower();
                    newPositon = move[1].ToLower();
                }
                while (!Utility.IsBlackPiece(b, b.GetPiece(oldPosition), oldPosition));
                b = player2.MovePiece(b, b.GetPiece(oldPosition), newPositon);
                Utility.PrintBoard(b);
            }

        }

    }
}
