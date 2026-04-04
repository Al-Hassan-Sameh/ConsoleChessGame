using System;
using System.Collections.Generic;
using System.Text;
using ConsoleChessProject.Pieces;

namespace ConsoleChessProject
{
    class Board
    {
        public char[,] Tiles { get; set; } = new char[8, 8];

        public Piece blackRook1;
        public Piece blackKnight1;
        public Piece blackBishop1;
        public Piece blackQueen;
        public Piece blackKing;
        public Piece blackBishop2;
        public Piece blackKnight2;
        public Piece blackRook2;
        public Piece blackPawn1;
        public Piece blackPawn2;
        public Piece blackPawn3;
        public Piece blackPawn4;
        public Piece blackPawn5;
        public Piece blackPawn6;
        public Piece blackPawn7;
        public Piece blackPawn8;

        public Piece whiteRook1;
        public Piece whiteKnight1;
        public Piece whiteBishop1;
        public Piece whiteQueen;
        public Piece whiteKing;
        public Piece whiteBishop2;
        public Piece whiteKnight2;
        public Piece whiteRook2;
        public Piece whitePawn1;
        public Piece whitePawn2;
        public Piece whitePawn3;
        public Piece whitePawn4;
        public Piece whitePawn5;
        public Piece whitePawn6;
        public Piece whitePawn7;
        public Piece whitePawn8;

        public Board()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    this.Tiles[i, j] = '•';
                }
            }
            this.blackRook1 = new BlackRook("a8");
            this.blackKnight1 = new BlackKnight("b8");
            this.blackBishop1 = new BlackBishop("c8");
            this.blackQueen = new BlackQueen("d8");
            this.blackKing = new BlackKing("e8");
            this.blackBishop2 = new BlackBishop("f8");
            this.blackKnight2 = new BlackKnight("g8");
            this.blackRook2 = new BlackRook("h8");
            this.blackPawn1 = new BlackPawn("a7");
            this.blackPawn2 = new BlackPawn("b7");
            this.blackPawn3 = new BlackPawn("c7");
            this.blackPawn4 = new BlackPawn("d7");
            this.blackPawn5 = new BlackPawn("e7");
            this.blackPawn6 = new BlackPawn("f7");
            this.blackPawn7 = new BlackPawn("g7");
            this.blackPawn8 = new BlackPawn("h7");

            this.whiteRook1 = new WhiteRook("a1");
            this.whiteKnight1 = new WhiteKnight("b1");
            this.whiteBishop1 = new WhiteBishop("c1");
            this.whiteQueen = new WhiteQueen("d1");
            this.whiteKing = new WhiteKing("e1");
            this.whiteBishop2 = new WhiteBishop("f1");
            this.whiteKnight2 = new WhiteKnight("g1");
            this.whiteRook2 = new WhiteRook("h1");
            this.whitePawn1 = new WhitePawn("a2");
            this.whitePawn2 = new WhitePawn("b2");
            this.whitePawn3 = new WhitePawn("c2");
            this.whitePawn4 = new WhitePawn("d2");
            this.whitePawn5 = new WhitePawn("e2");
            this.whitePawn6 = new WhitePawn("f2");
            this.whitePawn7 = new WhitePawn("g2");
            this.whitePawn8 = new WhitePawn("h2");


        }
        public Piece GetPiece(string position)
        {
            int i = Utility.MapPosition(position).Item1;
            int j = Utility.MapPosition(position).Item2;
            List<Piece> pieces = new List<Piece>{
                this.blackRook1, this.blackKnight1, this.blackBishop1, this.blackQueen, this.blackKing, this.blackBishop2, this.blackKnight2,
                this.blackRook2, this.blackPawn1, this.blackPawn2, this.blackPawn3, this.blackPawn4, this.blackPawn5, this.blackPawn6, 
                this.blackPawn7, this.blackPawn8, this.whiteRook1,this.whiteKnight1,this.whiteBishop1,this.whiteQueen,this.whiteKing,this.whiteBishop2,
                this.whiteKnight2,this.whiteRook2,this.whitePawn1,this.whitePawn2,this.whitePawn3,this.whitePawn4,this.whitePawn5,this.whitePawn6,
                this.whitePawn7,this.whitePawn8
            };
            foreach(var piece in pieces)
            {
                
                if(!piece.positionString.Equals(position.ToLower()))
                {
                    continue;
                }
                return piece;
            }
            Console.WriteLine("No Piece with these coordinates!");
            return null;

        }
    }
}
