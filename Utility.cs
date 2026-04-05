using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ConsoleChessProject.Pieces;
using ConsoleChessProject.Players;

namespace ConsoleChessProject
{
    internal static class Utility
    {

        public static bool IsEmpty(Board board, string position)
        {
            int i = MapPosition(position).Item1;
            int j = MapPosition(position).Item2;
            return board.Tiles[i, j] == '•';
        }

        public static bool SelfKill(Board board, string newPosition, string color) // validate if player tries to kill their pieces by his own pieces
        {
            List<Piece> blackPieces = new List<Piece> { board.blackBishop1, board.blackBishop2, board.blackRook1, board.blackRook2, board.blackKing, board.blackQueen, board.blackKnight1, board.blackKnight2,
            board.blackPawn1, board.blackPawn2, board.blackPawn3, board.blackPawn4, board.blackPawn5, board.blackPawn6, board.blackPawn7, board.blackPawn8};
            List<Piece> whitePieces = new List<Piece> { board.whiteBishop1, board.whiteBishop2, board.whiteKing, board.whiteKnight1, board.whiteKnight2, board.whiteRook1, board.whiteRook2,
            board.whiteQueen, board.whitePawn1, board.whitePawn2, board.whitePawn3, board.whitePawn4, board.whitePawn5, board.whitePawn6, board.whitePawn7, board.whitePawn8
            };

            if (color.Equals("White") && whitePieces.Contains(board.GetPiece(newPosition)))
            {
                return true;
            }
            if (color.Equals("Black") && blackPieces.Contains(board.GetPiece(newPosition)))
            {
                return true;
            }
            return false;
        }
        public static bool PieceBelongsToPlayer(Board board, Piece p, string position, string color)
        {
            int i = MapPosition(position).Item1;
            int j = MapPosition(position).Item2;
            List<Piece> blackPieces = new List<Piece> { board.blackBishop1, board.blackBishop2, board.blackRook1, board.blackRook2, board.blackKing, board.blackQueen, board.blackKnight1, board.blackKnight2,
            board.blackPawn1, board.blackPawn2, board.blackPawn3, board.blackPawn4, board.blackPawn5, board.blackPawn6, board.blackPawn7, board.blackPawn8};
            List<Piece> whitePieces = new List<Piece> { board.whiteBishop1, board.whiteBishop2, board.whiteKing, board.whiteKnight1, board.whiteKnight2, board.whiteRook1, board.whiteRook2,
            board.whiteQueen, board.whitePawn1, board.whitePawn2, board.whitePawn3, board.whitePawn4, board.whitePawn5, board.whitePawn6, board.whitePawn7, board.whitePawn8
            };
            if (color.Equals("Black"))
            {
                foreach (var piece in blackPieces)
                {
                    if(piece.HexCode == p.HexCode)
                    {
                        return true;
                    }
                }
            }
            else if (color.Equals("White"))
            {
                foreach (var piece in whitePieces)
                {
                    if (piece.HexCode == p.HexCode)
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("\t\t\t\t\tIt's not your piece!\n\t\t\t\t\t");
            return false;
        }

        public static string[] ReadNewMove()
        {
            Console.Write("\t\t\t\t\t");
            string input = Console.ReadLine();
            string positions = input.Replace(" ", "");
            if(input.Equals(""))
            {
                return new string[2] { "", "" };
            }
            string oldPosition = positions[0..2];
            string newPosition = positions[2..];

            return new string[2] { oldPosition, newPosition };
        }

        public static bool IsValidPosition(string position)
        {
            if (position.Equals(""))
            {
                return false;
            }
            int[] validRows = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
            char[] validColumns = new char[8] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            int row = (int)char.GetNumericValue(position[1]);
            char column = Convert.ToChar(position[0]);
            bool validRow = validRows.Contains(row);
            bool validColumn = validColumns.Contains(column);
                
            return validRow && validColumn;
        }
        public static Board SetUpBoard(Board b)
        {
            b = PlacePiece(b, b.blackRook1);
            b = PlacePiece(b, b.blackRook2);
            b = PlacePiece(b, b.whiteBishop1);
            b = PlacePiece(b, b.whiteBishop2);
            b = PlacePiece(b, b.whiteKing);
            b = PlacePiece(b, b.blackKing);
            b = PlacePiece(b, b.whiteQueen);
            b = PlacePiece(b, b.whiteRook1);
            b = PlacePiece(b, b.whiteRook2);
            b = PlacePiece(b, b.blackBishop1);
            b = PlacePiece(b, b.blackBishop2);
            b = PlacePiece(b, b.blackQueen);
            b = PlacePiece(b, b.whiteKnight1);
            b = PlacePiece(b, b.whiteKnight2);
            b = PlacePiece(b, b.blackKnight1);
            b = PlacePiece(b, b.blackKnight2);
            b = PlacePiece(b, b.blackPawn1);
            b = PlacePiece(b, b.blackPawn2);
            b = PlacePiece(b, b.blackPawn3);
            b = PlacePiece(b, b.blackPawn4);
            b = PlacePiece(b, b.blackPawn5);
            b = PlacePiece(b, b.blackPawn6);
            b = PlacePiece(b, b.blackPawn7);
            b = PlacePiece(b, b.blackPawn8);
            b = PlacePiece(b, b.whitePawn1);
            b = PlacePiece(b, b.whitePawn2);
            b = PlacePiece(b, b.whitePawn3);
            b = PlacePiece(b, b.whitePawn4);
            b = PlacePiece(b, b.whitePawn5);
            b = PlacePiece(b, b.whitePawn6);
            b = PlacePiece(b, b.whitePawn7);
            b = PlacePiece(b, b.whitePawn8);

            return b;
        }
        public static Board PlacePiece(Board board, Piece piece)
        {
            int i = Utility.MapPosition(piece.CurrentPosition).Item1;
            int j = Utility.MapPosition(piece.CurrentPosition).Item2;
            board.Tiles[i, j] = piece.HexCode;
            return board;
        }
        public static void PrintBoard(Board board)
            {
            Console.WriteLine("\t\t\t\t\t----------------------------------------");
            for(int i = 0; i < 8; i++)
            {
                Console.Write($"\t\t\t\t\t{8 - i}");
                for (int j = 0; j < 8; j++)
                {
                    if (board.Tiles[i, j].Equals('\u265F'))
                    {
                        Console.Write("  " + board.Tiles[i, j] + " ");
                        continue;
                    }
                    //else 
                    //{
                        Console.Write("  " + board.Tiles[i, j] + "  ");
                    //}

                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("\t\t\t\t\t   a    b    c    d    e    f    g    h");
            Console.WriteLine("\t\t\t\t\t----------------------------------------");
            //Console.Write("\t\t\t\t\t");
        }


        public static Tuple<int, int> MapPosition(string position)
        {
            int x, y;
            if (position is not null)
            {
                char[] chars = position.ToCharArray();
                x = 8 - (int)char.GetNumericValue(chars[1]);
                switch (char.ToLower(chars[0]))
                {
                    case 'a': y = 0; return new Tuple<int, int>(x, y);
                    case 'b': y = 1; return new Tuple<int, int>(x, y);
                    case 'c': y = 2; return new Tuple<int, int>(x, y);
                    case 'd': y = 3; return new Tuple<int, int>(x, y);
                    case 'e': y = 4; return new Tuple<int, int>(x, y);
                    case 'f': y = 5; return new Tuple<int, int>(x, y);
                    case 'g': y = 6; return new Tuple<int, int>(x, y);
                    case 'h': y = 7; return new Tuple<int, int>(x, y);

                }
            }
            return new Tuple<int, int>(-1, -1);
        }
    }
}
