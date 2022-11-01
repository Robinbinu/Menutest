using System;
using static System.Console;

namespace Menutest
{
    internal class Menu
    {
        private string Prompt;
        private string[] Options;
        public int Selectedindex = 0;
        private string prefix;
        private int temp = 0;
        int id;
        ConsoleKeyInfo keypress = new ConsoleKeyInfo();



        public Menu()
        {

        }

        public Menu(string prompt, string[] options, int temp, int id)
        {
            Prompt = prompt;
            Options = options;
            Selectedindex = temp;
            this.id = id;

        }
        public void menu(string prompt, string[] options, int temp, int id)
        {
            Prompt = prompt;
            Options = options;
            Selectedindex = temp;
            this.id = id;

        }

        public void DisplayOps()
        {
            promptselector();
            WriteLine(Prompt);
            WriteLine("Option selected => " + (Selectedindex+1));
            for (int i = 0; i < Options.Length; i++)
            {
                if (Selectedindex == i)
                {
                    prefix = ">";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix} {Options[i]} ");
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
                    WriteLine("All set");
                }
                temp = Selectedindex;

                Console.Clear();

                menuplay();



            }


            if (id == 0)
                _ = new Gamenext(Selectedindex);
            else if (id == 1)
            {
                _ = new Phonenext(Selectedindex);
            }
            else if (id == 2)
            {
                _ = new CGPAnext();
                CGPAnext c = new CGPAnext();
                c.CGPAdeptnext(Selectedindex);
                c.CGPAsemnext();

            }  
            
                void menuplay()
            {
                promptselector();
                menu(Prompt, Options, temp, id);
                DisplayOps();
            }
        }

