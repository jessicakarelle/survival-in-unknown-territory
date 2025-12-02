using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Display
    {
        /// <summary>
        ///Méthode qui affiche le titre du jeu
        /// </summary>
        public static void DisplayGameTitle()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("███████╗██╗   ██╗██████╗ ██╗   ██╗██╗███████╗    ███████╗███╗   ██╗    ████████╗███████╗██████╗ ██████╗ ███████╗" +
                                "\r\n██╔════╝██║   ██║██╔══██╗██║   ██║██║██╔════╝    ██╔════╝████╗  ██║    ╚══██╔══╝██╔════╝██╔══██╗██╔══██╗██╔════╝" +
                                "\r\n███████╗██║   ██║██████╔╝██║   ██║██║█████╗      █████╗  ██╔██╗ ██║       ██║   █████╗  ██████╔╝██████╔╝█████╗ " +
                                " \r\n╚════██║██║   ██║██╔══██╗╚██╗ ██╔╝██║██╔══╝      ██╔══╝  ██║╚██╗██║       ██║   ██╔══╝  ██╔══██╗██╔══██╗██╔══╝  " +
                                "\r\n███████║╚██████╔╝██║  ██║ ╚████╔╝ ██║███████╗    ███████╗██║ ╚████║       ██║   ███████╗██║  ██║██║  ██║███████╗" +
                                "\r\n╚══════╝ ╚═════╝ ╚═╝  ╚═╝  ╚═══╝  ╚═╝╚══════╝    ╚══════╝╚═╝  ╚═══╝       ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝" +
                                "\r\n██╗███╗   ██╗ ██████╗ ██████╗ ███╗   ██╗███╗   ██╗██╗   ██╗███████╗                                             " +
                                "\r\n██║████╗  ██║██╔════╝██╔═══██╗████╗  ██║████╗  ██║██║   ██║██╔════╝                                             " +
                                "\r\n██║██╔██╗ ██║██║     ██║   ██║██╔██╗ ██║██╔██╗ ██║██║   ██║█████╗                                               " +
                                "\r\n██║██║╚██╗██║██║     ██║   ██║██║╚██╗██║██║╚██╗██║██║   ██║██╔══╝                                               " +
                                "\r\n██║██║ ╚████║╚██████╗╚██████╔╝██║ ╚████║██║ ╚████║╚██████╔╝███████╗                                             " +
                                "\r\n╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝                                             ");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("\n\nAppuyez sur touche pour commençer le jeu....");

            Console.ReadKey();
        }

        /// <summary>
        ///Méthode qui affiche "Menu"
        /// </summary>
        public static void DisplayPrincipalMenu()
        {
            Console.Clear();
            Console.WriteLine("███╗   ███╗███████╗███╗   ██╗██╗   ██╗       " +
                        "\r\n████╗ ████║██╔════╝████╗  ██║██║   ██║       " +
                        "\r\n██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║       " +
                        "\r\n██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║      " +
                        " \r\n██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝      " +
                        " \r\n╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝        ");
        }

        /// <summary>
        ///Méthode qui affiche "Crédit"
        /// </summary>
        public static void DisplayCreditMessage()
        {
            Console.Clear();
            Console.WriteLine(" ██████╗██████╗ ███████╗██████╗ ██╗████████╗       " +
                            "\r\n██╔════╝██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝       " +
                            "\r\n██║     ██████╔╝█████╗  ██║  ██║██║   ██║          " +
                            "\r\n██║     ██╔══██╗██╔══╝  ██║  ██║██║   ██║          " +
                            "\r\n╚██████╗██║  ██║███████╗██████╔╝██║   ██║          " +
                            "\r\n ╚═════╝╚═╝  ╚═╝╚══════╝╚═════╝ ╚═╝   ╚═╝          ");
        }

        /// <summary>
        ///Méthode qui affiche "Base"
        /// </summary>
        public static void DisplayBasePosition()
        {
            Console.Clear();
            Console.WriteLine("██████╗  █████╗ ███████╗███████╗" +
                        "\r\n██╔══██╗██╔══██╗██╔════╝██╔════╝" +
                        "\r\n██████╔╝███████║███████╗█████╗" +
                        "  \r\n██╔══██╗██╔══██║╚════██║██╔══╝ " +
                        " \r\n██████╔╝██║  ██║███████║███████╗" +
                        "\r\n╚═════╝ ╚═╝  ╚═╝╚══════╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Désert"
        /// </summary>
        public static void DisplayDesertPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("██████╗ ███████╗███████╗███████╗██████╗ ████████╗" +
                                "\r\n██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗╚══██╔══╝" +
                                "\r\n██║  ██║█████╗  ███████╗█████╗  ██████╔╝   ██║   " +
                                "\r\n██║  ██║██╔══╝  ╚════██║██╔══╝  ██╔══██╗   ██║   " +
                                "\r\n██████╔╝███████╗███████║███████╗██║  ██║   ██║   " +
                                "\r\n╚═════╝ ╚══════╝╚══════╝╚══════╝╚═╝  ╚═╝   ╚═╝   ");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Rivière"
        /// </summary>
        public static void DisplayRiverPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("██████╗ ██╗██╗   ██╗██╗███████╗██████╗ ███████╗" +
                        "\r\n██╔══██╗██║██║   ██║██║██╔════╝██╔══██╗██╔════╝" +
                        "\r\n██████╔╝██║██║   ██║██║█████╗  ██████╔╝█████╗  " +
                        "\r\n██╔══██╗██║╚██╗ ██╔╝██║██╔══╝  ██╔══██╗██╔══╝  " +
                        "\r\n██║  ██║██║ ╚████╔╝ ██║███████╗██║  ██║███████╗" +
                        "\r\n╚═╝  ╚═╝╚═╝  ╚═══╝  ╚═╝╚══════╝╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Prairie"
        /// </summary>
        public static void DisplayPrairiePosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("██████╗ ██████╗  █████╗ ██╗██████╗ ██╗███████╗" +
                        "\r\n██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗██║██╔════╝" +
                        "\r\n██████╔╝██████╔╝███████║██║██████╔╝██║█████╗  " +
                        "\r\n██╔═══╝ ██╔══██╗██╔══██║██║██╔══██╗██║██╔══╝  " +
                        "\r\n██║     ██║  ██║██║  ██║██║██║  ██║██║███████╗" +
                        "\r\n╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Forêt"
        /// </summary>
        public static void DisplayForestPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("███████╗ ██████╗ ██████╗ ███████╗████████╗" +
                        "\r\n██╔════╝██╔═══██╗██╔══██╗██╔════╝╚══██╔══╝" +
                        "\r\n█████╗  ██║   ██║██████╔╝█████╗     ██║  " +
                        " \r\n██╔══╝  ██║   ██║██╔══██╗██╔══╝     ██║   " +
                        "\r\n██║     ╚██████╔╝██║  ██║███████╗   ██║   " +
                        "\r\n╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝   ╚═╝   ");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Marais"
        /// </summary>
        public static void DisplaySwampPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("███╗   ███╗ █████╗ ██████╗  █████╗ ██╗███████╗" +
                                "\r\n████╗ ████║██╔══██╗██╔══██╗██╔══██╗██║██╔════╝" +
                                "\r\n██╔████╔██║███████║██████╔╝███████║██║███████╗" +
                                "\r\n██║╚██╔╝██║██╔══██║██╔══██╗██╔══██║██║╚════██║" +
                                "\r\n██║ ╚═╝ ██║██║  ██║██║  ██║██║  ██║██║███████║" +
                                "\r\n╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Montagne"
        /// </summary>
        public static void DisplayMountainPosition()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("███╗   ███╗ ██████╗ ███╗   ██╗████████╗ █████╗  ██████╗ ███╗   ██╗███████╗" +
                        "\r\n████╗ ████║██╔═══██╗████╗  ██║╚══██╔══╝██╔══██╗██╔════╝ ████╗  ██║██╔════╝" +
                        "\r\n██╔████╔██║██║   ██║██╔██╗ ██║   ██║   ███████║██║  ███╗██╔██╗ ██║█████╗  " +
                        "\r\n██║╚██╔╝██║██║   ██║██║╚██╗██║   ██║   ██╔══██║██║   ██║██║╚██╗██║██╔══╝  " +
                        "\r\n██║ ╚═╝ ██║╚██████╔╝██║ ╚████║   ██║   ██║  ██║╚██████╔╝██║ ╚████║███████╗" +
                        "\r\n╚═╝     ╚═╝ ╚═════╝ ╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Inventaire"
        /// </summary>
        public static void DisplayInventoryItems()
        {
            Console.WriteLine("██╗███╗   ██╗██╗   ██╗███████╗███╗   ██╗████████╗ █████╗ ██╗██████╗ ███████╗" +
                        "\r\n██║████╗  ██║██║   ██║██╔════╝████╗  ██║╚══██╔══╝██╔══██╗██║██╔══██╗██╔════╝" +
                        "\r\n██║██╔██╗ ██║██║   ██║█████╗  ██╔██╗ ██║   ██║   ███████║██║██████╔╝█████╗  " +
                        "\r\n██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██║╚██╗██║   ██║   ██╔══██║██║██╔══██╗██╔══╝  " +
                        "\r\n██║██║ ╚████║ ╚████╔╝ ███████╗██║ ╚████║   ██║   ██║  ██║██║██║  ██║███████╗" +
                        "\r\n╚═╝╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Matériaux"
        /// </summary>
        public static void DisplayInventoryItem2()
        {
            Console.WriteLine("███╗   ███╗ █████╗ ████████╗███████╗██████╗ ██╗███████╗██╗   ██╗██╗  ██╗" +
                        "\r\n████╗ ████║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║██╔════╝██║   ██║╚██╗██╔╝" +
                        "\r\n██╔████╔██║███████║   ██║   █████╗  ██████╔╝██║█████╗  ██║   ██║ ╚███╔╝" +
                        " \r\n██║╚██╔╝██║██╔══██║   ██║   ██╔══╝  ██╔══██╗██║██╔══╝  ██║   ██║ ██╔██╗ " +
                        "\r\n██║ ╚═╝ ██║██║  ██║   ██║   ███████╗██║  ██║██║███████╗╚██████╔╝██╔╝ ██╗" +
                        "\r\n╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   ╚══════╝╚═╝  ╚═╝╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Ressources"
        /// </summary>
        public static void DisplayInventoryItem1()
        {
            Console.WriteLine("██████╗ ███████╗███████╗███████╗ ██████╗ ██╗   ██╗██████╗  ██████╗███████╗███████╗" +
                                "\r\n██╔══██╗██╔════╝██╔════╝██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔════╝██╔════╝" +
                                "\r\n██████╔╝█████╗  ███████╗███████╗██║   ██║██║   ██║██████╔╝██║     █████╗  ███████╗" +
                                "\r\n██╔══██╗██╔══╝  ╚════██║╚════██║██║   ██║██║   ██║██╔══██╗██║     ██╔══╝  ╚════██║" +
                                "\r\n██║  ██║███████╗███████║███████║╚██████╔╝╚██████╔╝██║  ██║╚██████╗███████╗███████║" +
                                "\r\n╚═╝  ╚═╝╚══════╝╚══════╝╚══════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚══════╝╚══════╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche "Fabrication"
        /// </summary>
        public static void DisplayManufacturingItems()
        {
            Console.WriteLine("███████╗ █████╗ ██████╗ ██████╗ ██╗ ██████╗ █████╗ ████████╗██╗ ██████╗ ███╗   ██╗" +
                                "\r\n██╔════╝██╔══██╗██╔══██╗██╔══██╗██║██╔════╝██╔══██╗╚══██╔══╝██║██╔═══██╗████╗  ██║" +
                                "\r\n█████╗  ███████║██████╔╝██████╔╝██║██║     ███████║   ██║   ██║██║   ██║██╔██╗ ██║" +
                                "\r\n██╔══╝  ██╔══██║██╔══██╗██╔══██╗██║██║     ██╔══██║   ██║   ██║██║   ██║██║╚██╗██║" +
                                "\r\n██║     ██║  ██║██████╔╝██║  ██║██║╚██████╗██║  ██║   ██║   ██║╚██████╔╝██║ ╚████║" +
                                "\r\n╚═╝     ╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝ ╚═════╝ ╚═╝  ╚═══╝");
            Console.ResetColor();
        }

        /// <summary>
        ///Méthode qui affiche la maison 
        /// </summary>
        public static void DisplayHouse()
        {

            string art = @"                                    /\
                               /\  //\\
                        /\    //\\///\\\        /\
                       //\\  ///\////\\\\  /\  //\\
          /\          /  ^ \/^ ^/^  ^  ^ \/^ \/  ^ \
         / ^\    /\  / ^   /  ^/ ^ ^ ^   ^\ ^/  ^^  \
        /^   \  / ^\/ ^ ^   ^ / ^  ^    ^  \/ ^   ^  \       *
       /  ^ ^ \/^  ^\ ^ ^ ^   ^  ^   ^   ____  ^   ^  \     /|\
      / ^ ^  ^ \ ^  _\___________________|  |_____^ ^  \   /||o\
     / ^^  ^ ^ ^\  /______________________________\ ^ ^ \ /|o|||\
    /  ^  ^^ ^ ^  /________________________________\  ^  /|||||o|\
   /^ ^  ^ ^^  ^    ||___|___||||||||||||___|__|||      /||o||||||\
  / ^   ^   ^    ^  ||___|___||||||||||||___|__|||          | |
 / ^ ^ ^  ^  ^  ^   ||||||||||||||||||||||||||||||oooooooooo| |ooooooo
 ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo"
            ;

            Console.WriteLine(art);

            Console.ResetColor();

        }

        /// <summary>
        ///Méthode qui affiche "Base"
        /// </summary>
        public static void AnimateText(string texte, ConsoleColor couleur = ConsoleColor.White, int timeLimit = 30)
        {
            ConsoleColor savedColor = Console.ForegroundColor;
            Console.ForegroundColor = couleur;

            for (int i = 0; i < texte.Length; i++)
            {
                Console.Write(texte[i]);
                if (i % 2 == 0)
                {
                    Thread.Sleep(timeLimit);
                }
            }

            Console.ForegroundColor = savedColor;
        }

        /// <summary>
        ///Méthode qui affiche "Repas"
        /// </summary>
        public static void DisplayCooking()
        {
            Console.WriteLine("██████╗ ███████╗██████╗  █████╗ ███████╗" +
                        "\r\n██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝" +
                        "\r\n██████╔╝█████╗  ██████╔╝███████║███████╗" +
                        "\r\n██╔══██╗██╔══╝  ██╔═══╝ ██╔══██║╚════██║" +
                        "\r\n██║  ██║███████╗██║     ██║  ██║███████║" +
                        "\r\n╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝  ╚═╝╚══════╝");
        }

        /// <summary>
        ///Méthode qui affiche la barre d'énergie
        /// </summary>
        public static void DisplayEnergyBar()
        {
            Console.Write("\nÉnergie: [");
            int barLength = 30;
            int filledBars = (Map.playerEnergy * barLength) / 100;

            ConsoleColor barColor = ConsoleColor.White;

            if (Map.playerEnergy > 75)
            {
                barColor = ConsoleColor.DarkGreen; 
            }
            else if (Map.playerEnergy > 50)
            {
                barColor = ConsoleColor.Green;
            }
            else if(Map.playerEnergy <= 50 && Map.playerEnergy > 20)
            {
                barColor= ConsoleColor.Red;
            }
            else
            {
                barColor = ConsoleColor.DarkRed;
            }
            Console.ForegroundColor = barColor;
            for (int i = 0; i < filledBars; i++)
            {
                Console.Write("█");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for (int i = filledBars; i < barLength; i++)
            {
                Console.Write("░");
            }

            Console.WriteLine($"] {Map.playerEnergy}%");
        }
        /// <summary>
        ///Méthode qui affiche "Game over"
        /// </summary>
        public static void DisplayGameOver()
        {
            Console.WriteLine("██████╗  █████╗ ███╗   ███╗███████╗     ██████╗ ██╗   ██╗███████╗██████╗ " +
                        "\r\n██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗" +
                        "\r\n██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝" +
                        "\r\n██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗" +
                        "\r\n╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║" +
                        "\r\n ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");
        }

        /// <summary>
        ///Méthode qui affiche le message lorsque le joueur a perdu la partie
        /// </summary>
        public static void DisplayLoseMessage()
        {
            DisplayGameOver();
            Console.WriteLine();
           
            ProcessNewGameConfirmation();
        }

        /// <summary>
        ///Méthode qui affiche le message de confirmation d'une nouvelle partie
        /// </summary>
        public static ConsoleKey DisplayNewGameConfirmation()
        {
            Console.Clear();
            Console.WriteLine("Voulez vous rejouer une nouvelle partie ?");
            Console.WriteLine("[O]ui");
            Console.WriteLine("[N]on");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            return keyInfo.Key;
        }

        /// <summary>
        ///Méthode qui traite les choix effectuer dans le message de confirmation d'une nouvelle partie
        /// </summary>
        public static void ProcessNewGameConfirmation()
        {
            bool waitingForChoice = true;
            while (waitingForChoice)
            {
                ConsoleKey input = DisplayNewGameConfirmation();
                switch (input)
                {
                    case ConsoleKey.O:
                        Map.ResetGame();
                        Map.ShowTerrainAtCurrentPosition();
                        waitingForChoice = false;
                        break;
                    case ConsoleKey.N:
                        waitingForChoice = false;
                        Console.WriteLine("Appuyer sur une touche pour quitter le jeu ...");
                        Console.ReadKey();
                        Process.GetCurrentProcess().Kill();
                        break;
                    default:
                        Console.WriteLine("\nChoix invalide. Veuillez réessayer");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}

    

