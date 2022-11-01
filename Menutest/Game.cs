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
        private string prompt = "";
        private string[] options = {"CGPA","Phonebook","Game","About", "Exit" };
        public Game()
        {
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //id 0 for main menu
            Menu menu = new Menu(prompt, options,0,0);
            menu.DisplayOps();

        }

    }
}

