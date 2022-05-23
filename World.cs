using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeConsolePROG
{
    class World
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;

        public World(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);
        }

        public void Draw()
        {
            for(int x=0; x<Rows; x++)
            {
                for(int y=0; y<Cols; y++)
                {
                    string element = Grid[x, y];
                    SetCursorPosition(x, y);

                    if(element.Equals("X"))
                    {
                        ForegroundColor = ConsoleColor.Green;
                    }
                    else if(element.Equals("█")) 
                    {
                        ForegroundColor= ConsoleColor.Green;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.White;
                    }
                    Write(element);
                }
            }
        }

        public string GetElemAt(int x, int y)
        {
            try
            {
                return Grid[x, y];
            }
            catch (Exception io)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"\n\n\n Exception Error: {io.Message}\n - (Player or \"X\" was outside)");
                ResetColor();
            }
       
            return Grid[x, y];
            
        }

       

        public bool isClear(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Cols || y>= Rows)
            {
                return false;
            }
            return Grid[y, x] == " " || Grid[y, x] == "X";
        }
    }
}
