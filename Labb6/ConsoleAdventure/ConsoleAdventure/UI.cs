using ConsoleAdventure.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class UI
    {
        public void StartMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Console Text Adventure!");
            Console.WriteLine("\n1. Start game");
            Console.WriteLine("2. Graphics");
            Console.WriteLine("3. Exit");
        }
        public void GraphicsMenu()
        {
            Console.Clear();
            Console.WriteLine("Sorry this textgame has no graphics...");
            Console.WriteLine("Press ENTER to return");

            var choice = Console.ReadKey(true).Key;
            var loop = true;
            while(loop)
            {
                switch(choice)
                {
                    case ConsoleKey.Enter:
                        loop = false;
                        break;
                }
            }
        }
        public void GameInfo()
        {
            Console.Clear();
            Console.WriteLine("In this game you play as a hippopotatoplant.");
            Console.WriteLine("\nYour goal is to navigate through various rooms and find clues.");
            Console.WriteLine("\nWith the clues you must guess a secret word ");
            Console.WriteLine("\nThis secret word will unlock a special chest that grants you endless riches.");
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadKey();
        }

        HippoPotatoPlant Hippo = new HippoPotatoPlant();

        public void PlayerName()
        {
            Console.Clear();
            Console.Write("Enter thy name Hippopotatoplant: ");
            Hippo.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello " + Hippo.Name + " good luck!");
            Console.ReadKey();
        }

    }
}
