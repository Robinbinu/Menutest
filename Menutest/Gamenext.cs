using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Menutest
{
    internal class Gamenext
    {
        private string[] options = { "C","P","G", "A", "E" };
        public Gamenext(int selectedindex)
        {
            if (options[selectedindex] == "C")
            {
                Console.Clear();
                CGPA cGPA = new CGPA();
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
            else if (options[selectedindex] =="G")
            {
                Console.Clear();
                WriteLine(":)");
                WriteLine(System.DateTime.Now);
                ReadKey(true);
                menuplay1();
            }
            else if (options[selectedindex] == "A")
            {
                Console.Clear();
                WriteLine(@"Developed by 

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
'                                              
'                                              
'                                              

");
                WriteLine(":)");
                WriteLine(System.DateTime.Now);
                ReadKey(true);
                menuplay1();

            }
            else
            {
                Console.Clear();
                WriteLine("Byeeeee\n press any key to exit :(");
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
