using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Menutest
{
    internal class Gamenext
    {
        private string[] options = { "C", "P", "G", "A", "E" };
        public Gamenext(int selectedindex)
        {
            if (options[selectedindex] == "C")
            {
                Console.Clear();
                CGPAnext cGPA = new CGPAnext();
                cGPA.inputfirst();
                ReadKey(true);
                menuplay1();
            }
            else if (options[selectedindex] == "P")
            {
                Console.Clear();
                //WriteLine("Starting game!!!");
                Phonebook phonebook = new Phonebook();
                ReadKey(true);
                menuplay1();


            }
            else if (options[selectedindex] == "G")
            {
                Console.Clear();

                void ConsoleDraw(IEnumerable<string> lines, int x1, int y)
                {
                    if (x1 > Console.WindowWidth) return;
                    if (y > Console.WindowHeight) return;

                    var trimLeft = x1 < 0 ? -x1 : 0;
                    int index = y;

                    x1 = x1 < 0 ? 0 : x1;
                    y = y < 0 ? 0 : y;

                    var linesToPrint =
                        from line in lines
                        let currentIndex = index++
                        where currentIndex > 0 && currentIndex < Console.WindowHeight
                        select new
                        {
                            Text = new String(line.Skip(trimLeft).Take(Math.Min(Console.WindowWidth - x1, line.Length - trimLeft)).ToArray()),
                            X = x1,
                            Y = y++
                        };

                    Console.Clear();
                    foreach (var line in linesToPrint)
                    {
                        Console.SetCursorPosition(line.X, line.Y);
                        Console.Write(line.Text);
                    }
                }
               
                    var arr = new[]
                    {

@"      ___           ___           ___           ___     ",     
@"     /  /\         /  /\         /__/\         /  /\    ",
@"    /  /:/_       /  /::\       |  |::\       /  /:/_   ",
@"   /  /:/ /\     /  /:/\:\      |  |:|:\     /  /:/ /\  ",
@"  /  /:/_/::\   /  /:/~/::\   __|__|:|\:\   /  /:/ /:/_ ",
@" /__/:/__\/\:\ /__/:/ /:/\:\ /__/::::| \:\ /__/:/ /:/ /\",
@"  \:\ /~~/:/ \  \:\/:/__\/ \  \:\~~\__\/ \  \:\/:/ /:/ /",
@"  \  \:\  /:/   \  \::/       \  \:\        \  \::/ /:/ ",
@"   \  \:\/:/     \  \:\        \  \:\        \  \:\/:/  ",
@"    \  \::/       \  \:\        \  \:\        \  \::/   ",
@"     \__\/         \__\/         \__\/         \__\/    ",
                };
                    Console.WindowWidth = 160;
                    Console.WriteLine("\n\n");
                    var maxLength = arr.Aggregate(0, (max, line) => Math.Max(max, line.Length));
                    var x = Console.BufferWidth / 2 - maxLength / 2;
                    for (int y = -arr.Length; y < Console.WindowHeight + arr.Length; y++)
                    {
                        ConsoleDraw(arr, x, y);
                        Thread.Sleep(100);
                    }
                    Console.ReadKey();
                
               

                ReadKey(true);
                menuplay1();
            }



            else if (options[selectedindex] == "A")
            {
                Console.Clear();
                WriteLine(@"
   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 


Developed by 

'   __       __                                                              __ 
'  /  \     /  |                                                            /  |
'  $$  \   /$$ |  ______   _______    ______    ______    ______    ______  $$/ 
'  $$$  \ /$$$ | /      \ /       \  /      \  /      \  /      \  /      \ /  |
'  $$$$  /$$$$ | $$$$$$  |$$$$$$$  |/$$$$$$  |/$$$$$$  | $$$$$$  |/$$$$$$  |$$ |
'  $$ $$ $$/$$ | /    $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ | /    $$ |$$ |  $$/ $$ |
'  $$ |$$$/ $$ |/$$$$$$$ |$$ |  $$ |$$ \__$$ |$$ \__$$ |/$$$$$$$ |$$ |      $$ |
'  $$ | $/  $$ |$$    $$ |$$ |  $$ |$$    $$/ $$    $$ |$$    $$ |$$ |      $$ |
'  $$/      $$/  $$$$$$$/ $$/   $$/  $$$$$$/   $$$$$$$ | $$$$$$$/ $$/       $$/ 
'                                             /  \__$$ |                        
'                                             $$    $$/                         
'                                              $$$$$$/                          

'   /$$$$$$$            /$$       /$$          
'  | $$__  $$          | $$      |__/          
'  | $$  \ $$  /$$$$$$ | $$$$$$$  /$$ /$$$$$$$ 
'  | $$$$$$$/ /$$__  $$| $$__  $$| $$| $$__  $$
'  | $$__  $$| $$  \ $$| $$  \ $$| $$| $$  \ $$
'  | $$  \ $$| $$  | $$| $$  | $$| $$| $$  | $$
'  | $$  | $$|  $$$$$$/| $$$$$$$/| $$| $$  | $$
'  |__/  |__/ \______/ |_______/ |__/|__/  |__/

");
                ReadKey(true);
                menuplay1();

            }
            else
            {
                Console.Clear();
                WriteLine(@"


                                                
8 888888888o  `8.`8888.      ,8' 8 8888888888   
8 8888    `88. `8.`8888.    ,8'  8 8888         
8 8888     `88  `8.`8888.  ,8'   8 8888         
8 8888     ,88   `8.`8888.,8'    8 8888         
8 8888.   ,88'    `8.`88888'     8 888888888888 
8 8888888888       `8. 8888      8 8888         
8 8888    `88.      `8 8888      8 8888         
8 8888      88       8 8888      8 8888         
8 8888    ,88'       8 8888      8 8888         
8 888888888P         8 8888      8 888888888888 
"
+ "press any key to exit :(");
                //Application.Exit();
                ReadKey(true);
                //Console.Beep(1000,1000);
                Environment.Exit(0);
                Console.Clear();
            }
            void menuplay1()
            {
                Game g = new Game();
            }
        }
    }
}
