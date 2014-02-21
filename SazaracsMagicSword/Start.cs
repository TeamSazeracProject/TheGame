using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SazaracsMagicSword.RunTime;
using SazaracsMagicSword.GameObjects;
using SazaracsMagicSword.Data;

namespace SazaracsMagicSword
{
    class Start
    {
        static Loader load = new Loader();
        static Drawer draw = new Drawer();
        static Levels levels = new Levels();
        static Menus menu = new Menus();
        static Hero hero;
        static VisualElement[,] matrix = new VisualElement[levels.height, levels.width];
        static List<NPC> NPCsOfCurrentLevel = new List<NPC>();
        static bool nearbyNPC;

        static int height = 50, width = 110;
        static VisualElement[,] VisibleMatrix = new VisualElement[height, width];

        static void Main(string[] args)
        {
            Console.WindowHeight = height;
            Console.WindowWidth = width;

            //1) Main menu (new game / load game)
            hero = menu.ChooseHeroFromConsole();

            //2) Dynamic game
            matrix = load.LoadLevel(matrix, levels.Level1, hero, NPCsOfCurrentLevel);
            //VisibleMatrix = load.LoadVisibleLevel(VisibleMatrix, matrix, hero); // throws an exception...
            draw.DrawMatrixInConsole(matrix);
            while (true)
            {
                CheckHeroPosition(); // Conversations && Battles

                draw.DrawHero(hero);
                Console.SetCursorPosition(80, 0);
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                ProcessInput(pressedKey);
            }
        }
        static void ProcessInput(ConsoleKeyInfo pressedKey)
        {

            if (pressedKey.Key.Equals(ConsoleKey.UpArrow))
            {
                if (!matrix[hero.position.row - 1, hero.position.col].isSolid)
                {
                    draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                    hero.Move(Direction.up);
                }
            }
            else if (pressedKey.Key.Equals(ConsoleKey.DownArrow))
            {
                if (!matrix[hero.position.row + 1, hero.position.col].isSolid)
                {
                    draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                    hero.Move(Direction.down);
                }
            }
            else if (pressedKey.Key.Equals(ConsoleKey.LeftArrow))
            {
                if (!matrix[hero.position.row, hero.position.col - 1].isSolid)
                {
                    draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                    hero.Move(Direction.left);
                }
            }
            else if (pressedKey.Key.Equals(ConsoleKey.RightArrow))
            {
                if (!matrix[hero.position.row, hero.position.col + 1].isSolid)
                {
                    draw.DrawInConsole(matrix[hero.position.row, hero.position.col], hero.position.row, hero.position.col);
                    hero.Move(Direction.right);
                }
            }
            else if (pressedKey.Key.Equals(ConsoleKey.Enter))
            {
                if (nearbyNPC)
                {
                    foreach (NPC npc in NPCsOfCurrentLevel)
                    {
                        if (Math.Abs(npc.position.row - hero.position.row) <= 1 &&
                            Math.Abs(npc.position.col - hero.position.col) <= 1)
                        {
                            Conversation conversation = new Conversation();
                            conversation.DrawConversation(hero, npc);
                            draw.DrawMatrixInConsole(matrix);
                        }
                    }
                }
            }
        }

        static void CheckHeroPosition()
        {
            DiceRoller dice = new DiceRoller();
            int r = hero.position.row;
            int c = hero.position.col;
            nearbyNPC = false;

            foreach (NPC npc in NPCsOfCurrentLevel)
            {
                if (Math.Abs(npc.position.row - hero.position.row) <= 1 &&
                            Math.Abs(npc.position.col - hero.position.col) <= 1)
                {
<<<<<<< HEAD
                    nearbyNPC = true;
                    int top = height - 7;
                    int left = width / 2 - 20;
                    Console.SetCursorPosition(left, top);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("Press [Enter] to talk to " + npc.Name);
=======
                    foreach (NPC npc in NPCsOfCurrentLevel)
                    {
                        if (npc.position.row == row && npc.position.col == col)
                        {
                            nearbyNPC = true;
                            int top = height - 7;
                            int left = width / 2 - 20;
                            Console.SetCursorPosition(left, top);
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write("Press [Enter] to talk to " + npc.Name);

                            //added player choise
                            var enterKey = Console.ReadKey();
                            if (enterKey.Key.Equals(ConsoleKey.Enter))
                            {
                                Conversation test = new Conversation();
                                test.DrawConversation(hero, npc);
                                draw.DrawMatrixInConsole(matrix);
                            }
                            ////////////////
                            
                            
                        }
                    }
>>>>>>> added intro conversation
                }
            }
            if (!nearbyNPC)
            {
                int top = height - 7;
                int left = width / 2 - 20;
                Console.SetCursorPosition(left, top);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(new String(' ', 40));
            }

            if (matrix[r, c].content is DangerousTerritory)
            {
                if (dice.NewDice(matrix[r, c].content.Chance))
                {
                    Battle battle = new Battle();
                    battle.StartBattle(hero, matrix[r, c].content.enemyToAppear);
                    Console.Clear();
                    draw.DrawMatrixInConsole(matrix);
                }
            }
        }
    }
}
