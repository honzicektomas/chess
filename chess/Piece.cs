using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess
{
    public class Piece
    {
        public int state { get; set; }
        public bool is_selected = false;
        ConsoleColor recentForegroundColor = Console.ForegroundColor;
        ConsoleColor recentBackgroundColor = Console.BackgroundColor;
        public char[,] location = new char[8, 8];

        public bool White;
        public enum PieceType { None, King, Pawn, Knight, Bishop, Rook, Queen/*, Move*/}
        private bool isSelected(bool is_empty=false)
        {
            if (is_selected)
            {
                Console.ForegroundColor = recentForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if(is_empty && is_selected)
            {
                Console.BackgroundColor = recentBackgroundColor;
                Console.BackgroundColor = ConsoleColor.Red;
            }
            return is_selected;
        }

        public char translateToChar()
        {
            if (White)
            {
                Console.BackgroundColor = recentBackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = recentForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                
                switch (state)
                {
                    case (int)PieceType.King:
                        //    Console.ForegroundColor = recentForegroundColor;
                        //    Console.ForegroundColor = ConsoleColor.Blue;if (is_selected)
                        isSelected();
                        return 'K';
                    case (int)PieceType.Pawn:
                        isSelected();
                        return 'P';
                    case (int)PieceType.Knight:
                        isSelected();
                        return 'N';
                    case (int)PieceType.Bishop:
                        isSelected();
                        return 'B';
                    case (int)PieceType.Rook:
                        isSelected();
                        return 'R';
                    case (int)PieceType.Queen:
                        isSelected();
                        return 'Q';
                    case (int)PieceType.None:
                        isSelected(true);
                        
                        return ' ';
                }
            }
            else
            {
                Console.ForegroundColor = recentForegroundColor;
                Console.ForegroundColor = ConsoleColor.Black;
                switch (state)
                {
                    case (int)PieceType.King:
                        isSelected();
                        return 'k';
                    case (int)PieceType.Pawn:
                        isSelected();
                        return 'p';
                    case (int)PieceType.Knight:
                        isSelected();
                        return 'n';
                    case (int)PieceType.Bishop:
                        isSelected();
                        return 'b';
                    case (int)PieceType.Rook:
                        isSelected();
                        return 'r';
                    case (int)PieceType.Queen:
                        isSelected();
                        return 'q';
                    case (int)PieceType.None:
                        isSelected(true);
                        return ' ';

                }
                Console.BackgroundColor = recentBackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            return '$';
        }
        //public char translateToChar()
        //{
        //    ConsoleColor recentForegroundColor = Console.ForegroundColor;
        //    if (White)
        //    {
        //        Console.ForegroundColor = recentForegroundColor;
        //        Console.ForegroundColor = ConsoleColor.White;
        //        switch (state)
        //        {
        //            case (int)PieceType.King:
        //                //    Console.ForegroundColor = recentForegroundColor;
        //                //    Console.ForegroundColor = ConsoleColor.Blue;
        //                return 'K';
        //            case (int)PieceType.Pawn:
        //                return 'P';
        //            case (int)PieceType.Knight:
        //                return 'N';
        //            case (int)PieceType.Bishop:
        //                return 'B';
        //            case (int)PieceType.Rook:
        //                return 'R';
        //            case (int)PieceType.Queen:
        //                return 'Q';
        //            case (int)PieceType.None:
        //                return ' ';
        //            case (int)PieceType.Move:
        //                Console.ForegroundColor = recentForegroundColor;
        //                Console.ForegroundColor = ConsoleColor.Yellow;
        //                return '#';
        //        }
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = recentForegroundColor;
        //        Console.ForegroundColor = ConsoleColor.Black;
        //        switch (state)
        //        {
        //            case (int)PieceType.King:
        //                return 'k';
        //            case (int)PieceType.Pawn:
        //                return 'p';
        //            case (int)PieceType.Knight:
        //                return 'n';
        //            case (int)PieceType.Bishop:
        //                return 'b';
        //            case (int)PieceType.Rook:
        //                return 'r';
        //            case (int)PieceType.Queen:
        //                return 'q';
        //            case (int)PieceType.None:
        //                return ' ';
        //            case (int)PieceType.Move:
        //                Console.ForegroundColor = recentForegroundColor;
        //                Console.ForegroundColor = ConsoleColor.Yellow;
        //                return '#';
        //        }
        //    }
        //    return '$';
        //}
    }
}