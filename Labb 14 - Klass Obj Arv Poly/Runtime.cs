using Labb_14___Klass_Obj_Arv_Poly.Classes;
using Labb_14___Klass_Obj_Arv_Poly.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_14___Klass_Obj_Arv_Poly
{
    class Runtime
    {
        Menu menu = new Menu();
        PublicationManager manager = new PublicationManager();

        public void Start()
        {
            

            var loop = true;

            while(loop)
            {
                Console.Clear();
                menu.StartMenu();
                var input = Console.ReadKey(true).Key;

                switch(input)
                {
                    case ConsoleKey.D1:
                        manager.FindAuthor();
                        break;
                    case ConsoleKey.D2:
                        manager.ShowPublications();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                }
            }
        }
    }
}
