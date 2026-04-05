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
            this.blackRook1 = new Rook("a8", '\u2656');
            this.blackKnight1 = new Knight("b8",'\u2658');
            this.blackBishop1 = new Bishop("c8", '\u2657');
            this.blackQueen = new Queen("d8", '\u2655');
            this.blackKing = new King("e8", '\u2654');
            this.blackBishop2 = new Bishop("f8", '\u2654');
            this.blackKnight2 = new Knight("g8", '\u2658');
            this.blackRook2 = new Rook("h8", '\u2656');
            this.blackPawn1 = new Pawn("a7", '\u2659');
            this.blackPawn2 = new Pawn("b7", '\u2659');
            this.blackPawn3 = new Pawn("c7", '\u2659');
            this.blackPawn4 = new Pawn("d7", '\u2659');
            this.blackPawn5 = new Pawn("e7", '\u2659');
            this.blackPawn6 = new Pawn("f7", '\u2659');
            this.blackPawn7 = new Pawn("g7", '\u2659');
            this.blackPawn8 = new Pawn("h7", '\u2659');

            this.whiteRook1 = new Rook("a1", '\u265C');
            this.whiteKnight1 = new Knight("b1", '\u265E');
            this.whiteBishop1 = new Bishop("c1",'\u265D');
            this.whiteQueen = new Queen("d1", '\u265B');
            this.whiteKing = new King("e1", '\u265A');
            this.whiteBishop2 = new Bishop("f1", '\u265D');
            this.whiteKnight2 = new Knight("g1", '\u265E');
            this.whiteRook2 = new Rook("h1",'\u265C');
            this.whitePawn1 = new Pawn("a2", '\u265F');
            this.whitePawn2 = new Pawn("b2", '\u265F');
            this.whitePawn3 = new Pawn("c2", '\u265F');
            this.whitePawn4 = new Pawn("d2", '\u265F');
            this.whitePawn5 = new Pawn("e2", '\u265F');
            this.whitePawn6 = new Pawn("f2", '\u265F');
            this.whitePawn7 = new Pawn("g2", '\u265F');
            this.whitePawn8 = new Pawn("h2", '\u265F');


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
                
                if(!piece.CurrentPosition.Equals(position.ToLower()))
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