        private void promptselector()
        {
            if (id == 0)
            {
                if (temp == 0)
                    Prompt = @"
      ___           ___           ___         ___     
     /  /\         /  /\         /  /\       /  /\    
    /  /:/        /  /:/_       /  /::\     /  /::\   
   /  /:/        /  /:/ /\     /  /:/\:\   /  /:/\:\  
  /  /:/  ___   /  /:/_/::\   /  /:/~/:/  /  /:/~/::\ 
 /__/:/  /  /\ /__/:/__\/\:\ /__/:/ /:/  /__/:/ /:/\:\
 \  \:\ /  /:/ \  \:\ /~~/:/ \  \:\/:/   \  \:\/:/__\/
  \  \:\  /:/   \  \:\  /:/   \  \::/     \  \::/     
   \  \:\/:/     \  \:\/:/     \  \:\      \  \:\     
    \  \::/       \  \::/       \  \:\      \  \:\    
     \__\/         \__\/         \__\/       \__\/    
" +
        "Hello User!!! what's your choice?";
                else if (temp == 1)
                    Prompt = @"
      ___         ___           ___           ___           ___     
     /  /\       /__/\         /  /\         /__/\         /  /\    
    /  /::\      \  \:\       /  /::\        \  \:\       /  /:/_   
   /  /:/\:\      \__\:\     /  /:/\:\        \  \:\     /  /:/ /\  
  /  /:/~/:/  ___ /  /::\   /  /:/  \:\   _____\__\:\   /  /:/ /:/_ 
 /__/:/ /:/  /__/\  /:/\:\ /__/:/ \__\:\ /__/::::::::\ /__/:/ /:/ /\
 \  \:\/:/   \  \:\/:/__\/ \  \:\ /  /:/ \  \:\~~\~~\/ \  \:\/:/ /:/
  \  \::/     \  \::/       \  \:\  /:/   \  \:\  ~~~   \  \::/ /:/ 
   \  \:\      \  \:\        \  \:\/:/     \  \:\        \  \:\/:/  
    \  \:\      \  \:\        \  \::/       \  \:\        \  \::/   
     \__\/       \__\/         \__\/         \__\/         \__\/   
"
+
        "Hello User!!! what's your choice?";
                else if (temp == 2)
                    Prompt = @"
      ___           ___           ___           ___     
     /  /\         /  /\         /__/\         /  /\    
    /  /:/_       /  /::\       |  |::\       /  /:/_   
   /  /:/ /\     /  /:/\:\      |  |:|:\     /  /:/ /\  
  /  /:/_/::\   /  /:/~/::\   __|__|:|\:\   /  /:/ /:/_ 
 /__/:/__\/\:\ /__/:/ /:/\:\ /__/::::| \:\ /__/:/ /:/ /\
 \  \:\ /~~/:/ \  \:\/:/__\/ \  \:\~~\__\/ \  \:\/:/ /:/
  \  \:\  /:/   \  \::/       \  \:\        \  \::/ /:/ 
   \  \:\/:/     \  \:\        \  \:\        \  \:\/:/  
    \  \::/       \  \:\        \  \:\        \  \::/   
     \__\/         \__\/         \__\/         \__\/    
" +
        "Hello User!!! what's your choice?";
                else if (temp == 3)
                    Prompt = @"
      ___                         ___           ___                 
     /  /\         _____         /  /\         /__/\          ___   
    /  /::\       /  /::\       /  /::\        \  \:\        /  /\  
   /  /:/\:\     /  /:/\:\     /  /:/\:\        \  \:\      /  /:/  
  /  /:/~/::\   /  /:/~/::\   /  /:/  \:\   ___  \  \:\    /  /:/   
 /__/:/ /:/\:\ /__/:/ /:/\:| /__/:/ \__\:\ /__/\  \__\:\  /  /::\   
 \  \:\/:/__\/ \  \:\/:/~/:/ \  \:\ /  /:/ \  \:\ /  /:/ /__/:/\:\  
  \  \::/       \  \::/ /:/   \  \:\  /:/   \  \:\  /:/  \__\/  \:\ 
   \  \:\        \  \:\/:/     \  \:\/:/     \  \:\/:/        \  \:\
    \  \:\        \  \::/       \  \::/       \  \::/          \__\/
     \__\/         \__\/         \__\/         \__\/                
" +
        "Hello User!!! what's your choice?";
                else if (temp == 4)
                    Prompt = @"
      ___           ___                             
     /  /\         /__/|        ___           ___   
    /  /:/_       |  |:|       /  /\         /  /\  
   /  /:/ /\      |  |:|      /  /:/        /  /:/  
  /  /:/ /:/_   __|__|:|     /__/::\       /  /:/   
 /__/:/ /:/ /\ /__/::::\____ \__\/\:\__   /  /::\   
 \  \:\/:/ /:/    ~\~~\::::/    \  \:\/\ /__/:/\:\  
  \  \::/ /:/      |~~|:|~~      \__\::/ \__\/  \:\ 
   \  \:\/:/       |  |:|        /__/:/       \  \:\
    \  \::/        |  |:|        \__\/         \__\/
     \__\/         |__|/                                         
" +
        "Hello User!!! what's your choice?";
            }
            else if(id == 2)
            {

                {
                    if (temp == 0)
                        Prompt = @"
      ___           ___           ___     
     /  /\         /  /\         /  /\    
    /  /:/        /  /:/_       /  /:/_   
   /  /:/        /  /:/ /\     /  /:/ /\  
  /  /:/  ___   /  /:/ /::\   /  /:/ /:/_ 
 /__/:/  /  /\ /__/:/ /:/\:\ /__/:/ /:/ /\
 \  \:\ /  /:/ \  \:\/:/~/:/ \  \:\/:/ /:/
  \  \:\  /:/   \  \::/ /:/   \  \::/ /:/ 
   \  \:\/:/     \__\/ /:/     \  \:\/:/  
    \  \::/        /__/:/       \  \::/   
     \__\/         \__\/         \__\/    

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀                                       
"
+
            "Enter your Department";
                    else if (temp == 1)
                        Prompt = @"
      ___           ___           ___     
     /  /\         /  /\         /  /\    
    /  /:/_       /  /:/        /  /:/_   
   /  /:/ /\     /  /:/        /  /:/ /\  
  /  /:/ /:/_   /  /:/  ___   /  /:/ /:/_ 
 /__/:/ /:/ /\ /__/:/  /  /\ /__/:/ /:/ /\
 \  \:\/:/ /:/ \  \:\ /  /:/ \  \:\/:/ /:/
  \  \::/ /:/   \  \:\  /:/   \  \::/ /:/ 
   \  \:\/:/     \  \:\/:/     \  \:\/:/  
    \  \::/       \  \::/       \  \::/   
     \__\/         \__\/         \__\/   

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
"
    +
            "Enter your Department";
                    else if (temp == 2)
                        Prompt = @"
      ___                       ___     
     /  /\        ___          /  /\    
    /  /:/_      /  /\        /  /:/_   
   /  /:/ /\    /  /:/       /  /:/ /\  
  /  /:/ /:/_  /__/::\      /  /:/ /:/_ 
 /__/:/ /:/ /\ \__\/\:\__  /__/:/ /:/ /\
 \  \:\/:/ /:/    \  \:\/\ \  \:\/:/ /:/
  \  \::/ /:/      \__\::/  \  \::/ /:/ 
   \  \:\/:/       /__/:/    \  \:\/:/  
    \  \::/        \__\/      \  \::/   
     \__\/                     \__\/    

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
" +
            "Enter your Department";
                    else if (temp == 3)
                        Prompt = @"
      ___           ___           ___     
     /  /\         /__/\         /  /\    
    /  /:/         \  \:\       /  /:/_   
   /  /:/           \__\:\     /  /:/ /\  
  /  /:/  ___   ___ /  /::\   /  /:/ /:/_ 
 /__/:/  /  /\ /__/\  /:/\:\ /__/:/ /:/ /\
 \  \:\ /  /:/ \  \:\/:/__\/ \  \:\/:/ /:/
  \  \:\  /:/   \  \::/       \  \::/ /:/ 
   \  \:\/:/     \  \:\        \  \:\/:/  
    \  \::/       \  \:\        \  \::/   
     \__\/         \__\/         \__\/   

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
" +
            "Enter your Department";
                    else if (temp == 4)
                        Prompt = @"
      ___           ___           ___     
     /__/\         /  /\         /  /\    
    |  |::\       /  /:/_       /  /:/    
    |  |:|:\     /  /:/ /\     /  /:/     
  __|__|:|\:\   /  /:/ /:/_   /  /:/  ___ 
 /__/::::| \:\ /__/:/ /:/ /\ /__/:/  /  /\
 \  \:\~~\__\/ \  \:\/:/ /:/ \  \:\ /  /:/
  \  \:\        \  \::/ /:/   \  \:\  /:/ 
   \  \:\        \  \:\/:/     \  \:\/:/  
    \  \:\        \  \::/       \  \::/   
     \__\/         \__\/         \__\/    

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
" +
            "Enter your Department";
                    else if (temp == 5)
                        Prompt = @"
      ___           ___           ___     
     /  /\         /  /\         /  /\    
    /  /:/_       /  /:/_       /  /:/_   
   /  /:/ /\     /  /:/ /\     /  /:/ /\  
  /  /:/ /:/_   /  /:/ /:/_   /  /:/ /:/_ 
 /__/:/ /:/ /\ /__/:/ /:/ /\ /__/:/ /:/ /\
 \  \:\/:/ /:/ \  \:\/:/ /:/ \  \:\/:/ /:/
  \  \::/ /:/   \  \::/ /:/   \  \::/ /:/ 
   \  \:\/:/     \  \:\/:/     \  \:\/:/  
    \  \::/       \  \::/       \  \::/   
     \__\/         \__\/         \__\/    

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
" +
            "Enter your Department";
                    else if (temp == 6)
                        Prompt = @"
      ___           ___     
     /  /\         /  /\    
    /  /:/        /  /:/_   
   /  /:/        /  /:/ /\  
  /  /:/  ___   /  /:/ /:/_ 
 /__/:/  /  /\ /__/:/ /:/ /\
 \  \:\ /  /:/ \  \:\/:/ /:/
  \  \:\  /:/   \  \::/ /:/ 
   \  \:\/:/     \  \:\/:/  
    \  \::/       \  \::/   
     \__\/         \__\/    

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
" +
            "Enter your Department";
                    else if (temp == 7)
                        Prompt = @"
                        
    ___           ___   
   /  /\         /  /\  
  /  /:/        /  /:/  
 /__/::\       /  /:/   
 \__\/\:\__   /  /::\   
    \  \:\/\ /__/:/\:\  
     \__\::/ \__\/  \:\ 
     /__/:/       \  \:\
     \__\/         \__\/
                        

   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀ 
" +
            "Enter your Department";
                }
            }
        }
    }
}
