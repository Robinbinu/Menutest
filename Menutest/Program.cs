using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menutest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title="PT-Assignment";
            Console.WindowHeight = LargestWindowHeight;
            Console.WindowWidth = LargestWindowWidth;
            Game game = new Game();
            ReadKey();

        }
    }
}
