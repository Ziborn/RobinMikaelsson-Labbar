using ConsoleAdventure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure.Classes
{
    class Gameplay
    {
        int npcInRoom;
        int roomChosen;
        
        public List<INonPlayerCharacter> newNpcList = new List<INonPlayerCharacter>
        {
            new Human { Description = "a tiny little man with a long beard",
                Dialouge = "Hello stranger, in the main hall there is a chest that is said to hold great treasure..."},
            new Human { Description = "a mysterious red haired woman" ,
                Dialouge = "The chest in the main hall has a password, there are said to be clues around the rooms. Nobody has managed to figure it out yet..."},

            new StrangeAnimals {Description = "a tiny hedgehog with unusully large spikes on its back.",
                Dialouge = "ithithithtih" },

            new StrangeAnimals {Description = "a small squirrel that has a tale with the lenght of 2 meters." ,
                Dialouge = "ssquiiiiik"},

            new Human {Description = "noone else...", Dialouge = "There is noone to interact with..." }
       };
        public List<IEnviroment> newEnviromentList = new List<IEnviroment>
        {
           new Room {Size = "huge", Enviroment = "it is a main hall to some crazy castle with 6 doors.",
               Item = "Golden chest",
               ItemAction = "The chest is locked..." },

           new Room {Size = "normal", Enviroment = "the room has a stone floor and stone walls.",
               Item = "Wooden Chest",
               ItemAction = "You open the chest and find a paper that says \"cat\"" },

            new Room {Size = "small", Enviroment = "this room has a really high ceiling and it almost looks like it has no roof.",
               Item = "Pine tree",
                ItemAction = "It looks like there is dog piss all around the tree" },

           new Room {Size = "large", Enviroment = "it is a very cold and dark room.",
               Item = "Ice block",
               ItemAction = "You take a closer look at the iceblock and see a frozen guineapig inside with a necklace on that has the name \"Igor\" written on it." },

           new Room {Size = "normal", Enviroment = "the room has a strange smell and there is a distant sound from a hole in the wall",
               Item = "piece of paper",
               ItemAction = "you pick up the paper and read it.. it says \"dog\"" },

           new Yard {Size = "Large", Enviroment = "it is the garden to the castle, it got some potatoplants and other gardenstuff",
               Item = "Garden hoe",
               ItemAction = "You pick up the garden hoe and throw it 1 meter.." }
        };
        public void GameStart()
        {
            var loop = true;

            Console.Clear();
            Console.WriteLine("You stand in front of a strange castle, there is a huge main entrance in front of you...");
            Console.WriteLine("\nPress numpad 8 if you want to enter the castle.");

            while (loop)
            {
                var input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.NumPad8:
                        Console.Clear();
                        Console.WriteLine("You enter the castle");
                        Console.ReadLine();
                        loop = false;
                        GameLoop();
                        break;
                }
            }
        }
        public void GameLoop()
        {
            
            var loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("Standing in the castle you have the following options:");
                Console.WriteLine("\n1. Look around the room");
                Console.WriteLine("2. Interact with item");
                Console.WriteLine("0. Leave the castle!");
                Console.WriteLine("\nNavigate into a new room with numpad 1, 2, 3, 4, 5");

                var input = Console.ReadKey(true).Key;
                
                switch (input)
                {
                    case ConsoleKey.NumPad1:
                        npcInRoom = 0;
                        roomChosen = 1;
                        RoomActions();
                        break;
                    case ConsoleKey.NumPad2:
                        npcInRoom = 3;
                        roomChosen = 2;
                        RoomActions();
                        break;
                    case ConsoleKey.NumPad3:
                        npcInRoom = 1;
                        roomChosen = 3;
                        RoomActions();
                        break;
                    case ConsoleKey.NumPad4:
                        npcInRoom = 4;
                        roomChosen = 4;
                        RoomActions();
                        break;
                    case ConsoleKey.NumPad5:
                        npcInRoom = 2;
                        roomChosen = 5;
                        RoomActions();
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("You flee the castle!");
                        Console.ReadKey(true);
                        loop = false;
                        break;
                    case ConsoleKey.D1:
                        roomChosen = 0;
                        npcInRoom = 4;
                        ShowRoomInfo();
                        ShowNpcInfo();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        InteractItem();
                        GuessWord();
                        Console.ReadKey(true);
                        break;
                }
            }
        }
        public void ShowRoomInfo()
        {
            Console.Clear();
            Console.WriteLine(newEnviromentList[roomChosen].ObserveEnviroment());
        }
        public void ShowNpcInfo()
        {
            Console.WriteLine("\n" + newNpcList[npcInRoom].NpcDescription());
        }
        public void RoomActions()
        {
            
            var loop = true;

            while(loop)
            {
                Console.Clear();
                Console.WriteLine("You enter a new place...");
                Console.WriteLine("\n1. Look around the place");
                Console.WriteLine("2. Interact with NPC");
                Console.WriteLine("3. Interact with item");
                Console.WriteLine("Press numpad 0 to return");

                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        ShowRoomInfo();
                        ShowNpcInfo();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D2:
                        InteractNPC();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.D3:
                        InteractItem();
                        Console.ReadKey(true);
                        break;
                    case ConsoleKey.NumPad0:
                        loop = false;
                        break;
                }
            }
        }
        public void InteractNPC()
        {
            Console.Clear();
            Console.WriteLine(newNpcList[npcInRoom].Speak());
        }
        public void InteractItem()
        {
            Console.Clear();
            Console.WriteLine(newEnviromentList[roomChosen].ItemInteraction());
        }
        public void GuessWord()
        {
            
            Console.WriteLine("The chest asks me for a word..");
            string input = Console.ReadLine().ToLower();
            
            if (input == "pet")
                GameWon();
            else
                Console.WriteLine("That is the incorrect word..");
            
        }
        public void GameWon()
        {
            Console.WriteLine("Congratulations you have opened the chest to endless riches. You can now rule the entire world...");
            Console.ReadLine();
            Environment.Exit(1);
        }


    }
}
