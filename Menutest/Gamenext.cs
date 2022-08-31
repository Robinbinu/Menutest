using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menutest
{
    internal class Gamenext
    {
        private string[] options = { "Play", "About", "Exit" };
        public Gamenext(int selectedindex)
        {

            if (options[selectedindex] == "Play")
            {
                Console.Clear();
                WriteLine("Starting game!!!");
                ReadKey(true);
                menuplay1();
                

            }
            else if (options[selectedindex] == "About")
            {
                Console.Clear();
                WriteLine("Developed by Robin");
                WriteLine(":)");
                WriteLine(System.DateTime.Now);
                ReadKey(true);
                menuplay1();

            }
            else
            {
                Console.Clear();
                WriteLine("Byeeeee\n press any key to exit :(");
                ReadKey(true);
                Console.Clear();
            }
            void menuplay1()
            {
                Game g = new Game();
            }
        }
    }
}
