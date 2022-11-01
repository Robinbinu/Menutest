using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Menutest
{
    internal class Phonenext
    {
        string choice = "y";
           private string[] options = { "New", "All","Search","Exit" };
        public Phonenext(int selectedindex)
        {

            if (options[selectedindex] == "New")
            {
                Console.Clear();
                //WriteLine("Starting game!!!");
                WriteLine(":::New Contact:::");
                do
                {
                    Console.Write("Contact Name:");
                    ReadLine();
                   // WriteLine("");
                    Console.Write("Contact Number:");
                    ReadLine();
                    //WriteLine("");
                    Console.Write("Do you want to add another contact? (y/n)");
                    choice=ReadLine();
                   // WriteLine("");

                } while (choice == "y");

                //ReadKey(true);
                menuplay1();


            }
            else if (options[selectedindex] == "All")
            {
                Console.Clear();
                WriteLine(@"

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
'                                              
'                                              
'                                              

");
                WriteLine(":)");
                WriteLine(System.DateTime.Now);
                ReadKey(true);
                menuplay1();

            }
            else if (options[selectedindex] == "Search")
            {
                WriteLine("Ready to search");
                ReadKey();
                menuplay1();
            }
            else
            {
                Console.Clear();
                Game game = new Game();
                //Console.Beep(1000,1000
            }
            void menuplay1()
            {
                Console.Clear();
                Phonebook phonebook = new Phonebook();

            }
        }
    }
    }

