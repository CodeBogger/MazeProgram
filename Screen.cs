using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace MazeConsolePROG
{
    class Screen
    {
        
        public static void StartScreen()
        {
            Clear();
            Console.WriteLine("                              --------- Hello, these are the controls: -------\n");
            string start = @"                                 Use arrow keys to navigate through list-
                      Use right and left arrow keys to select an option from the list-
                                Look for further intrusctions just in case-
                              
                               ";
            Console.WriteLine(start);

            DisplayList();

        }
        public static void MainScreen()
        {
            string prompt = @"
 ▄▄       ▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░▌     ▐░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
▐░▌░▌   ▐░▐░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ 
▐░▌▐░▌ ▐░▌▐░▌▐░▌       ▐░▌          ▐░▌▐░▌          
▐░▌ ▐░▐░▌ ▐░▌▐░█▄▄▄▄▄▄▄█░▌ ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ 
▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
▐░▌   ▀   ▐░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ 
▐░▌       ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌          
▐░▌       ▐░▌▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄ 
▐░▌       ▐░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
 ▀         ▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
Welcome to a crappy program called: Maze.";

            string[] options = { "Maze", "About", "Exit", "Go Back" };
            MenuLogic menu = new MenuLogic(prompt, options);
            int selectedIndex = menu.Run();

        }

        

        public static void ExitProg()
        {
            
            Clear();
            string res = "\nPress any key to exit...";
            
        
                ForegroundColor = ConsoleColor.Green;
               
            

            Console.WriteLine($"{res}");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        public static void DisplayList()
        {
            string res = "\nPress any key to continue";
           
                ForegroundColor = ConsoleColor.Green;
               
            
            Console.WriteLine($"{res}");

            Console.ReadKey(true);
            ResetColor();
            MainScreen();
        }
        
        public void RunMaze()
        {
            Clear();
            string starter = @"                                    ------- Hello, welcome to the maze! -------

                            Now, don't get too exited, nothing is really good here.
                                             Just enough... anyways!

                                     ";
            
            string ins = @"                                        

                                                      [Note] 
                                           # <----- This is your player
                                           Your trying to navigate to a 
                                                     (Green) X

                                           Navigate with your arrow keys!
                                                   ↑  ↓  →  ← ";

            WriteLine(starter);
            WriteLine(ins);
        
            string res = "\nPress any key to continue";

            ForegroundColor = ConsoleColor.Green;           
            Console.WriteLine($"{res}");

            Console.ReadKey(true);
            ResetColor();
           
            CreateMaze log = new CreateMaze();
            log.Maze();

            DisplayList();
        }
        public void RunAbout()
        {
            Clear();
            string disc = @"                                     ------ Creator: Bogdan Boyko ------
                                           Date Created: 5/19/2022

                                   Reason for creation: I was bored 
                                   and wanted to expand my programming skills...
                                                       
                            ";
            Console.WriteLine(disc);
            DisplayList();
        }
        public void RunExit()
        {
            Clear();
            Console.WriteLine("Have a nice day, tell your friends about this, or not. I need practice.");
            ExitProg();
          
        }

        public void RunBack()
        {
            StartScreen();
        }
        public static void Main(string[] args)
        {
            // Timer t = new Timer(TimerCallback, null, 0, 1000);
            // WriteLine(t);
            Title = "Maze";
            StartScreen();
            MainScreen();

        }

    }
}

