using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvieEnTerreInconnue
{
    internal class Menu
    {
        //Sert à afficher le cadre 
        static void DisplayFrame(string texte)
        {
            int length = texte.Length;
            Console.WriteLine($"╔{new string('═', length)}╗");
            Console.WriteLine($"║{texte}║");
            Console.WriteLine($"╚{new string('═', length)}╝");
        }

        //Afficher le menu
        public static int DisplayMenu()
        {
            DisplayFrame("Bienvenue dans le menu principal du jeu Survie En Terre Inconnu");
            Console.WriteLine("1. Jouer");
            Console.WriteLine("2. Charger une nouvelle partie");
            Console.WriteLine("3. Sauvegarder une partie");
            Console.WriteLine("4. Crédits");
            Console.WriteLine("5. Quitter");
            Console.WriteLine("Veuillez sélectionner l'une des options ci-dessus :");
            int input = int.Parse( Console.ReadLine() );

            return input;
        }
        //Afficher la mise en contexte du jeu
        public static void DisplayGameHistory()
        {
            Console.WriteLine("Vous êtes le seul survivant à un crash d'avion");
            Thread.Sleep(1000);
            Console.WriteLine("Vous êtes sur une île abandonné, aucun signe de vie aux alentours");
            Thread.Sleep(1000);
            Console.WriteLine("L'hiver approche ...");
            Thread.Sleep(1000);
            Console.WriteLine("Construisez vous un abrit au plus vite si vous souhaitez  survivre ...");
        }
        //Afficher le menu de fabrication
        public static ConsoleKey DisplayManufacturingMenu()
        {
            Display.DisplayManufacturingItems();
            Console.WriteLine();

            Console.WriteLine("\t\t***********************************************************");
            Console.WriteLine("[F]eu : Cette action nécessite du Bois et du Silex");
            Console.WriteLine("[H]ache : Cette action nécessite du Bois et Du Fer");
            Console.WriteLine("[V]itre : Cette action nécessite du Sable et du Feu");
            Console.WriteLine("[P]lanche : Cette action nécessite du Bois ainsi qu'une Hache");
            Console.WriteLine("[B]rique : Cette action nécessite du Feu et de l'Argile");
            Console.WriteLine("[I]solant : Cette action nécessite 3x de l'herbe");
            Console.WriteLine("[M]aison : Cette action nécessite 4x des Planches, 4x des Isolants , 4x des Briques ainsi que 2x des Vitres");
            Console.WriteLine("[C]onsulter Inventaire : Vous pouvez consulter votre inventaire pour vérifier que vous possédez toutes les ressources nécéssaires à la fabrication de matériaux");
            Console.WriteLine("Vous pouvez appuyer sur toutes les autres touches si vous ne voulez faire aucune action");
            Console.WriteLine("\t\t***********************************************************");

            ConsoleKeyInfo selectedAction = Console.ReadKey();
            return selectedAction.Key; 
        }
        public static void ProcessDisplayManufacturingInput()
        {
            ConsoleKey input = DisplayManufacturingMenu();

            switch (input)
            {
                case ConsoleKey.F:
                    Crafting.BuildFire();
                    break;

                case ConsoleKey.H:
                   Crafting.BuildAxe();
                    break;

                case ConsoleKey.V:
                    Crafting.BuildGlass();
                    break;

                case ConsoleKey.P:
                    Crafting.BuildPlank();
                    break;

                case ConsoleKey.B:
                    Crafting.BuildBrick();
                    break;

                case ConsoleKey.I:
                    Crafting.BuildInsulator();
                    break;

                case ConsoleKey.M:
                    Crafting.BuildHouse();
                    break;
                case ConsoleKey.C:
                    DisplayInventoryPrincipalMenu();
                    break;

                default:
                    break;
            }
        }

        public static int  DisplayInventoryPrincipalMenu()
        {
            Display.DisplayInventoryItems();
            Console.WriteLine("Bienvenue dans l'inventaire du jeu");
            Console.WriteLine("Dans cette section, vous pouvez consulter toutes les ?? qui sont à votre disposition");
            Console.WriteLine("Alors que voulez vous consulter en premier ?");
            Console.WriteLine("1. Vos ressources");
            Console.WriteLine("2. Vos matériaux");

            int input = int.Parse( Console.ReadLine() );
            return input;
        }
        // Traiter les saisis effectuer dans la méthode DisplayInventoryPrincipalMenu
        public static void ProcessInventoryInput()
        {
            int input = DisplayInventoryPrincipalMenu();

            switch(input)
            {
                case 1:
                    {
                        DisplayInventoryMenu1();
                        break;
                    }
                case 2:
                    {
                        DisplayInventoryMenu2();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Veuillez sélectionnez une option valide (1 ou 2 ou ESC si vous désirez quitter l'inventaire )");
                        break;
                    }
            }
        }
        //Afficher toute les ressources
        public static void DisplayInventoryMenu1()
        {
            Display.DisplayInventoryItem1();
            Console.WriteLine();

            Console.WriteLine("\t\t***********************************");
            Console.WriteLine("Nombres de Fer en stock: ");
            Console.WriteLine("Nombres de Bois en stock: ");
            Console.WriteLine("Nombres de Silex en stock: ");
            Console.WriteLine("Nombres de d'argiles en stock: ");
            Console.WriteLine("Nombres de d'Herbes en stock: ");
            Console.WriteLine("Nombres de de sable en stock: ");
        }
        //Affciher toutes les matériaux
        public static void DisplayInventoryMenu2()
        {
            Display.DisplayInventoryItem2();
            Console.WriteLine();

            Console.WriteLine("\t\t**********************************");
            Console.WriteLine("Nombres de Feu en stock: ");
            Console.WriteLine("Nombres de Haches en stock: ");
            Console.WriteLine("Nombres de Vitre en stock: ");
            Console.WriteLine("Nombres de Planche en stock: ");
            Console.WriteLine("Nombres de Briques en stock: ");
            Console.WriteLine("Nombres de Briques en stock: ");
            Console.WriteLine("Nombres d'Isolants en stock: ");
        }

    }
}
