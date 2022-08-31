using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menutest
{
    internal class Game
    {
        private string prompt = "Hello Player!!! what's your choice?";
        private string[] options = { "Play", "About", "Exit" };
        private int selectedindex = 0;
        public Game()
        {
            Console.Clear();
            ConsoleKeyInfo keypress = new ConsoleKeyInfo();
            Menu menu = new Menu(prompt, options, selectedindex);
            menu.Displayops();

            while (keypress.Key != ConsoleKey.Enter)
            {
                keypress = ReadKey();
                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    selectedindex--;
                }
                else if (keypress.Key == ConsoleKey.DownArrow)
                {
                    selectedindex++;

                }
                
                if (selectedindex > options.Length - 1)
                {
                    selectedindex = 0;
                }
                else if (selectedindex < 0)
                {
                    selectedindex = options.Length - 1;
                }
                else
                {
                    WriteLine("ALl set");
                }

                Console.Clear();

                menuplay();

            }
            Gamenext g = new Gamenext(selectedindex);
            void menuplay()
            {
                menu = new Menu(prompt, options, selectedindex);
                menu.Displayops();
            }

           
            //ReadKey(true);
        }

    }
}

