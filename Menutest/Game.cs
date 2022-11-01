﻿using System;
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
        private string prompt = @"

      ___           ___           ___           ___     
     /__/\         /  /\         /__/\         /__/\    
    |  |::\       /  /:/_        \  \:\        \  \:\   
    |  |:|:\     /  /:/ /\        \  \:\        \  \:\  
  __|__|:|\:\   /  /:/ /:/_   _____\__\:\   ___  \  \:\ 
 /__/::::| \:\ /__/:/ /:/ /\ /__/::::::::\ /__/\  \__\:\
 \  \:\~~\__\/ \  \:\/:/ /:/ \  \:\~~\~~\/ \  \:\ /  /:/
  \  \:\        \  \::/ /:/   \  \:\  ~~~   \  \:\  /:/ 
   \  \:\        \  \:\/:/     \  \:\        \  \:\/:/  
    \  \:\        \  \::/       \  \:\        \  \::/   
     \__\/         \__\/         \__\/         \__\/    
   

" +
            "Hello User!!! what's your choice?";
        private string[] options = {"CGPA","Phonebook","Game","About", "Exit" };
        public Game()
        {
            //WriteLine("Commit test for github");
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //ConsoleKeyInfo keypress = new ConsoleKeyInfo();
            //id 0 for main menu
            Menu menu = new Menu(prompt, options,0,0);
            menu.DisplayOps();

        }

    }
}

