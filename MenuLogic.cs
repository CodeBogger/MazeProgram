using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MazeConsolePROG
{
    class MenuLogic
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public MenuLogic(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {

                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = ">";
                    ForegroundColor = ConsoleColor.Green;

                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;

                }
                WriteLine($"{prefix}<< {currentOption} >>");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            Screen scr = new Screen();

            //update selected index from arrow keys
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.Escape) scr.RunExit();

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;

                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;

                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = SelectedIndex = 0;
                    }
                }




                if (keyPressed == ConsoleKey.RightArrow)
                {
                    switch (SelectedIndex)
                    {
                        case 0:
                            scr.RunMaze();
                            break;
                        case 1:
                            scr.RunAbout();
                            break;
                        case 2:
                            scr.RunExit();
                            break;
                        case 3:
                            scr.RunBack();
                            break;
                    }


                }
            }
            while (keyPressed != ConsoleKey.Escape);
            return SelectedIndex;
        }
    }
}
