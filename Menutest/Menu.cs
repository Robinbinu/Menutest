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
{//hi git
    internal class Menu
    {
        private string Prompt;
        private string[] Options;
        public int Selectedindex=0;
        private string prefix;
        private int temp = 0;
        int id;
        ConsoleKeyInfo keypress = new ConsoleKeyInfo();



        public Menu()
        {

        }

        public Menu(string prompt, string[] options, int temp,int id)
        {
            Prompt = prompt;
            Options = options;
            Selectedindex = temp;
            this.id= id;

        }

        public void DisplayOps()
        {
            
            WriteLine(Prompt);
            WriteLine("Option selected => "+Selectedindex);
            for (int i = 0; i < Options.Length; i++)
            {
                if(Selectedindex==i)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<<{Options[i]}>>");
                BackgroundColor = ConsoleColor.Black;
            }
            keypress = ReadKey();
            while (keypress.Key != ConsoleKey.Enter) 
            {
                {
                    if (keypress.Key == ConsoleKey.UpArrow)
                    {
                        Selectedindex--;
                        //Console.Beep(1000,200);

                    }
                    else if (keypress.Key == ConsoleKey.DownArrow)
                    {
                        Selectedindex++;

                        //Console.Beep(); 

                    }
                }

                if (Selectedindex > Options.Length - 1)
                {
                    Selectedindex = 0;

                }
                else if (Selectedindex < 0)
                {
                    Selectedindex = Options.Length - 1;
                }
                else
                {
                    WriteLine("ALl set");
                }
                temp = Selectedindex;

                Console.Clear();

                menuplay();
               


            }

            if (id == 0)
                _ = new Gamenext(Selectedindex);
            else if (id == 1)
                _ = new Phonenext(Selectedindex); 
            void menuplay()         
            {
                Menu menu = new Menu(Prompt, Options,temp,id);
                menu.DisplayOps();
            }
        }

    }
}
