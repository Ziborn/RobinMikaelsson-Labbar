using ConsoleAdventure.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class Runtime
    {
        public void Start()
        {

            var loop = true;
            var Ui = new UI();
            var game = new Gameplay();

            while(loop)
            {
                Ui.StartMenu();
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        Ui.GameInfo();
                        Ui.PlayerName();
                        game.GameStart();
                        break;
                    case ConsoleKey.D2:
                        Ui.GraphicsMenu();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
