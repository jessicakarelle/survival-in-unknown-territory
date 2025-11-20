using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Map
    {
        public static int playerPostionX = 0;
        public static int playerPostionY = 0;

        public static int[,] mapGrid = new int[20, 20];

        public static Random PositionGenerator = new Random();
        public static List<String> SavePosition = new List<String>();

        public static void DisplayGridMap()
        {
            // Boucle sur les colomnes
            for(int i= 0; i < mapGrid.GetLength(0); i++)
            {
                //Boucles pour les lignes
                for(int j = 0; j < mapGrid.GetLength(1); j++)
                {
                    if(playerPostionX == j && playerPostionY == i)
                    {
                        Console.Write("| ");
                    }
                    else
                    {
                        Console.Write("| ");
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < 20; j++)
                {
                    Console.Write("--");
                }
                Console.ResetColor();
            }
        }
        public static ConsoleKey DisplayBase()
        {
            Console.Clear();
            Display.DisplayBasePosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Display.AnimateText("Vous êtes actuellement sur le terrain de base");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :\n");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.ResetColor();
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[F]abriquer des matériaux");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");
            
            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayBaseInput()
        {
            Console.ResetColor();
            bool stayAtBase = true;

            while (stayAtBase)
            {
                ConsoleKey input = DisplayBase();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        Menu.ProcessInventoryInput();
                        break;

                    case ConsoleKey.F:
                        Menu.ProcessDisplayManufacturingInput();
                        break;

                    case ConsoleKey.R:
                        Menu.ProcessDisplayMenuInput();
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayDirection()
        {
            Console.Clear();
            Console.ResetColor();
            Display.AnimateText("Veuillez sélectionner une option :");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[N]ord : Vous vous déplacez vers le haut");
            Console.WriteLine("[O]uest : Vous vous déplacez vers la gauche");
            Console.WriteLine("[S]ud : Vous vous déplacez vers le bas");
            Console.WriteLine("[E]st : Vous vous déplacez vers la droite");
            Console.WriteLine("[M]enu : Retour au menu principal");
            Console.WriteLine("[Q]uitter : Quitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static void ProcessExplorationInput()
        {
            bool exploring = true;

            while (exploring)
            {
                ConsoleKey input = DisplayDirection();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.N:
                    case ConsoleKey.UpArrow:
                        playerPostionY++;
                        Console.Clear();
                        Display.AnimateText("Vous vous êtes déplacer vers le Nord");
                        Display.AnimateText("\nN'oubliez pas de collecter des ressources !");
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.O:
                    case ConsoleKey.LeftArrow:
                        playerPostionX--;
                        Console.Clear();
                        Display.AnimateText("Vous vous êtes déplacer vers l' Ouest");
                        Display.AnimateText("\nN'oubliez pas de collecter des ressources !");
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        playerPostionY--;
                        Console.Clear();
                        Display.AnimateText("Vous vous êtes déplacer vers le Sud");
                        Display.AnimateText("\nN'oubliez pas de collecter des ressources !");
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                    case ConsoleKey.RightArrow:
                        playerPostionX++;
                        Console.Clear();
                        Display.AnimateText("Vous vous êtes déplacer vers le Sud");
                        Display.AnimateText("\nN'oubliez pas de collecter des ressources !");
                        Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.M:
                        exploring = false;
                        Console.Clear();
                        Display.AnimateText("Retour au menu principal...");
                        Thread.Sleep(1500);
                        Menu.ProcessDisplayMenuInput();
                        break;

                    case ConsoleKey.Q:
                        exploring = false;
                        Console.Clear();
                        Menu.ProcessDisplayLeaveMessageInput();
                        break;

                    default:
                        Console.Clear();
                        Display.AnimateText("Direction invalide. Veuillez réessayer.");
                        Thread.Sleep(1500);
                        break;
                }
            }
        }

        public static ConsoleKey DisplayForest()
        {
            Console.Clear();
            Display.DisplayForestPosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans la forêt");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayForestInput()
        {
            bool stayInForest = true;

            while (stayInForest)
            {
                ConsoleKey input = DisplayForest();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.C:  
                        break;
                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }
        public static ConsoleKey DisplayPrairie()
        {
            Console.Clear();
            Display.DisplayPrairiePosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans la prairie");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayPrairieInput()
        {
            bool stayInPrairie = true;

            while (stayInPrairie)
            {
                ConsoleKey input = DisplayPrairie();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }
    
        public static ConsoleKey DisplayDesert()
        {
            Console.Clear();
            Display.DisplayDesertPosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans le désert");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayDesertInput()
        {
            bool stayInDesert = true;

            while (stayInDesert)
            {
                ConsoleKey input = DisplayDesert();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayRiver()
        {
            Console.Clear();
            Display.DisplayRiverPosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement près de la rivière");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayRiverInput()
        {
            bool stayAtRiver = true;

            while (stayAtRiver)
            {
                ConsoleKey input = DisplayRiver();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplaySwamp()
        {
            Console.Clear();
            Display.DisplaySwampPosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans le marais");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplaySwampInput()
        {
            bool stayInSwamp = true;

            while (stayInSwamp)
            {
                ConsoleKey input = DisplaySwamp();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }

        public static ConsoleKey DisplayMountain()
        {
            Console.Clear();
            Display.DisplayMountainPosition();
            Thread.Sleep(1000);
            Console.WriteLine();
            Display.AnimateText("Vous êtes actuellement dans la montagne");
            Console.WriteLine();
            Console.WriteLine();
            Display.AnimateText("Veuillez sélectionner une action à effectuer :");
            Console.WriteLine();
            Thread.Sleep(100);
            Console.WriteLine("[E]xplorer les différents territoires");
            Console.WriteLine("[A]fficher l'inventaire");
            Console.WriteLine("[C]ollecter des ressources");
            Console.WriteLine("[R]etour au menu principal");
            Console.WriteLine("[Q]uitter le jeu");
            Console.WriteLine();
            Console.Write("Votre choix : ");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key;
        }

        public static bool ProcessDisplayMountainInput()
        {
            bool stayInMountain = true;

            while (stayInMountain)
            {
                ConsoleKey input = DisplayMountain();
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.E:
                        ProcessExplorationInput();
                        break;

                    case ConsoleKey.A:
                        break;
                    case ConsoleKey.C:
                        break;
                    case ConsoleKey.R:
                        return true;

                    case ConsoleKey.Q:
                        Menu.ProcessDisplayLeaveMessageInput();
                        return false;

                    default:
                        Console.Clear();
                        Display.AnimateText("Choix invalide. Veuillez réessayer.");
                        Thread.Sleep(500);
                        break;
                }
            }

            return true;
        }
    }
}