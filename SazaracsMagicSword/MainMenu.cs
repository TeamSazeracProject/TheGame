using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SazaracsMagicSword
{
    public static class MainMenu
    {
        public static void StartMainMenu()
        {
            bool notDecided = true;
            int choose = 9;
            Console.WindowHeight = 50;
            Console.WindowWidth = 110;

            Console.SetCursorPosition(35, 9);
            Console.WriteLine("New Game");
            Console.SetCursorPosition(35, 12);
            Console.WriteLine("Load Game");
            Console.SetCursorPosition(35, 15);
            Console.WriteLine("Exit");

            while (notDecided)
            {
                Console.SetCursorPosition(30, choose);
                Console.WriteLine("==>");

                var pressedKey = Console.ReadKey();
                if (pressedKey.Key.Equals(ConsoleKey.DownArrow))
                {
                    SetArrowPosition(choose);
                    choose += 3;
                    choose = CheckSetterPosition(choose);
                }
                else if (pressedKey.Key.Equals(ConsoleKey.UpArrow))
                {
                    SetArrowPosition(choose);
                    choose += -3;
                    choose = CheckSetterPosition(choose);
                }

            }
                      
        }

        private static void SetArrowPosition(int choose)
        {
            Console.SetCursorPosition(30, choose);
            Console.WriteLine("     ");
        }

        private static int CheckSetterPosition(int choose)
        {
            if (choose < 9 || choose > 15)
            {
                if (choose < 9)
                {
                    choose = 15;
                }
                else
                {
                    choose = 9;
                }
            }
            return choose;
        }
    }
}
