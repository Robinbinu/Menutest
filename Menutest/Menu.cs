using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
    
namespace Menutest
{
    internal class Menu
    {
        private string Prompt;
        private string[] Options;
        public int Selectedindex;
        private string prefix;

        public Menu()
        {

        }

        public Menu(string prompt, string[] options, int selectedindex)
        {
            Prompt = prompt;
            Options = options;
            Selectedindex = selectedindex;
        }

        public void Displayops()
        {
            WriteLine(Prompt);

            for(int i = 0; i < Options.Length; i++)
            {
                if(Selectedindex==i)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<<{Options[i]}>>");
                ResetColor();
            }
        }

    }
}
