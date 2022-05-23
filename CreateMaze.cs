using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeConsolePROG
{
    class CreateMaze
    {    
        private World wrld;
        private Player plyr;   
        public void Maze()
        {
            Clear();       
                                            
            Title = "Maze LVL.(1)";
            string[,] grid = ParseFile.ParseFileToArray("MazeLVL1-1.txt");


            plyr = new Player(1, 2);
            wrld = new World(grid);

            RGameLoop();

           
        }

        private void DrawFrame()
        {
            Clear();
            wrld.Draw();
            plyr.DrawPlayer();
        }

        private void HandlePlyrInput()
        {
            ConsoleKeyInfo keyInfo = ReadKey();
            ConsoleKey key = keyInfo.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if(wrld.isClear(plyr.X, plyr.Y - 1))
                    {
                        plyr.Y -= 1;
                    }
                    plyr.Y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    if (wrld.isClear(plyr.X, plyr.Y + 1))
                    {
                        plyr.Y += 1;
                    }
                    plyr.Y += 1;
                    break;
                case ConsoleKey.RightArrow:
                    if (wrld.isClear(plyr.X + 1, plyr.Y))
                    {
                        plyr.X -= 1;
                    }
                    plyr.X += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    if (wrld.isClear(plyr.X - 1, plyr.Y))
                    {
                        plyr.X += 1;
                    }
                    plyr.X -= 1;
                    break;
                default:
                    break;
                
            }
        }    
        private void RGameLoop()
        {
            while(true)
            {
                //draw
                DrawFrame();

                //player keys and bound checking
               // HandlePlyrInput();

                //checking if player cords are at end of maze
              string elementAtPlayerPosition = wrld.GetElemAt(plyr.X, plyr.Y);
                 if (elementAtPlayerPosition.Equals("X")) break;
                            
                System.Threading.Thread.Sleep(20);

            }
        }
    }
}
