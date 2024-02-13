﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static chess.Piece;

/*
 * |------------
 * |00|01|
 * |10|11|
 * |
 * |
 * |
 * |
 * |
 * |
 * 
 */


namespace chess
{
    public class Board
    {
        private int pos_x { get; set; }
        private Piece saved_piece { get; set; }
        private int board_size { get; set; }
        private int pos_y { get; set; }

        public List<Piece> pieces = new List<Piece>();
        public Board()
        {
            InitPieces();
            board_size = (int)Math.Sqrt(pieces.Count);
        }
        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    this.Move(0, -1);
                    break;
                case ConsoleKey.D:
                    this.Move(0, 1);
                    break;
                case ConsoleKey.W:
                    this.Move(-1, 0);
                    break;
                case ConsoleKey.S:
                    this.Move(1, 0);
                    break;
                case ConsoleKey.Spacebar:
                    break;
            }
            DrawSelectedTile();
            HandleSelectedTile();
            //this.DrawSelectedTile();
        }

        private void Move(int dx, int dy)
        {
            this.pos_x = Math.Max(0, Math.Min(this.board_size - 1, this.pos_x + dx));
            this.pos_y = Math.Max(0, Math.Min(this.board_size - 1, this.pos_y + dy));
        }

        private void InitPieces()
        {
            // Black pieces
            for (int i = 0; i < 16; i++)
            {
                this.pieces.Add(new Piece() { White = false });
            }
            this.pieces[0].state = (int)PieceType.Rook;
            this.pieces[1].state = (int)PieceType.Knight;
            this.pieces[2].state = (int)PieceType.Bishop;
            this.pieces[3].state = (int)PieceType.Queen;
            this.pieces[4].state = (int)PieceType.King;
            this.pieces[5].state = (int)PieceType.Bishop;
            this.pieces[6].state = (int)PieceType.Knight;
            this.pieces[7].state = (int)PieceType.Rook;
            for (int i = 8; i < 16; i++)
            {
                this.pieces[i].state = (int)PieceType.Pawn;
            }
            //None squares
            for (int i = 0; i < 32; i++)
            {
                this.pieces.Add(new Piece() { state = (int)PieceType.None });
            }


            //White pieces

            for (int i = 0; i < 16; i++)
            {
                this.pieces.Add(new Piece() { White = true });
            }
            for (int i = 48; i < 56; i++)
            {
                this.pieces[i].state = (int)PieceType.Pawn;
            }

            this.pieces[56].state = (int)PieceType.Rook;
            this.pieces[57].state = (int)PieceType.Knight;
            this.pieces[58].state = (int)PieceType.Bishop;
            this.pieces[59].state = (int)PieceType.Queen;
            this.pieces[60].state = (int)PieceType.King;
            this.pieces[61].state = (int)PieceType.Bishop;
            this.pieces[62].state = (int)PieceType.Knight;
            this.pieces[63].state = (int)PieceType.Rook;
        }

        public void DrawBoard()
        {
            ConsoleColor rfg = Console.ForegroundColor; //reset foreground color
            Console.BackgroundColor = ConsoleColor.DarkGray;
            int board_size = Convert.ToInt16(Math.Sqrt(this.pieces.Count));
            for (int i = 0; i < board_size; i++)
            {
                this.DrawRow();
                for (int j = 0; j < board_size; j++)
                {
                    Console.Write("| ");
                    Console.Write(this.pieces[i * board_size + j].translateToChar());
                    Console.ForegroundColor = rfg;
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            this.DrawRow();
        }

        private void DrawRow()
        {
            Console.Write("|");
            for (int j = 0; j < 8; j++)
            {
                Console.Write("---|");
            }
            Console.WriteLine();
        }
        private void DrawSelectedTile()
        {
            this.saved_piece = this.pieces[pos_x * this.board_size + pos_y];
            this.pieces[pos_x * this.board_size + pos_y].state = (int)PieceType.Move;
        }
        private void HandleSelectedTile()
        {
            if (this.pieces[pos_x * this.board_size + pos_y].state == (int)PieceType.Move)
            {
                this.pieces[pos_x * this.board_size + pos_y] = this.saved_piece;
            }
        }


        public void Draw()
        {
            DrawBoard();
        }
    }
}