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
        public Dictionary<char,int> location = new Dictionary<char, int>();

        public bool White;
        public enum PieceType { None, King, Pawn, Knight, Bishop, Rook, Queen/*, Move*/}
        private bool isSelected(bool is_none=false)
        {
            if (is_selected)
            {
                Console.ForegroundColor = recentForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if(is_none && is_selected)
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
                Console.ForegroundColor = recentForegroundColor;
                Console.ForegroundColor = ConsoleColor.White;
                
                switch (state)
                {
                    case (int)PieceType.King:
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
            return '?';
        }
    }
}