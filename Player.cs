using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeConsolePROG
{
    class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        private string PlayerPr;
        private ConsoleColor PlayerColor;

        public Player(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PlayerPr = "#";
            PlayerColor = ConsoleColor.Green;
        }

     

        public void DrawPlayer()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(X, Y);
            Write(PlayerPr);
            ResetColor();
        }
    }
}
